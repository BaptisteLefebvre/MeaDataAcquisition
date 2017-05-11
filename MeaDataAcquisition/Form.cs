using Mcs.Usb;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace MeaDataAcquisition
{
    public partial class Form : System.Windows.Forms.Form
    {
        private CMcsUsbListNet usbList = new CMcsUsbListNet(); // TODO understand MCS black magic.
        private CMcsUsbListEntryNet usb = null; // TODO understand MCS black magic.
        private CMeaDeviceNet device = null; // TODO understand MCS black magic.

        private int buf_size = 0;
        private int buf_acq_nb = 0; // number of acquired buffers
        private int buf_bck_nb = 0; // number of backuped buffers
        private int buf_brd_nb = 0; // number of broadcasted buffers

        private int nb_channels = 0; // TODO understand MCS black magic.
        private int sample_rate = 0; // TODO understand MCS black magic.
        private int gain = 0; // TODO understand MCS black magic.
        private int channels_in_block = 0; // TODO understand MCS black magic.
        private bool[] selected_channels = null; // TODO understand MCS black magic.
        private int queue_size = 0; // TODO understand MCS black magic.
        private int threshold = 0; // TODO understand MCS black magic.
        private CMcsUsbDacqNet.SampleSize sample_size = CMcsUsbDacqNet.SampleSize.Size16; // TODO understand MCS black magic.

        private bool backupEnabled = false;
        private string dataBackupFilename = null;
        private BinaryWriter dataBackupWriter = null;

        private bool broadcastEnabled = false;
        private UdpClient udpClient = null;
        private int udpClientPort = 40005;
        private string udpClientHostname = IPAddress.Broadcast.ToString();

        public Form()
        {
            InitializeComponent();
        }

        // Occurs whenever the user loads the form.
        private void Form_Load(object sender, EventArgs e)
        {
            // Initialize the combo box which lists all the MEA devices.
            ComboBoxMeaDevices_Initialize();
            // Select the only one MEA device listed by the combo box (id possible).
            if (comboBoxMeaDevices.Items.Count == 1)
            {
                comboBoxMeaDevices.SelectedIndex = 0;
            }
            // Initialize the text box which shows the hostname targeted by the UDP client.
            TextBoxDataBroadcastHostname_Initialize();
            // Initialize the text box which shows the port used by the UDP client.
            TextBoxDataBroadcastPort_Initialize();
        }
        
        // Occurs when the drop-down portion of the combo box is shown.
        private void ComboBoxMeaDevices_DropDown(object sender, EventArgs e)
        {
            ComboBoxMeaDevices_Initialize();
        }

        private void ComboBoxMeaDevices_Initialize()
        {
            // Clear all the MEA devices listed by the combo box.
            comboBoxMeaDevices.Items.Clear();
            // TODO understand MCS black magic.
            usbList.Initialize(DeviceEnumNet.MCS_MEA_DEVICE);
            // Add each MEA device to the combo box.
            for (var i = 0; i < usbList.Count; i++)
            {
                var index = (uint) i;
                var usbEntry = usbList.GetUsbListEntry(index);
                var deviceName = usbEntry.DeviceName;
                var serialNumber = usbEntry.SerialNumber;
                var item = deviceName + " / " + serialNumber;
                comboBoxMeaDevices.Items.Add(item);
            }
            // TODO remove the following block.
            //{
            //    comboBoxMeaDevices.Items.Add("MEA #1");
            //    comboBoxMeaDevices.Items.Add("MEA #2");
            //}
        }

        // Occurs when the value of the selected index of the combo box (i.e. the seleted MEA device) changes.
        private void ComboBoxMeaDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = (uint) comboBoxMeaDevices.SelectedIndex;
            // TODO understand MCS black magic.
            usb = usbList.GetUsbListEntry(index);
            // TODO understand MCS black magic.
            device = new CMeaDeviceNet(usb.BusType, ChannelDataCallback, ErrorCallback);
            // Establish a connection to the required DAQ device.
            device.Connect(usb);
            // TODO understand MCS black magic.
            device.SendStop();
            // TODO understand MCS black magic.
            var HardwareInfo = device.HWInfo();
            // Get the number of available analog hardware channels.
            HardwareInfo.GetNumberOfHWADCChannels(out nb_channels);
            // Set the number of analog hardware channels to the maximum.
            device.SetNumberOfChannels(nb_channels);
            // Update the text box which displays the number of analog hardware channels.
            textBoxNumberOfChannels.Text = nb_channels.ToString();
            // TODO understand MCS black magic.
            //HardwareInfo.GetAvailableSampleRates(out List<int> sample_rates);
            sample_rate = 20000;
            // TODO understand MCS black magic.
            device.SetSampleRate(sample_rate);
            textBoxSampleRate.Text = sample_rate.ToString();
            // TODO understand MCS black magic.
            device.GetGain(out gain);
            textBoxGain.Text = gain.ToString();
            // TODO understand MCS black magic.
            //HardwareInfo.GetAvailableVoltageRangesInMicroVoltAndStringsInMilliVolt(out List<CMcsUsbDacqNet.CHWInfo.CVoltageRangeInfoNet> voltage_ranges);
            //var voltage_range = 10;
            // TODO understand MCS black magic.
            //Device.SetVoltageRangeInMicroVolt(voltage_range);
            // TODO understand MCS black magic.
            device.EnableDigitalIn(false);
            // TODO understand MCS black magic.
            device.EnableChecksum(false);
            // TODO understand MCS black magic.
            //Device.EnableTimestamp(false);
            // TODO understand MCS black magic.
            //Device.GetChannelLayout(out int analog_channels, out int digital_channels, out int checksum_channels, out int timestamp_channels, out int channels_in_block);
            device.GetChannelsInBlock(out channels_in_block);
            textBoxChannelsInBlock.Text = channels_in_block.ToString();
            // ...
            selected_channels = new bool[channels_in_block];
            for (var i = 0; i < channels_in_block; i++)
            {
                selected_channels[i] = true;
            }
            // TODO check the value of the buffer size.
            buf_size = sample_rate / 100;
            queue_size = 10 * buf_size;
            textBoxQueueSize.Text = queue_size.ToString();
            // ...
            threshold = buf_size;
            textBoxThreshold.Text = threshold.ToString();
            // ...
            sample_size = CMcsUsbDacqNet.SampleSize.Size16;
            textBoxSampleSize.Text = sample_size.ToString();
            // Enable control.
            textBoxQueueSize.Enabled = true;
            textBoxThreshold.Enabled = true;
            buttonDataAcquisitionStart.Enabled = true;
        }

        void ChannelDataCallback(CMcsUsbDacqNet UsbDacq, int cb_handle, int num_frames)
        {
            // Read raw data.
            var handle = 0;
            var frames = buf_size;
            int frames_ret;
            ushort[] channelData = device.ChannelBlock_ReadFramesUI16(handle, frames, out frames_ret);
            // or
            // ushort[] buffer = null;
            // int frames_pos = 0;
            // device.ChannelBlock_ReadFramesUI16(handle, buffer, frames_pos, frames, out frames_ret);
            // Update the number of acquired buffers.
            buf_acq_nb = buf_acq_nb + 1;
            // Update the display of the number of acquired buffers.
            textBoxBufferAcquired.Text = buf_acq_nb.ToString();
            // Save raw data.
            if (backupEnabled)
            {
                for (var i = 0; i < channelData.Length; i++)
                {
                    dataBackupWriter.Write(channelData[i]);
                    // TODO use one delegate?
                }
                // Update the number of backuped buffers.
                buf_bck_nb = buf_bck_nb + 1;
                // Update the display of the number of backuped buffers.
                textBoxBufferBackuped.Text = buf_bck_nb.ToString();
            }
            // Send raw data.
            if (broadcastEnabled)
            {
                var method = new SendChannelDataDelegate(SendChannelData);
                var arguments = new object[1];
                arguments[0] = channelData;
                BeginInvoke(method, arguments);
                // Update the number of broadcasted buffers.
                buf_brd_nb = buf_brd_nb + 1;
                // Update the display of the number of broadcasted buffers.
                textBoxBufferBroadcasted.Text = buf_brd_nb.ToString();
            }
        }

        private delegate void SendChannelDataDelegate(ushort[] channelData);

        private void SendChannelData(ushort[] channelData)
        {
            // Send UDP datagram.
            var nb_bytes = channelData.Length;
            // Log the size of the UDP datagram.
            textBoxLog.Text += nb_bytes.ToString() + " bytes\r\n";
            var datagram = new byte[nb_bytes];
            Buffer.BlockCopy(channelData, 0, datagram, 0, channelData.Length);
            try
            {
                udpClient.Send(datagram, nb_bytes, udpClientHostname, udpClientPort);
            }
            catch (SocketException socketException)
            {
                textBoxLog.Text += "SocketException\r\n";
                textBoxLog.Text += socketException.ToString() + "\r\n";
            }
        }

        void ErrorCallback(string message, int action)
        {
            // throw new NotImplementedException();
            textBoxLog.Text += "ErrorCallback\r\n";
            textBoxLog.Text += message + "\r\n";
        }

        // Occurs when the 'Start' button of the 'Data acquisition' group is clicked.
        private void ButtonDataAcquisitionStart_Click(object sender, EventArgs e)
        {
            // Disable controls.
            comboBoxMeaDevices.Enabled = false;
            textBoxQueueSize.Enabled = false;
            textBoxThreshold.Enabled = false;
            buttonDataAcquisitionStart.Enabled = false;
            // TODO understand MCS black magic.
            device.SetSelectedData(selected_channels, queue_size, threshold, sample_size, channels_in_block);
            // Update the number of acquired buffers.
            buf_acq_nb = 0;
            // Update the display of the number of acquired buffers.
            textBoxBufferAcquired.Text = buf_acq_nb.ToString();
            // Start data acquisition.
            device.StartDacq();
            // Enable controls.
            buttonStop.Enabled = true;
            groupBoxDataBackup.Enabled = true;
            groupBoxDataBroadcast.Enabled = true;
        }

        // Occurs when the 'Stop' button of the 'Data acquisition' group is clicked.
        private void ButtonDataAcquisitionStop_Click(object sender, EventArgs e)
        {
            // Disable controls.
            groupBoxDataBroadcast.Enabled = false;
            groupBoxDataBackup.Enabled = false;
            buttonStop.Enabled = false;
            // Stop data acquisition.
            try
            {
                // TODO understand MCS black magic.
                device.StopDacq();
            }
            catch (CUsbExceptionNet cUsbExceptionNet)
            {
                // TODO check that the data acquisition is really stopped.
                textBoxLog.Text += cUsbExceptionNet.ToString() + "\r\n";
            }
            // Enable controls.
            buttonDataAcquisitionStart.Enabled = true;
            textBoxThreshold.Enabled = true;
            textBoxQueueSize.Enabled = true;
            comboBoxMeaDevices.Enabled = true;
        }

        // Occurs whe the 'Browse' button of the 'Data backup' group is clicked.
        private void ButtonDataBackupBrowse_Click(object sender, EventArgs e)
        {
            // Dialog to select file for backup.
            SaveFileDialog dataBackupFileDialog = new SaveFileDialog();
            // Default filename.
            dataBackupFileDialog.FileName = "data_backup.raw";
            // Show backup file dialog box.
            DialogResult dialogResult = dataBackupFileDialog.ShowDialog();
            // Process backup file dialog box results.
            if (dialogResult == DialogResult.OK)
            {
                // Retrieve filename.
                var filename = dataBackupFileDialog.FileName;
                // TODO assert data backup filename is correct?
                // Set data backup filename.
                dataBackupFilename = filename;
                // Display backup filename.
                textBoxDataBackupPath.Text = dataBackupFilename;
            }
        }

        // Occurs when the value ot the text in the 'Path' box is changed.
        private void TextBoxDataBackupPath_TextChanged(object sender, EventArgs e)
        {
            // Retrieve filename.
            var filename = textBoxDataBackupPath.Text;
            // TODO addset data backup filename is correct?
            dataBackupFilename = filename;
        }

        // Occurs when the 'Start' button of the 'Data backup' group is clicked.
        private void ButtonDataBackupStart_Click(object sender, EventArgs e)
        {
            // TODO assert data backup filename is correct(again)?
            // Disable control.
            buttonDataBackupStart.Enabled = false;
            buttonDataBackupBrowse.Enabled = false;
            // Update the number of backuped buffers.
            buf_bck_nb = 0;
            // Update the display of the number of broadcasted buffers.
            textBoxBufferAcquired.Text = buf_bck_nb.ToString();
            // Create backup file.
            var dataBackupFile = File.Open(dataBackupFilename, FileMode.Create);
            // Create backup writer.
            dataBackupWriter = new BinaryWriter(dataBackupFile);
            // Turn on backup flag.
            backupEnabled = true;
            // Enable control.
            buttonDataBackupStop.Enabled = true;
        }

        // Occurs when the 'Stop' button of the 'Data backup' group is clicked.
        private void ButtonDataBackupStop_Click(object sender, EventArgs e)
        {
            // Disable control.
            buttonDataBackupStop.Enabled = false;
            // Turn off backup flag.
            backupEnabled = false;
            // Enable control.
            buttonDataBackupBrowse.Enabled = true;
            buttonDataBackupStart.Enabled = true;
        }

        private void TextBoxDataBroadcastHostname_Initialize()
        {
            textBoxDataBroadcastHostname.Text = udpClientHostname.ToString();
        }

        private void TextBoxDataBroadcastPort_Initialize()
        {
            textBoxDataBroadcastPort.Text = udpClientPort.ToString();
        }

        // Occurs when the 'Start' button of the 'Data broadcast' group is clicked.
        private void ButtonDataBroadcastStart_Click(object sender, EventArgs e)
        {
            // Disable controls.
            buttonDataBroadcastStart.Enabled = false;
            // Update the number of broadcasted buffers.
            buf_brd_nb = 0;
            // Update the display of the number of broadcasted buffer.
            textBoxBufferAcquired.Text = buf_brd_nb.ToString();
            // Create UDP client.
            udpClient = new UdpClient(udpClientPort);
            // Adjust buffer size.
            udpClient.Client.SendBufferSize = buf_size;
            // TODO check if the previous line is valid.
            // Turn on broadcast flag.
            broadcastEnabled = true;
            // Enable control.
            buttonDataBroadcastStop.Enabled = true;
        }

        // Occurs when the 'Stop' button of the 'Data broadcast' group is clicked.
        private void ButtonDataBroadcastStop_Click(object sender, EventArgs e)
        {
            // Disable control.
            buttonDataBroadcastStop.Enabled = false;
            // Close UDP client.
            udpClient.Close();
            // Destroy UDP client.
            udpClient = null;
            // TODO check if UDP client is correctly deleted.
            // Turn off broadcast flag.
            broadcastEnabled = false;
            // Enable controls.
            buttonDataBroadcastStart.Enabled = true;
        }

        // Occurs when the 'Queue size' text box is no longer active.
        private void TextBoxQueueSize_Leave(object sender, EventArgs e)
        {
            var text = textBoxQueueSize.Text;
            try
            {
                // Parse the content of the text box.
                queue_size = Int32.Parse(text);
            }
            catch (FormatException)
            {
                // Reinitialize the content of the text box.
                text = queue_size.ToString();
                textBoxQueueSize.Text = text;
            }
        }

        // Occurs when the 'Threshold' text box is no longer active.
        private void TextBoxThreshold_Leave(object sender, EventArgs e)
        {
            var text = textBoxThreshold.Text;
            try
            {
                // Parse the content of the text box.
                threshold = Int32.Parse(text);
            }
            catch (FormatException)
            {
                // Reinitialize the content of the text box.
                text = threshold.ToString();
                textBoxThreshold.Text = text;
            }
        }
    }
}
