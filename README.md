# gst-billing
Utility to generate invoices


Obfuscation of exe is done by following the steps from : http://wittylog.com/how-to-perform-automatic-obfuscation-using-visual-studio-201315

Tools required for obfuscation : ConfuserEx(https://github.com/yck1509/ConfuserEx/releases)
                                 PowerShell Tools for Visual Studio 2013 (Can be downloaded via Extension and Updates in VS2013)

Files needing modification to build on local PC.
1. Confuser.crproj -
   outputDir : Change to bin\Release of your Solution folder.
   baseDir   : Change to bin\Release of your Solution folder.
2. confuserps.ps1 -
   change path for Confuser.CLI.exe according to location of the file in PC
