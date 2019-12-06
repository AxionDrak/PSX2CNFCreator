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

**PSX/2 CNF Creator** is a small tool for creating SYSTEM.CNF files compatible with PSOne (PS1) and PSTwo (PS2) consoles, being mainly used for disk homebrews.

### Attention!!!
----------------
I'm just a self-taught software developer and decided to start learning C#. :)

So please don't mind the badly designed spaghetti code. :P

### Hash
-----------------
Use the table below to ensure that downloaded files have not changed. These values are for the latest stable version in its compiled (final) version.

| Filename                    | MD5                                     | SHA256                                   |
| --------------------------- | ----------------------------------------|----------------------------------------- |
| LICENSE                     | e62637ea8a114355b985fd86c9ffbd6e        | 230184f60bae2feaf244f10a8bac053c8ff33a183bcc365b4d8b876d2b7f4809   |
| PSX2CNFCreator.exe          | 90744d245d6fbbb1a3c006b7c785d2e4        | c87ed73812ff767af19d2f8fc53bdd99c68dd491748014e241780d22ae51dbbf   |
| README.md                   | decd4c5a9deac5c961e19989a9608b00        | e3af297778f8bb90b6e85b7271dd2d1ddab3d1e5385e0bca39e8a9058079129e   |

### Features
------------
* Supports create SYSTEM.CNF files (for PSOne and PSTwo)
* Supports any ELF file (PSOne and PSTwo)
* Supports file and program versioning (PSTwo)
* Supports PAL and NTSC (PSTwo) video modes
* Supports HDDUNITPOWER in NONE, HDD, NIC and NICHDD (PSTwo) modes
* Supports TCB (PSOne)
* Supports EVENT (PSOne)
* Supports STACK (PSOne)
* Supports Dummy file creation (gargabe)
* Automatically corrects the file format SYSTEM.CNF
* CLEAR option added as facilitator
* Compatible (tested) with the following operating systems: Windows 8/8.1/10

### Language
------------
* At the moment, only Brazilian Portuguese is supported (sorry :/)

### SYSTEM.CNF
--------------
The structure of the SYSTEM.CNF file is different for PSOne and PSTwo consoles.

Below are two examples of this file:

- SYSTEM.CNF (PSOne)
```
BOOT = cdrom:\MY_ELF.ELF;1
TCB = 4
EVENT = 16
STACK = 801FFFFC
```

- SYSTEM.CNF (PSTwo)
```
BOOT2 = cdrom0:\MY_ELF.ELF;1
VER = 1.0
VMODE = NTSC
HDDUNITPOWER = NICHDD (Optional)
```

### Report Bugs
---------------
Verify that the bug is reproducible and still occurs in the latest version of SVN/Daily build.

Also check the list of known issues (below) to ensure the issue is not yet known.

Include the following information:
* PSX/2 CNF Creator version (try the latest version of SVN/Daily build)
* Bug details, including playback instructions
* Operating System (Windows 8/8.1/10)
* Attach an image if possible
 
### Known Issues
----------------
* No problem reported :)

### Changelog
-------------
v1.3.1
December 06, 2019
* Fixed SYSTEM.CNF file creation system for PSOne.
  - You can now choose the directory where the file will be saved.
* Rearranged the appearance of the graphical interface.
* Removed instruction screen previously located in graphical interface.
* Added "Display Help" option in the Help menu.
  - You can now read the program manual through this menu.

v1.3
November 18, 2019
* Added support for creating Dummy (gargabe) files to fill CD/DVD discs.

v1.2
November 17, 2019
* Added support for choosing directory to save SYSTEM.CNF file
* Added program information screen
* Added donation option via PayPal ;)

v1.1
November 16, 2019
* Added full support of SYSTEM.CNF for PSOne
* Stability corrections

v1.0 - Release To Manufacturing (RTM)
November 15, 2019
* Added HDDUNITPOWER (PSTwo) support
* Added reset option (CLEAR) all settings

v0.50 - RC Version (Release Candidate)
November 14, 2019
* Added full support of SYSTEM.CNF for PSTwo
* Stability corrections

v0.10 - Beta Version
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
