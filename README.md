# PSX/2 CNF Creator

[![GNU License](http://img.shields.io/:license-gnu-blue.svg)](https://github.com/AxionDrak/PSX2CNFCreator/blob/master/LICENSE)
[![GitHub release](https://img.shields.io/github/v/release/AxionDrak/PSX2CNFCreator)](https://github.com/AxionDrak/PSX2CNFCreator/releases/latest)
[![Downloads release](https://img.shields.io/github/downloads/AxionDrak/PSX2CNFCreator/total)](https://github.com/AxionDrak/PSX2CNFCreator/releases/latest)
[![TOP language](https://img.shields.io/github/languages/top/AxionDrak/PSX2CNFCreator)](https://github.com/AxionDrak/PSX2CNFCreator)
[![CODE size](https://img.shields.io/github/languages/code-size/AxionDrak/PSX2CNFCreator)](https://github.com/AxionDrak/PSX2CNFCreator)
[![REPO size](https://img.shields.io/github/repo-size/AxionDrak/PSX2CNFCreator)](https://github.com/AxionDrak/PSX2CNFCreator/releases)
[![LAST commit](https://img.shields.io/github/last-commit/AxionDrak/PSX2CNFCreator/master)](https://github.com/AxionDrak/PSX2CNFCreator)
[![Build Status](https://travis-ci.org/AxionDrak/PSX2CNFCreator.svg?branch=master)](https://travis-ci.org/AxionDrak/PSX2CNFCreator)
[![Build status](https://ci.appveyor.com/api/projects/status/7wdrpq87gxbb85nb/branch/master?svg=true)](https://ci.appveyor.com/project/laetemn/psx2cnfcreator/branch/master)
[![GitHub contributors](https://img.shields.io/github/contributors/AxionDrak/PSX2CNFCreator)](https://github.com/AxionDrak/PSX2CNFCreator)
[![Coverage Status](https://coveralls.io/repos/github/AxionDrak/PSX2CNFCreator/badge.svg?branch=master)](https://coveralls.io/github/AxionDrak/PSX2CNFCreator?branch=master)

Copyright 2019, Laete Meireles (a.k.a Axion Drak)   
Licenced under GNU Free License version 3.0  
Review LICENSE file for further details.   

**PSX/2 CNF Creator** is a small tool for creating SYSTEM.CNF files compatible with PSOne *(PS1)* and PSTwo *(PS2)* consoles, being mainly used for disk homebrews.

### Attention!!!
----------------
I'm just a self-taught software developer and decided to start learning C#. :)

So please don't mind the badly designed spaghetti code. :P

### Hash
-----------------
Use the table below to ensure that downloaded files have not changed. These values are for the latest stable version in its compiled (final) version.

Version: 1.3.1

| Filename                 | MD5                              | SHA256                                                         
|:-------------------------|:---------------------------------|:---------------------------------------------------------------|
| LICENSE                  | e62637ea8a114355b985fd86c9ffbd6e | 230184f60bae2feaf244f10a8bac053c8ff33a183bcc365b4d8b876d2b7f4809
| PSX2CNFCreator.exe       | dd0c35d018b24e87ec0f718252642e95 | ad125417a59c54f0e37b16e5a154cdf992b975ab9246d904f942fdd9844f49e9 
| README.md                | 845a543111e6fbef46a58bf4b077e5ad | d8edd37c2b09a8fb0d35e895aa5b334fbdb792dedea47c6ec7f1d3f72932127d 
| psxhelp.chm              | a2bff35e32c93ddcf35d5bd8b910b297 | 32395274a35ba473940cee39864ee1d202e724f1a5df313796f19e8899642d5d 
| PSX2CNFCreator_1.3.1.zip | 5231ef77bffce2a693de508f5cab4b54 | 3b1a4243d3bc1c73bef78d4d9e76ab0903269b8be1bf4493dbe647ff80f12b8c 

### Features
------------
* Supports create SYSTEM.CNF files *(PSOne and PSTwo)*
* Supports any ELF file *(PSOne and PSTwo)*
* Supports file and program versioning *(PSTwo)*
* Supports PAL and NTSC video modes *(PSTwo)*
* Supports HDDUNITPOWER in NONE, HDD, NIC and NICHDD modes *(PSTwo)*
* Supports TCB *(PSOne)*
* Supports EVENT *(PSOne)*
* Supports STACK *(PSOne)*
* Supports Dummy file creation *(gargabe)*
* Automatically corrects the file format SYSTEM.CNF
* CLEAR option added as facilitator
* Compatible *(tested)* with the following operating systems: Windows 8/8.1/10

### Language
------------
* At the moment, only Brazilian Portuguese is supported. (sorry :/)

### SYSTEM.CNF
--------------
The structure of the SYSTEM.CNF file is different for PSOne and PSTwo consoles.

Below are examples of this file:

- SYSTEM.CNF *(PSOne)*
```
BOOT = cdrom:\MY_ELF.ELF;1
TCB = 4
EVENT = 16
STACK = 801FFFFC
```

- SYSTEM.CNF *(PSTwo)*
```
BOOT2 = cdrom0:\MY_ELF.ELF;1
VER = 1.0
VMODE = NTSC
HDDUNITPOWER = NICHDD (Optional)
```
- SYSTEM.CNF *OPL Mini Mode (PSTwo)*
```
BOOT2 = pfs:/EXECUTE.KELF
VER = B.99
VMODE = NTSC
HDDUNITPOWER = NICHDD
```

### Report Bugs
---------------
Verify that the bug is reproducible and still occurs in the latest version of SVN/Daily build.

Also check the list of known issues *(below)* to ensure the issue is not yet known.

Include the following information:
* PSX/2 CNF Creator version *(try the latest version of SVN/Daily build)*
* Bug details, including playback instructions
* Operating System *(Windows 8/8.1/10)*
* Attach an image if possible
 
### Known Issues
----------------
* No problem reported. :)

### Changelog
-------------
`v1.4.0`

December 08, 2019
* Added support for OPL Mini (OPL Mini Mode).
  - Available by selecting the PSTwo option.
* Validation system now uses REGEX.
* Improved source code.

`v1.3.1`

December 06, 2019
* Fixed SYSTEM.CNF file creation system for PSOne.
  - You can now choose the directory where the file will be saved.
* Rearranged the appearance of the graphical interface.
* Removed instruction screen previously located in graphical interface.
* Added "Display Help" option in the Help menu.
  - You can now read the program manual through this menu. *(psxhelp.chm)*
* Rewrite source code for improvement and cleanup.

`v1.3.0`

November 18, 2019
* Added support for creating Dummy *(gargabe)* files to fill CD/DVD discs.

`v1.2.0`

November 17, 2019
* Added support for choosing directory to save SYSTEM.CNF file
* Added program information screen
* Added donation option via PayPal ;)

`v1.1.0`

November 16, 2019
* Added full support of SYSTEM.CNF for PSOne
* Stability corrections

`v1.0.0` - Release To Manufacturing (RTM)

November 15, 2019
* Added HDDUNITPOWER support *(PSTwo)*
* Added reset option all settings

`v0.50.0` - RC Version (Release Candidate)

November 14, 2019
* Added full support of SYSTEM.CNF *(PSTwo)*
* Stability corrections

`v0.10.0` - Beta Version

November 10, 2019
* Initial release BETA

### Compile
-----------
See _COMPILE_ file for how to compile and install PSX/2 CNF Creator.

### Documentation
-----------------
See README for PSX/2 CNF Creator information.

### License
-----------
This project is released under the GNU license. If you redistribute the binary
or source code of PSX/2 CNF Creator, please attach file LICENSE with your products.
