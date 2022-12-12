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

If you are using Arduino IDE 1.x, place the Messenger folder inside your Documents\Arduino\libraries folder.  Open the DTMF_Shield sketch.
Use 'upload' to put it onto an Arduino Uno that is plugged in to the computer and recognized.

I've tested this also with Arduino IDE 2.0.  it works, but there wasn't a Documents\Arduino\libraries folder already existing; I had to make it.  But the compile,
and the Upload, also worked as well as with the Arduino IDE 1.x.

I suspect that this project could be modified to easily program the Kenwood TM-732, and possibly TM-733.  It can also be a generic DTMF generating board.
The Arduino is just a serial port that accepts commands that are processed by the DTMF_Shield sketch.  DTMF tones and button presses and such result from this.

Note that it is likely that this code will work on a Mac or on Linux using Visual Studio.  You may have to edit the code related to how Arduino unit
interfacing and identification work. The current code attempts to open SerialPort objects for devices with names like 'COM1' and so on.

I have and use those OS types myself, but help is appreciated!
