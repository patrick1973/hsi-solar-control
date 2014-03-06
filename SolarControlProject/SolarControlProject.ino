#include <Servo.h>
#include <LiquidCrystal.h>
#include "Init.h"


int teller = 0;
float temp = 0.0;

state controlState;
void setup()
{ 
  setupIO(); 
}

void loop()
{

  readDateTime(); // read time from serial 
  showLdrValuesSerial(); //write values to serial
  int knopje = digitalRead(SCROLL_PIN);
  digitalWrite(LED_PIN,knopje);
  if (knopje == HIGH)
  {
    showLdrValuesLCD();
    returnToRestPosition();
  }
  
  teller++;
  if (teller >= 600)
  {
    temp = ntcTemperature(readNtcValue());
    teller =0;
    lcd.clear();
    lcd.setCursor(0,0);
    lcd.print(temp);
    lcd.println( " Celcius");
  }
controlState = controlPosition ;
  switch(controlState)
  {
  case restPosition:
    returnToRestPosition();
    break;
  case controlPosition:
    verticalServoControl();
    horizontalServoControl();
    break;
  case gotoHorizontalPosition:
    panelHorizontalPosition();
    break;
  case gotoVerticalPosition: 
    panelVerticalPosition();
    break;
  }
}




