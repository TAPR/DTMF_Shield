 #include <Messenger.h>
 
  Messenger message = Messenger(); 
  
  const int CLK_PIN    = 10;
  const int DATA_PIN   = 9;
  const int ENABLE_PIN = 13;
  //
  const int UP_PIN    = 2;
  const int DOWN_PIN  = 3;
  const int PF_PIN    = 4;
  const int MR_PIN    = 5;
  const int CALL_PIN  = 6;
  const int VFO_PIN   = 7;
  
  const byte DTMF_ZERO  = 0x0A;
  const byte DTMF_ONE   = 0x01;
  const byte DTMF_TWO   = 0x02;  
  const byte DTMF_THREE = 0x03;
  const byte DTMF_FOUR  = 0x04;
  const byte DTMF_FIVE  = 0x05;
  const byte DTMF_SIX   = 0x06;
  const byte DTMF_SEVEN = 0x07;
  const byte DTMF_EIGHT = 0x08;
  const byte DTMF_NINE  = 0x09;
  const byte DTMF_STAR  = 0x0B;
  const byte DTMF_POUND = 0x0C;
  const byte DTMF_A     = 0x0D;
  const byte DTMF_B     = 0x0E;
  const byte DTMF_C     = 0x0F;
  const byte DTMF_D     = 0x00;
  const byte DTMF_OFF   = 0x1F;
  const byte DTMF_697   = 0x10;
  const byte DTMF_770   = 0x11;
  const byte DTMF_852   = 0x12;
  const byte DTMF_941   = 0x13;
  const byte DTMF_1209  = 0x14;
  const byte DTMF_1336  = 0x15;
  const byte DTMF_1477  = 0x16;
  const byte DTMF_1633  = 0x17;  

  
  int TONE_DELAY   = 75; //length of time in ms to leave tone on
  int BUTTON_DELAY = 75; //length of time in ms to leave button on
  int LONG_PRESS_TIME = 1200; //length of time in ms to similate a long press (1200 ms, so it is > 1sec)
  const int ENABLE_DELAY = 1; //length of time in ms to apply enable before clocking in data
  bool getToneTime = false;
  bool getButtonTime = false;
  bool getLongPressTime = false;
  
void setup() {
  Serial.begin(9600);
  
  pinMode(CLK_PIN, OUTPUT);
  pinMode(DATA_PIN, OUTPUT);
  pinMode(ENABLE_PIN, OUTPUT);
  //
  digitalWrite(CLK_PIN, LOW);
  digitalWrite(DATA_PIN, LOW);
  digitalWrite(ENABLE_PIN, HIGH);
  
  pinMode(UP_PIN, INPUT);
  pinMode(DOWN_PIN, INPUT);
  pinMode(PF_PIN, INPUT);
  pinMode(MR_PIN, INPUT);
  pinMode(CALL_PIN, INPUT);
  pinMode(VFO_PIN, INPUT);
  //
  digitalWrite(UP_PIN, LOW);
  digitalWrite(DOWN_PIN, LOW);
  digitalWrite(PF_PIN, LOW);
  digitalWrite(MR_PIN, LOW);
  digitalWrite(CALL_PIN, LOW);
  digitalWrite(VFO_PIN, LOW);
  
  message.attach(messageCompleted);
}

void setEnableOn()
{
   digitalWrite(ENABLE_PIN, LOW);
   delay(ENABLE_DELAY);
}

void setEnableOff()
{
   digitalWrite(ENABLE_PIN, HIGH);
}

void HT9200ACommandOut(byte dataOut)
{
  for (int x=0; x<10; x++)
  {
    if (x % 2 == 0)
    {
      digitalWrite(CLK_PIN, HIGH);
      digitalWrite(DATA_PIN, bitRead(dataOut, 0));
      dataOut >>= 1;
    }
    else
    {
      digitalWrite(CLK_PIN, LOW);
    }
  }
}

void myShiftOut (byte dataOut, int toneTime)
{
  digitalWrite(CLK_PIN, HIGH);
  digitalWrite(DATA_PIN, LOW);
  
  setEnableOn();
  
  HT9200ACommandOut(dataOut);
  
  digitalWrite(CLK_PIN, HIGH);
  
  delay(toneTime);
    
  HT9200ACommandOut(DTMF_OFF);

  delay(TONE_DELAY);
  
  setEnableOff();
  
  digitalWrite(CLK_PIN, HIGH);
  digitalWrite(DATA_PIN, LOW);
}

void pressButton(const int pin, int pressTime)
{
  pinMode(pin, OUTPUT);
  delay(pressTime);
  pinMode(pin, INPUT);
}

void loop() { 
  while ( Serial.available( ) ) message.process(Serial.read( ) );
}

