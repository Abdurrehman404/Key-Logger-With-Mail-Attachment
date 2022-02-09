# Key-Logger-With-Mail-Attachment
Both Programs work collaboratively to achieve stealth and information transfer from Source device to destination Email

This project consist of 2 Programs 
1 ) Program.cs
2 ) Source.cpp

Reason behind using different languages is pureply based on ease. 
With Cpp stealth and getting keystrokes are easy.
Sending mail with C# is an easy task.

FLOW:
Run Program.cs Project it will run keyLogger.exe as a process and it will wait untill termination condition(pressing 1) is not met.
After termination conditon is met, c# code will execute and send mail to the provided mail. There you can decript the code by simply using ceaser cypher decrpytion.

SETUP:
Create Projects and make sure naming is correct, as one program exe is being used by another program. Make sure both exe's file are in the same folder after them copying from project folders, must copy other json dependencies from bin folder for c# project.

