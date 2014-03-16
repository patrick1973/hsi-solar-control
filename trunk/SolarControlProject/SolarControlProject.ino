#include <Servo.h>
#include <LiquidCrystal.h>
#include "Init.h"


int teller = 0;
float temp = 0.0;
int SystemState;
void setup()
{ 
  setupIO(); 
}

void loop()
{
  SystemState = getSerialSystemState();
  showLdrValuesSerial();
  teller++;
  if (teller >= 600)
  {
    temp = ntcTemperature(readNtcValue());
    teller =0;
  }
  delay(50);
}