void messageCompleted() 
{
  do
  {
    if (getToneTime == true)
    {
      getToneTime = false;
      TONE_DELAY = message.readInt();
      //Serial.println(TONE_DELAY);
      break;
    }
    
    if (getButtonTime == true)
    {
      getButtonTime = false;
      BUTTON_DELAY = message.readInt();
      //Serial.println(BUTTON_DELAY);
      break;
    }
    
    if (getLongPressTime == true)
    {
      getLongPressTime = false;
      LONG_PRESS_TIME = message.readInt();
      //Serial.println(LONG_PRESS_TIME);
      break;
    }
    
    if (message.checkString("SET_LONG_PRESS_TIME:"))
    {
      getLongPressTime = true;
      break;
    }
    
    if (message.checkString("SET_TONE_TIME:"))
    {
      getToneTime = true;
      break;
    }
    
    if (message.checkString("SET_BUTTON_TIME:"))
    {
      getButtonTime = true;
      break;
    }
    
    if (message.checkString("PAUSE: "))
    {
      delay(TONE_DELAY);
      break;
    }
    
    // DTMF dual tones (0-9, A-D)
    if (message.checkString("0")) 
    {
      myShiftOut(DTMF_ZERO, TONE_DELAY);
      break;
    }
    
    if (message.checkString("1")) 
    {
      myShiftOut(DTMF_ONE, TONE_DELAY);
      break;
    }
    
    if (message.checkString("2")) 
    {
      myShiftOut(DTMF_TWO, TONE_DELAY);
      break;
    }
    
    if (message.checkString("3")) 
    {
      myShiftOut(DTMF_THREE, TONE_DELAY);
      break;
    }
    
    if (message.checkString("4")) 
    {
      myShiftOut(DTMF_FOUR, TONE_DELAY);
      break;
    }
    
   if (message.checkString("5")) 
    {
      myShiftOut(DTMF_FIVE, TONE_DELAY);
      break;
    }
    
    if (message.checkString("6")) 
    {
      myShiftOut(DTMF_SIX, TONE_DELAY);
      break;
    }
    
    if (message.checkString("7")) 
    {
      myShiftOut(DTMF_SEVEN, TONE_DELAY);
      break;
    }
    
    if (message.checkString("8")) 
    {
      myShiftOut(DTMF_EIGHT, TONE_DELAY);
      break;
    }
    
    if (message.checkString("9")) 
    {
      myShiftOut(DTMF_NINE, TONE_DELAY);
      break;
    }
    
    if (message.checkString("A")) 
    {
      myShiftOut(DTMF_A, TONE_DELAY);
      break;
    }
    
    if (message.checkString("B")) 
    {
      myShiftOut(DTMF_B, TONE_DELAY);
      break;
    }
    
    if (message.checkString("C")) 
    {
      myShiftOut(DTMF_C, TONE_DELAY);
      break;
    }
    
    if (message.checkString("D")) 
    {
      myShiftOut(DTMF_D, TONE_DELAY);
      break;
    }
       
    if (message.checkString("STAR")) 
    {
      myShiftOut(DTMF_STAR, TONE_DELAY);
      break;
    }
    
    if (message.checkString("POUND")) 
    {
      myShiftOut(DTMF_POUND, TONE_DELAY);
      break;
    }
    
    // single tones
    if (message.checkString("697")) 
    {
      myShiftOut(DTMF_697, TONE_DELAY);
      break;
    }
    
    if (message.checkString("770")) 
    {
      myShiftOut(DTMF_770, TONE_DELAY);
      break;
    }
    
    if (message.checkString("852")) 
    {
      myShiftOut(DTMF_852, TONE_DELAY);
      break;
    }
    if (message.checkString("941")) 
    {
      myShiftOut(DTMF_941, TONE_DELAY);
      break;
    }
    if (message.checkString("1209")) 
    {
      myShiftOut(DTMF_1209, TONE_DELAY);
      break;
    }
    
    if (message.checkString("1336")) 
    {
      myShiftOut(DTMF_1336, TONE_DELAY);
      break;
    }
    
    if (message.checkString("1477")) 
    {
      myShiftOut(DTMF_1477, TONE_DELAY);
      break;
    }
    
    if (message.checkString("1633")) 
    {
      myShiftOut(DTMF_1633, TONE_DELAY);
      break;
    }

  // button presses
    if (message.checkString("UP"))
    {
      pressButton(UP_PIN, BUTTON_DELAY);
      break;
    }
    
    if (message.checkString("DOWN"))
    {
      pressButton(DOWN_PIN, BUTTON_DELAY);
      break;
    }
    
    if (message.checkString("MR"))
    {
      pressButton(MR_PIN, BUTTON_DELAY);
      break;
    }
     
    if (message.checkString("LONG_MR"))
    {
      pressButton(MR_PIN, LONG_PRESS_TIME);
      break;
    }
   
    if (message.checkString("VFO"))
    {
      pressButton(VFO_PIN, BUTTON_DELAY);
      break;
    }
    
    if (message.checkString("CALL"))
    {
      pressButton(CALL_PIN, BUTTON_DELAY);
      break;
    }
    
    //if we get to here, just clear out buffer
    char trash[30];
    message.copyString(trash, 30);
    
  } while(false);
  
  Serial.print("READY");
  Serial.println();
}



