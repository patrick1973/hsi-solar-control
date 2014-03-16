#include <Servo.h>
#include <LiquidCrystal.h>
#include <Wire.h>
#include "Init.h"


int teller = 0;
float temp1 = 0.0;
float temp2 = 0.0;
float treshhold=0.0;
int SystemState;


void setup()
{ 
  setupIO(); 
}

void loop()
{
  readADCvalues(&adcValues0,&adcValues1,&adcValues2,&adcValues3); // update every cycle the ADC converter. Can be a better wat to do this, but for now....
  SystemState = getSerialSystemState();
  showLdrValuesSerial();
  
  teller++;
  if (teller >= 60)
  {
    temp1 = ntcTemperature(readNtcValueOutside());
    temp2 = ntcTemperature(readNtcValuePanel());
    treshhold = ntcTemperature(readPotValueEODS());
    
    lcd.setCursor(0,1);
    lcd.print(temp1);
    lcd.print("#");
    lcd.print(temp2);
    lcd.print("#");
    lcd.print(treshhold);
    lcd.print("#");
    
    
    teller =0;
  }  
  delay(50);
}







