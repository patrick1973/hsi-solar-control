#include <Servo.h>
#include <LiquidCrystal.h>
#include <Wire.h>
#include <math.h>
#include "Init.h"


int SystemState;
int adcValues[4];
int manState;
int test = 99;
void setup()
{ 
  setupIO(); 
}

void loop()
{
  readADCvalues(&adcValues[0],4);          // update every cycle the ADC converter.
  manState = manualStateSelect(readSelectButton(),readScrollButton());
  SystemState = getSerialSystemState(manState);
  showLdrValuesSerial();
  delay(50);
}







