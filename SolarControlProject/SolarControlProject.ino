#include <Servo.h>
#include <LiquidCrystal.h>
#include <Wire.h>
#include <math.h>
#include "Init.h"


int SystemState;
int globalDefrostState;
int adcValues[4];

int test = 99;
void setup()
{ 
  setupIO(); 
}

void loop()
{
  test=99;
  readADCvalues(&adcValues[0],4);          // update every cycle the ADC converter.
  SystemState = getSerialSystemState();
  showLdrValuesSerial();
  globalDefrostState = defrostControl();
  Serial.print(globalDefrostState);
  delay(50);
}







