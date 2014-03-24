#include <Servo.h>
#include <LiquidCrystal.h>
#include <Wire.h>
#include "Init.h"


int SystemState;
int adcValues[4];

void setup()
{ 
  setupIO(); 
}

void loop()
{
  readADCvalues(&adcValues[0],4);          // update every cycle the ADC converter.
  SystemState = getSerialSystemState();
  showLdrValuesSerial();
  defrostControl(SystemState);
  delay(50);
}







