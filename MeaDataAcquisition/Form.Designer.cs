namespace MeaDataAcquisition
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxMeaDevices = new System.Windows.Forms.ComboBox();
            this.buttonDataAcquisitionStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.groupBoxDataAcquisition = new System.Windows.Forms.GroupBox();
            this.textBoxBufferAcquired = new System.Windows.Forms.TextBox();
            this.labelBufferAcquired = new System.Windows.Forms.Label();
            this.labelSampleSize = new System.Windows.Forms.Label();
            this.textBoxSampleSize = new System.Windows.Forms.TextBox();
            this.labelThreshold = new System.Windows.Forms.Label();
            this.textBoxThreshold = new System.Windows.Forms.TextBox();
            this.labelQueueSize = new System.Windows.Forms.Label();
            this.textBoxQueueSize = new System.Windows.Forms.TextBox();
            this.textBoxChannelsInBlock = new System.Windows.Forms.TextBox();
            this.labelChannelsInBlock = new System.Windows.Forms.Label();
            this.textBoxGain = new System.Windows.Forms.TextBox();
            this.labelGain = new System.Windows.Forms.Label();
            this.textBoxSampleRate = new System.Windows.Forms.TextBox();
            this.labelSampleRate = new System.Windows.Forms.Label();
            this.textBoxNumberOfChannels = new System.Windows.Forms.TextBox();
            this.labelNumberOfChannels = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDataBackup = new System.Windows.Forms.GroupBox();
            this.labelBufferBackuped = new System.Windows.Forms.Label();
            this.textBoxBufferBackuped = new System.Windows.Forms.TextBox();
            this.buttonDataBackupStop = new System.Windows.Forms.Button();
            this.buttonDataBackupStart = new System.Windows.Forms.Button();
            this.buttonDataBackupBrowse = new System.Windows.Forms.Button();
            this.textBoxDataBackupPath = new System.Windows.Forms.TextBox();
            this.labelDataBackupPath = new System.Windows.Forms.Label();
            this.groupBoxDataBroadcast = new System.Windows.Forms.GroupBox();
            this.labelBufferBroadcasted = new System.Windows.Forms.Label();
            this.textBoxBufferBroadcasted = new System.Windows.Forms.TextBox();
            this.buttonDataBroadcastStop = new System.Windows.Forms.Button();
            this.buttonDataBroadcastStart = new System.Windows.Forms.Button();
            this.textBoxDataBroadcastPort = new System.Windows.Forms.TextBox();
            this.labelDataBroadcastPort = new System.Windows.Forms.Label();
            this.textBoxDataBroadcastHostname = new System.Windows.Forms.TextBox();
            this.labelDataBroadcastHostname = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.checkBoxLockBackupBroadcast = new System.Windows.Forms.CheckBox();
            this.groupBoxDataAcquisition.SuspendLayout();
            this.groupBoxDataBackup.SuspendLayout();
            this.groupBoxDataBroadcast.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxMeaDevices
            // 
            this.comboBoxMeaDevices.FormattingEnabled = true;
            this.comboBoxMeaDevices.Location = new System.Drawing.Point(53, 19);
            this.comboBoxMeaDevices.Name = "comboBoxMeaDevices";
            this.comboBoxMeaDevices.Size = new System.Drawing.Size(150, 21);
            this.comboBoxMeaDevices.TabIndex = 1;
            this.comboBoxMeaDevices.Text = "Select device";
            this.comboBoxMeaDevices.DropDown += new System.EventHandler(this.ComboBoxMeaDevices_DropDown);
            this.comboBoxMeaDevices.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMeaDevices_SelectedIndexChanged);
            // 
            // buttonDataAcquisitionStart
            // 
            this.buttonDataAcquisitionStart.Enabled = false;
            this.buttonDataAcquisitionStart.Location = new System.Drawing.Point(6, 230);
            this.buttonDataAcquisitionStart.Name = "buttonDataAcquisitionStart";
            this.buttonDataAcquisitionStart.Size = new System.Drawing.Size(97, 53);
            this.buttonDataAcquisitionStart.TabIndex = 2;
            this.buttonDataAcquisitionStart.Text = "Start";
            this.buttonDataAcquisitionStart.UseVisualStyleBackColor = true;
            this.buttonDataAcquisitionStart.Click += new System.EventHandler(this.ButtonDataAcquisitionStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(109, 230);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(97, 53);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.ButtonDataAcquisitionStop_Click);
            // 
            // groupBoxDataAcquisition
            // 
            this.groupBoxDataAcquisition.Controls.Add(this.textBoxBufferAcquired);
            this.groupBoxDataAcquisition.Controls.Add(this.labelBufferAcquired);
            this.groupBoxDataAcquisition.Controls.Add(this.labelSampleSize);
            this.groupBoxDataAcquisition.Controls.Add(this.textBoxSampleSize);
            this.groupBoxDataAcquisition.Controls.Add(this.labelThreshold);
            this.groupBoxDataAcquisition.Controls.Add(this.textBoxThreshold);
            this.groupBoxDataAcquisition.Controls.Add(this.labelQueueSize);
            this.groupBoxDataAcquisition.Controls.Add(this.textBoxQueueSize);
            this.groupBoxDataAcquisition.Controls.Add(this.textBoxChannelsInBlock);
            this.groupBoxDataAcquisition.Controls.Add(this.labelChannelsInBlock);
            this.groupBoxDataAcquisition.Controls.Add(this.textBoxGain);
            this.groupBoxDataAcquisition.Controls.Add(this.labelGain);
            this.groupBoxDataAcquisition.Controls.Add(this.textBoxSampleRate);
            this.groupBoxDataAcquisition.Controls.Add(this.labelSampleRate);
            this.groupBoxDataAcquisition.Controls.Add(this.textBoxNumberOfChannels);
            this.groupBoxDataAcquisition.Controls.Add(this.labelNumberOfChannels);
            this.groupBoxDataAcquisition.Controls.Add(this.label1);
            this.groupBoxDataAcquisition.Controls.Add(this.comboBoxMeaDevices);
            this.groupBoxDataAcquisition.Controls.Add(this.buttonDataAcquisitionStart);
            this.groupBoxDataAcquisition.Controls.Add(this.buttonStop);
            this.groupBoxDataAcquisition.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDataAcquisition.Name = "groupBoxDataAcquisition";
            this.groupBoxDataAcquisition.Size = new System.Drawing.Size(212, 318);
            this.groupBoxDataAcquisition.TabIndex = 4;
            this.groupBoxDataAcquisition.TabStop = false;
            this.groupBoxDataAcquisition.Text = "1. Data Acquisition";
            // 
            // textBoxBufferAcquired
            // 
            this.textBoxBufferAcquired.Enabled = false;
            this.textBoxBufferAcquired.Location = new System.Drawing.Point(116, 289);
            this.textBoxBufferAcquired.Name = "textBoxBufferAcquired";
            this.textBoxBufferAcquired.ReadOnly = true;
            this.textBoxBufferAcquired.Size = new System.Drawing.Size(87, 20);
            this.textBoxBufferAcquired.TabIndex = 19;
            // 
            // labelBufferAcquired
            // 
            this.labelBufferAcquired.AutoSize = true;
            this.labelBufferAcquired.Enabled = false;
            this.labelBufferAcquired.Location = new System.Drawing.Point(8, 292);
            this.labelBufferAcquired.Name = "labelBufferAcquired";
            this.labelBufferAcquired.Size = new System.Drawing.Size(79, 13);
            this.labelBufferAcquired.TabIndex = 18;
            this.labelBufferAcquired.Text = "Buffer acquired";
            // 
            // labelSampleSize
            // 
            this.labelSampleSize.AutoSize = true;
            this.labelSampleSize.Enabled = false;
            this.labelSampleSize.Location = new System.Drawing.Point(8, 207);
            this.labelSampleSize.Name = "labelSampleSize";
            this.labelSampleSize.Size = new System.Drawing.Size(63, 13);
            this.labelSampleSize.TabIndex = 17;
            this.labelSampleSize.Text = "Sample size";
            // 
            // textBoxSampleSize
            // 
            this.textBoxSampleSize.Enabled = false;
            this.textBoxSampleSize.Location = new System.Drawing.Point(116, 204);
            this.textBoxSampleSize.Name = "textBoxSampleSize";
            this.textBoxSampleSize.ReadOnly = true;
            this.textBoxSampleSize.Size = new System.Drawing.Size(87, 20);
            this.textBoxSampleSize.TabIndex = 16;
            // 
            // labelThreshold
            // 
            this.labelThreshold.AutoSize = true;
            this.labelThreshold.Enabled = false;
            this.labelThreshold.Location = new System.Drawing.Point(8, 181);
            this.labelThreshold.Name = "labelThreshold";
            this.labelThreshold.Size = new System.Drawing.Size(54, 13);
            this.labelThreshold.TabIndex = 15;
            this.labelThreshold.Text = "Threshold";
            // 
            // textBoxThreshold
            // 
            this.textBoxThreshold.Enabled = false;
            this.textBoxThreshold.Location = new System.Drawing.Point(116, 178);
            this.textBoxThreshold.Name = "textBoxThreshold";
            this.textBoxThreshold.Size = new System.Drawing.Size(87, 20);
            this.textBoxThreshold.TabIndex = 14;
            this.textBoxThreshold.Leave += new System.EventHandler(this.TextBoxThreshold_Leave);
            // 
            // labelQueueSize
            // 
            this.labelQueueSize.AutoSize = true;
            this.labelQueueSize.Enabled = false;
            this.labelQueueSize.Location = new System.Drawing.Point(8, 155);
            this.labelQueueSize.Name = "labelQueueSize";
            this.labelQueueSize.Size = new System.Drawing.Size(60, 13);
            this.labelQueueSize.TabIndex = 13;
            this.labelQueueSize.Text = "Queue size";
            // 
            // textBoxQueueSize
            // 
            this.textBoxQueueSize.Enabled = false;
            this.textBoxQueueSize.Location = new System.Drawing.Point(116, 152);
            this.textBoxQueueSize.Name = "textBoxQueueSize";
            this.textBoxQueueSize.Size = new System.Drawing.Size(87, 20);
            this.textBoxQueueSize.TabIndex = 12;
            this.textBoxQueueSize.Leave += new System.EventHandler(this.TextBoxQueueSize_Leave);
            // 
            // textBoxChannelsInBlock
            // 
            this.textBoxChannelsInBlock.Enabled = false;
            this.textBoxChannelsInBlock.Location = new System.Drawing.Point(116, 126);
            this.textBoxChannelsInBlock.Name = "textBoxChannelsInBlock";
            this.textBoxChannelsInBlock.ReadOnly = true;
            this.textBoxChannelsInBlock.Size = new System.Drawing.Size(87, 20);
            this.textBoxChannelsInBlock.TabIndex = 11;
            // 
            // labelChannelsInBlock
            // 
            this.labelChannelsInBlock.AutoSize = true;
            this.labelChannelsInBlock.Enabled = false;
            this.labelChannelsInBlock.Location = new System.Drawing.Point(8, 129);
            this.labelChannelsInBlock.Name = "labelChannelsInBlock";
            this.labelChannelsInBlock.Size = new System.Drawing.Size(91, 13);
            this.labelChannelsInBlock.TabIndex = 10;
            this.labelChannelsInBlock.Text = "Channels in block";
            // 
            // textBoxGain
            // 
            this.textBoxGain.Enabled = false;
            this.textBoxGain.Location = new System.Drawing.Point(116, 100);
            this.textBoxGain.Name = "textBoxGain";
            this.textBoxGain.ReadOnly = true;
            this.textBoxGain.Size = new System.Drawing.Size(87, 20);
            this.textBoxGain.TabIndex = 9;
            // 
            // labelGain
            // 
            this.labelGain.AutoSize = true;
            this.labelGain.Enabled = false;
            this.labelGain.Location = new System.Drawing.Point(8, 103);
            this.labelGain.Name = "labelGain";
            this.labelGain.Size = new System.Drawing.Size(29, 13);
            this.labelGain.TabIndex = 8;
            this.labelGain.Text = "Gain";
            // 
            // textBoxSampleRate
            // 
            this.textBoxSampleRate.Enabled = false;
            this.textBoxSampleRate.Location = new System.Drawing.Point(116, 74);
            this.textBoxSampleRate.Name = "textBoxSampleRate";
            this.textBoxSampleRate.ReadOnly = true;
            this.textBoxSampleRate.Size = new System.Drawing.Size(87, 20);
            this.textBoxSampleRate.TabIndex = 7;
            // 
            // labelSampleRate
            // 
            this.labelSampleRate.AutoSize = true;
            this.labelSampleRate.Enabled = false;
            this.labelSampleRate.Location = new System.Drawing.Point(8, 77);
            this.labelSampleRate.Name = "labelSampleRate";
            this.labelSampleRate.Size = new System.Drawing.Size(63, 13);
            this.labelSampleRate.TabIndex = 6;
            this.labelSampleRate.Text = "Sample rate";
            // 
            // textBoxNumberOfChannels
            // 
            this.textBoxNumberOfChannels.Enabled = false;
            this.textBoxNumberOfChannels.Location = new System.Drawing.Point(116, 48);
            this.textBoxNumberOfChannels.Name = "textBoxNumberOfChannels";
            this.textBoxNumberOfChannels.ReadOnly = true;
            this.textBoxNumberOfChannels.Size = new System.Drawing.Size(87, 20);
            this.textBoxNumberOfChannels.TabIndex = 5;
            // 
            // labelNumberOfChannels
            // 
            this.labelNumberOfChannels.AutoSize = true;
            this.labelNumberOfChannels.Enabled = false;
            this.labelNumberOfChannels.Location = new System.Drawing.Point(8, 51);
            this.labelNumberOfChannels.Name = "labelNumberOfChannels";
            this.labelNumberOfChannels.Size = new System.Drawing.Size(102, 13);
            this.labelNumberOfChannels.TabIndex = 4;
            this.labelNumberOfChannels.Text = "Number of channels";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "MEA";
            // 
            // groupBoxDataBackup
            // 
            this.groupBoxDataBackup.Controls.Add(this.labelBufferBackuped);
            this.groupBoxDataBackup.Controls.Add(this.textBoxBufferBackuped);
            this.groupBoxDataBackup.Controls.Add(this.buttonDataBackupStop);
            this.groupBoxDataBackup.Controls.Add(this.buttonDataBackupStart);
            this.groupBoxDataBackup.Controls.Add(this.buttonDataBackupBrowse);
            this.groupBoxDataBackup.Controls.Add(this.textBoxDataBackupPath);
            this.groupBoxDataBackup.Controls.Add(this.labelDataBackupPath);
            this.groupBoxDataBackup.Enabled = false;
            this.groupBoxDataBackup.Location = new System.Drawing.Point(12, 334);
            this.groupBoxDataBackup.Name = "groupBoxDataBackup";
            this.groupBoxDataBackup.Size = new System.Drawing.Size(212, 125);
            this.groupBoxDataBackup.TabIndex = 5;
            this.groupBoxDataBackup.TabStop = false;
            this.groupBoxDataBackup.Text = "2. Data Backup";
            // 
            // labelBufferBackuped
            // 
            this.labelBufferBackuped.AutoSize = true;
            this.labelBufferBackuped.Enabled = false;
            this.labelBufferBackuped.Location = new System.Drawing.Point(8, 101);
            this.labelBufferBackuped.Name = "labelBufferBackuped";
            this.labelBufferBackuped.Size = new System.Drawing.Size(86, 13);
            this.labelBufferBackuped.TabIndex = 20;
            this.labelBufferBackuped.Text = "Buffer backuped";
            // 
            // textBoxBufferBackuped
            // 
            this.textBoxBufferBackuped.Enabled = false;
            this.textBoxBufferBackuped.Location = new System.Drawing.Point(116, 98);
            this.textBoxBufferBackuped.Name = "textBoxBufferBackuped";
            this.textBoxBufferBackuped.ReadOnly = true;
            this.textBoxBufferBackuped.Size = new System.Drawing.Size(87, 20);
            this.textBoxBufferBackuped.TabIndex = 20;
            // 
            // buttonDataBackupStop
            // 
            this.buttonDataBackupStop.Enabled = false;
            this.buttonDataBackupStop.Location = new System.Drawing.Point(109, 39);
            this.buttonDataBackupStop.Name = "buttonDataBackupStop";
            this.buttonDataBackupStop.Size = new System.Drawing.Size(97, 53);
            this.buttonDataBackupStop.TabIndex = 18;
            this.buttonDataBackupStop.Text = "Stop";
            this.buttonDataBackupStop.UseVisualStyleBackColor = true;
            this.buttonDataBackupStop.Click += new System.EventHandler(this.ButtonDataBackupStop_Click);
            // 
            // buttonDataBackupStart
            // 
            this.buttonDataBackupStart.Location = new System.Drawing.Point(6, 39);
            this.buttonDataBackupStart.Name = "buttonDataBackupStart";
            this.buttonDataBackupStart.Size = new System.Drawing.Size(97, 53);
            this.buttonDataBackupStart.TabIndex = 18;
            this.buttonDataBackupStart.Text = "Start";
            this.buttonDataBackupStart.UseVisualStyleBackColor = true;
            this.buttonDataBackupStart.Click += new System.EventHandler(this.ButtonDataBackupStart_Click);
            // 
            // buttonDataBackupBrowse
            // 
            this.buttonDataBackupBrowse.Location = new System.Drawing.Point(136, 13);
            this.buttonDataBackupBrowse.Name = "buttonDataBackupBrowse";
            this.buttonDataBackupBrowse.Size = new System.Drawing.Size(67, 20);
            this.buttonDataBackupBrowse.TabIndex = 2;
            this.buttonDataBackupBrowse.Text = "Browse";
            this.buttonDataBackupBrowse.UseVisualStyleBackColor = true;
            this.buttonDataBackupBrowse.Click += new System.EventHandler(this.ButtonDataBackupBrowse_Click);
            // 
            // textBoxDataBackupPath
            // 
            this.textBoxDataBackupPath.Enabled = false;
            this.textBoxDataBackupPath.Location = new System.Drawing.Point(44, 13);
            this.textBoxDataBackupPath.Name = "textBoxDataBackupPath";
            this.textBoxDataBackupPath.Size = new System.Drawing.Size(86, 20);
            this.textBoxDataBackupPath.TabIndex = 1;
            this.textBoxDataBackupPath.TextChanged += new System.EventHandler(this.TextBoxDataBackupPath_TextChanged);
            // 
            // labelDataBackupPath
            // 
            this.labelDataBackupPath.AutoSize = true;
            this.labelDataBackupPath.Enabled = false;
            this.labelDataBackupPath.Location = new System.Drawing.Point(6, 16);
            this.labelDataBackupPath.Name = "labelDataBackupPath";
            this.labelDataBackupPath.Size = new System.Drawing.Size(29, 13);
            this.labelDataBackupPath.TabIndex = 0;
            this.labelDataBackupPath.Text = "Path";
            // 
            // groupBoxDataBroadcast
            // 
            this.groupBoxDataBroadcast.Controls.Add(this.labelBufferBroadcasted);
            this.groupBoxDataBroadcast.Controls.Add(this.textBoxBufferBroadcasted);
            this.groupBoxDataBroadcast.Controls.Add(this.buttonDataBroadcastStop);
            this.groupBoxDataBroadcast.Controls.Add(this.buttonDataBroadcastStart);
            this.groupBoxDataBroadcast.Controls.Add(this.textBoxDataBroadcastPort);
            this.groupBoxDataBroadcast.Controls.Add(this.labelDataBroadcastPort);
            this.groupBoxDataBroadcast.Controls.Add(this.textBoxDataBroadcastHostname);
            this.groupBoxDataBroadcast.Controls.Add(this.labelDataBroadcastHostname);
            this.groupBoxDataBroadcast.Enabled = false;
            this.groupBoxDataBroadcast.Location = new System.Drawing.Point(12, 463);
            this.groupBoxDataBroadcast.Name = "groupBoxDataBroadcast";
            this.groupBoxDataBroadcast.Size = new System.Drawing.Size(212, 150);
            this.groupBoxDataBroadcast.TabIndex = 6;
            this.groupBoxDataBroadcast.TabStop = false;
            this.groupBoxDataBroadcast.Text = "3. Data Broadcast";
            // 
            // labelBufferBroadcasted
            // 
            this.labelBufferBroadcasted.AutoSize = true;
            this.labelBufferBroadcasted.Enabled = false;
            this.labelBufferBroadcasted.Location = new System.Drawing.Point(8, 127);
            this.labelBufferBroadcasted.Name = "labelBufferBroadcasted";
            this.labelBufferBroadcasted.Size = new System.Drawing.Size(97, 13);
            this.labelBufferBroadcasted.TabIndex = 21;
            this.labelBufferBroadcasted.Text = "Buffer broadcasted";
            // 
            // textBoxBufferBroadcasted
            // 
            this.textBoxBufferBroadcasted.Enabled = false;
            this.textBoxBufferBroadcasted.Location = new System.Drawing.Point(119, 124);
            this.textBoxBufferBroadcasted.Name = "textBoxBufferBroadcasted";
            this.textBoxBufferBroadcasted.ReadOnly = true;
            this.textBoxBufferBroadcasted.Size = new System.Drawing.Size(87, 20);
            this.textBoxBufferBroadcasted.TabIndex = 21;
            // 
            // buttonDataBroadcastStop
            // 
            this.buttonDataBroadcastStop.Enabled = false;
            this.buttonDataBroadcastStop.Location = new System.Drawing.Point(109, 65);
            this.buttonDataBroadcastStop.Name = "buttonDataBroadcastStop";
            this.buttonDataBroadcastStop.Size = new System.Drawing.Size(97, 53);
            this.buttonDataBroadcastStop.TabIndex = 19;
            this.buttonDataBroadcastStop.Text = "Stop";
            this.buttonDataBroadcastStop.UseVisualStyleBackColor = true;
            this.buttonDataBroadcastStop.Click += new System.EventHandler(this.ButtonDataBroadcastStop_Click);
            // 
            // buttonDataBroadcastStart
            // 
            this.buttonDataBroadcastStart.Location = new System.Drawing.Point(6, 65);
            this.buttonDataBroadcastStart.Name = "buttonDataBroadcastStart";
            this.buttonDataBroadcastStart.Size = new System.Drawing.Size(97, 53);
            this.buttonDataBroadcastStart.TabIndex = 19;
            this.buttonDataBroadcastStart.Text = "Start";
            this.buttonDataBroadcastStart.UseVisualStyleBackColor = true;
            this.buttonDataBroadcastStart.Click += new System.EventHandler(this.ButtonDataBroadcastStart_Click);
            // 
            // textBoxDataBroadcastPort
            // 
            this.textBoxDataBroadcastPort.Enabled = false;
            this.textBoxDataBroadcastPort.Location = new System.Drawing.Point(67, 39);
            this.textBoxDataBroadcastPort.Name = "textBoxDataBroadcastPort";
            this.textBoxDataBroadcastPort.Size = new System.Drawing.Size(136, 20);
            this.textBoxDataBroadcastPort.TabIndex = 3;
            // 
            // labelDataBroadcastPort
            // 
            this.labelDataBroadcastPort.AutoSize = true;
            this.labelDataBroadcastPort.Enabled = false;
            this.labelDataBroadcastPort.Location = new System.Drawing.Point(6, 46);
            this.labelDataBroadcastPort.Name = "labelDataBroadcastPort";
            this.labelDataBroadcastPort.Size = new System.Drawing.Size(26, 13);
            this.labelDataBroadcastPort.TabIndex = 2;
            this.labelDataBroadcastPort.Text = "Port";
            // 
            // textBoxDataBroadcastHostname
            // 
            this.textBoxDataBroadcastHostname.Enabled = false;
            this.textBoxDataBroadcastHostname.Location = new System.Drawing.Point(67, 13);
            this.textBoxDataBroadcastHostname.Name = "textBoxDataBroadcastHostname";
            this.textBoxDataBroadcastHostname.Size = new System.Drawing.Size(136, 20);
            this.textBoxDataBroadcastHostname.TabIndex = 1;
            // 
            // labelDataBroadcastHostname
            // 
            this.labelDataBroadcastHostname.AutoSize = true;
            this.labelDataBroadcastHostname.Enabled = false;
            this.labelDataBroadcastHostname.Location = new System.Drawing.Point(6, 16);
            this.labelDataBroadcastHostname.Name = "labelDataBroadcastHostname";
            this.labelDataBroadcastHostname.Size = new System.Drawing.Size(55, 13);
            this.labelDataBroadcastHostname.TabIndex = 0;
            this.labelDataBroadcastHostname.Text = "Hostname";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(591, 12);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(405, 705);
            this.textBoxLog.TabIndex = 7;
            // 
            // checkBoxLockBackupBroadcast
            // 
            this.checkBoxLockBackupBroadcast.AutoSize = true;
            this.checkBoxLockBackupBroadcast.Location = new System.Drawing.Point(18, 619);
            this.checkBoxLockBackupBroadcast.Name = "checkBoxLockBackupBroadcast";
            this.checkBoxLockBackupBroadcast.Size = new System.Drawing.Size(156, 17);
            this.checkBoxLockBackupBroadcast.TabIndex = 8;
            this.checkBoxLockBackupBroadcast.Text = "lock backup and broadcast";
            this.checkBoxLockBackupBroadcast.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.checkBoxLockBackupBroadcast);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.groupBoxDataBroadcast);
            this.Controls.Add(this.groupBoxDataBackup);
            this.Controls.Add(this.groupBoxDataAcquisition);
            this.Name = "Form";
            this.Text = "MEA Data Acquisition";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBoxDataAcquisition.ResumeLayout(false);
            this.groupBoxDataAcquisition.PerformLayout();
            this.groupBoxDataBackup.ResumeLayout(false);
            this.groupBoxDataBackup.PerformLayout();
            this.groupBoxDataBroadcast.ResumeLayout(false);
            this.groupBoxDataBroadcast.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxMeaDevices;
        private System.Windows.Forms.Button buttonDataAcquisitionStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.GroupBox groupBoxDataAcquisition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDataBackup;
        private System.Windows.Forms.GroupBox groupBoxDataBroadcast;
        private System.Windows.Forms.Button buttonDataBackupBrowse;
        private System.Windows.Forms.TextBox textBoxDataBackupPath;
        private System.Windows.Forms.Label labelDataBackupPath;
        private System.Windows.Forms.TextBox textBoxDataBroadcastPort;
        private System.Windows.Forms.Label labelDataBroadcastPort;
        private System.Windows.Forms.TextBox textBoxDataBroadcastHostname;
        private System.Windows.Forms.Label labelDataBroadcastHostname;
        private System.Windows.Forms.TextBox textBoxNumberOfChannels;
        private System.Windows.Forms.Label labelNumberOfChannels;
        private System.Windows.Forms.TextBox textBoxSampleRate;
        private System.Windows.Forms.Label labelSampleRate;
        private System.Windows.Forms.Label labelGain;
        private System.Windows.Forms.TextBox textBoxGain;
        private System.Windows.Forms.TextBox textBoxChannelsInBlock;
        private System.Windows.Forms.Label labelChannelsInBlock;
        private System.Windows.Forms.Label labelQueueSize;
        private System.Windows.Forms.TextBox textBoxQueueSize;
        private System.Windows.Forms.Label labelThreshold;
        private System.Windows.Forms.TextBox textBoxThreshold;
        private System.Windows.Forms.Label labelSampleSize;
        private System.Windows.Forms.TextBox textBoxSampleSize;
        private System.Windows.Forms.Button buttonDataBackupStop;
        private System.Windows.Forms.Button buttonDataBackupStart;
        private System.Windows.Forms.Button buttonDataBroadcastStop;
        private System.Windows.Forms.Button buttonDataBroadcastStart;
        private System.Windows.Forms.TextBox textBoxBufferAcquired;
        private System.Windows.Forms.Label labelBufferAcquired;
        private System.Windows.Forms.Label labelBufferBackuped;
        private System.Windows.Forms.TextBox textBoxBufferBackuped;
        private System.Windows.Forms.Label labelBufferBroadcasted;
        private System.Windows.Forms.TextBox textBoxBufferBroadcasted;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.CheckBox checkBoxLockBackupBroadcast;
    }
}

