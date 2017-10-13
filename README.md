Data acquisition application for the USB-MEA256-System by Multi Channel Systems GmbH.

### Installation

 1. Change your current directory (e.g. `C:\Users\<username>\Programs`)  
    `cd C:\\Users\\<username>\\Programs`
 2. Clone this repository with the following command  
    `git clone https://github.com/balefebvre/MeaDataAcquisition.git`
 3. In the `MeaDataAcquisition` directory, open `MeaDataAcquisition.sln` with [Microsoft Visual Studio Community 2017](https://www.visualstudio.com/fr/vs/community/)
 4. Generate the solution (i.e. click on `Generate` > `Generate the solution`) with the following options  
    Configuration: Release  
	Platform: x86
 5. Create a link to the `MeaDataAcquisition.exe` generated in `MeaDataAcquisition\MeaDataAcquisition\bin\x86\Release` in a more accessible location

### TODO

- [x] Clean GUI.
- [x] Trigger backup and broadcast when a TCP connection is accepted.
- [x] Check if the broadcast buffer can get full and find why.
- [ ] Handle exception System.IO.IOException thrown when the client execute a keyboard interruption 
- [ ] Handle exceptions.
- [ ] Send analog data only (discard digital, checksum and timestamp channels).
- [ ] Load balancing (backup background worker v.s. broadcast background worker).
