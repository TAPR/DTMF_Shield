# DTMF_Shield
The Arduino DTMF Shield and software to program a Kenwood TM-742 series radio

This consists of:
1) an Arduino Sketch called DTMF_Shield, which runs on an Arduino Uno.  I've recently tested and Uno R3, and it worked.
2) an Arduino shield, called 'DTMF_Shield', that generates DTMF tones and otherwise emulates a Kenwood MC-45DM microphone or equivalent
3) a Visual Studio VB.Net application that, using a DTMF Shield on an Arduino, will program a Kenwood TM-742 series radio

If you are using Arduino IDE 1.x, place the Messenger folder inside your Documents\Arduino\libraries folder.  Open the DTMF_Shield sketch.
Use 'upload' to put it onto an Arduino Uno that is plugged in to the computer and recognized.

I've tested this also with Arduino IDE 2.0.  it works, but there wasn't a Documents\Arduino\libraries folder already existing; I had to make it.  But the compile,
and the Upload, also worked as well as with the Arduino IDE 1.x.
