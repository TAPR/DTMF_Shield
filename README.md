# DTMF_Shield
The Arduino DTMF Shield and software to program a Kenwood TM-742 series radio

This code and designs all came from Larry Anderton, WA7YLI.  It is released with his expressed permission.

Many thanks to Curt Mills, WE7U, 'the Xastir Guy', who loaned me his functional TM742 Programmer unit, so that I could test my built boards initially,
and to know correct from incorrect, or unexpected, behavior.

License is listed as MIT, but other open source licenses are also acceptable, especially BSD, Mozilla, or GNU 2.0.

Hardware designs are licensed under the TAPR Open Hardware License
 
This consists of:
1) an Arduino Sketch called DTMF_Shield, which runs on an Arduino Uno.  I've recently tested an Uno R3, and it worked.
2) an Arduino shield, called 'DTMF_Shield', that generates DTMF tones and otherwise emulates a Kenwood MC-45DM microphone or equivalent
3) a Visual Studio VB.Net application that, using a DTMF Shield on an Arduino, will program a Kenwood TM-742 series radio
  the two zip files are the original installer and the original Visual Studio source code.  It was called 'UsbTest' then.

Folder DTMF_Shield: contains the Arduino 2.x sketch, DTMF_Shield.ino.

Folder libraries: contains libraries no longer available via the Arduino IDE that are used by DTMF_Shield.  This has the subfolder Messenger, containing
the deprecated library's code.

File "TM742 Programmer - Rev 1 candidate Jul1 1, 2014.zip" is the original installer as provided by WA7YLI.  This is also what the 'initial release' gives you.
https://github.com/TAPR/DTMF_Shield/blob/main/TM742%20Programmer%20-%20Rev%201%20candidate%20Jul1%201%2C%202014.zip

File "TM742ApplicationSln.zip" is the original source code from WA7YLI.
https://github.com/TAPR/DTMF_Shield/blob/main/TM742ApplicationSln.zip

File "Instructions - readme - updated for Rev 1 Sept13_2015.pdf" original instructions from Larry.
https://github.com/TAPR/DTMF_Shield/blob/main/Instructions%20-%20readme%20-%20updated%20for%20Rev%201%20Sept13_2015.pdf

File "TM742 Programming Kit Pictures.docx" - shows the shield board and how to put it on an Arduino.  Note that no power cable is needed by the Arduino in most all
applications, unless your PC is unable to power the Arduino via the USB cable that you use.
https://github.com/TAPR/DTMF_Shield/blob/main/TM742%20Programming%20Kit%20Pictures.docx

Using (currently) the Arduino IDE 2.x, place the libraries/Messenger folder inside your Documents\Arduino\libraries folder.  Place the entire the DTMF_Shield subfolder
into your Documents\Arduino folder, creating the DTMF_Shield subfolder, containing DTMF_Shield.ino.  Open DTMF_Shield.ino in your Arduino IDE.
Use 'upload' to put it onto an Arduino Uno that is plugged in to the computer and recognized and selected.

To make it easier to just use the Arduino Sketch, there is a zip file in the main folder, DTMF_Shield_Sketch.zip, that you should download.  It contains a folder DTMF_Shield,
containing DTMF_Shield.ino (for IDE 2.x and above), and the folder libraries, containing the subfolder Messenger, containing the code for a no-longer available Arduino library
that is used by the sketch.  If you place the contents of the zip file, those two folders, DTMF_Shield and libraries, in your Arduino sketch folder (often your Documents/Arduino folder)
you will have everything you need to upload the sketch onto an Arduino Uno of your own, or to replace the code on your Uno, or one that has somehow lost its program (note: a firmware update
will often cause loss of the sketch that was on the Uno previously.)  Using the Arudino IDE, open the DTMF_Shield.ino file (the sketch file) in the DTMF_Shield folder.  Voila!  Use 'Upload'
under 'Sketch' to put the sketch onto your Uno.

Mac and Linux do NOT want to do Windows Forms applications (which is what the programmer app is...) any more. I think that maybe 10 years ago we could create
the app on windows, and run it under Mono.  However, the Mac and Linux seem to use only .Net Core, which does not include support for Windows Forms apps.  It no longer
works that way.  So, it does't run on Mac or Linux.  Volunteers are welcome to undertake those ports.

What the DTMF_Shield sketch does:
1) it processes a set of serial command strings.  Some are single character, some are multiple character.  These commands/actions are described below.
2) to operate the shield itself, either a command setting a value is sent, a button press is emulated, or a 5 bit command is sent to the DTMF generator chip (HT9200A)
  to generate a tone for 0-9 or A-D.	The chip is enabled, the 5 bits are banged out, and the chip is disabled.  There are appropriate pauses.
	
	a) setting values: accepts "SET_TONE_TIME:" followed by an integer value, or "SET_BUTTON_TIME:" followed by an integer value, "PAUSE: ", which causes a
		pause for TONE_DELAY time (SET_TONE_TIME value) Default values for both are '75'.  All values are in milliseconds
		
	b) receiving the string "0" thru "9" and "A" thru "D" cause that DTMF tone to be generated by the HT9200A chip, for the current TONE_DELAY time.
	
	c) receiving the string "UP" causes the UP button press line to be set for BUTTON_DELAY time (SET_BUTTON_TIME value), then cleared.
    		Similar for "DOWN", "MR", "VFO", "PF", and "CALL"
	
Long and short presses are performed by having the TM742 programmer application change the TONE_TIME and BUTTON_TIME appropriately, then returning to the normal value.
I have now implemented additional commands "SET_LONG_PRESS_TIME:" (followed by milliseconds, default is 1.2 seconds or 1200 milliseconds.) and "LONG_MR".
"LONG_MR" is used when programming a custom repeater offset (whole MHz only, +/- 60 MHz), also known as an 'odd split' or non-standard split/offset.

--->>> TRY THE NEW BRANCH! https://github.com/TAPR/DTMF_Shield/tree/main/TM742ApplicationCSharpNew 
This is a very much refactored branch.  It has 'custom/odd/nonstandard' repeater split/offset frequency in whole MHz.  There is a new beta release for its installer.

