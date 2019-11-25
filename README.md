# PSX/2 CNF Creator

[![Build Status](https://travis-ci.org/AxionDrak/PSX2CNFCreator.svg?branch=master)](https://travis-ci.org/AxionDrak/PSX2CNFCreator)

[![Build status](https://ci.appveyor.com/api/projects/status/a4wvbn89wu3pinas/branch/master?svg=true)](https://ci.appveyor.com/project/laetemn/psx2cnfcreator/branch/master)

**PSX/2 CNF Creator** is a small tool for creating SYSTEM.CNF files compatible with PSOne (PS1) and PSTwo (PS2) consoles, being mainly used for disk homebrews.

### Attention!!!
----------------
This software is experimental!

I'm just a self-taught software developer and decided to start learning C #. :)

So please don't mind the badly designed spaghetti code. :P

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
* Compatible (tested) with the following operating systems: Windows 8 / 8.1 / 10

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
Verify that the bug is reproducible and still occurs in the latest version of SVN / Daily build.

Also check the list of known issues (below) to ensure the issue is not yet known:

Include the following information:
* PSX / 2 CNF Creator version (try the latest version of SVN / Daily build)
* Bug details, including playback instructions
* Operating System (Windows 8 / 8.1 / 10)
* Attach an image if possible
 
### Known Issues
----------------
* No problem reported :)

### Changelog
-------------
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
See COMPILE.TXT file for how to compile and install Capstone.

### Documentation
-----------------
See README for PSX/2 CNF Creator information.

### License
-----------

This project is released under the GNU license. If you redistribute the binary
or source code of PSX/2 CNF Creator, please attach file LICENSE.TXT with your products.
