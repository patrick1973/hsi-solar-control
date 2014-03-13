#include <Servo.h>
#include <LiquidCrystal.h>
#include "Init.h"

String systemState = "SYSTEM_STOP";
int teller = 0;
float temp = 0.0;

state controlState;
//mStates systemState;
void setup()
{ 
  setupIO(); 
}

void loop()
{
//  getSerialSystemState();
//  int knopje = digitalRead(SCROLL_PIN);
//  digitalWrite(LED_PIN,knopje);
//  if (knopje == HIGH)
//  {
//    showLdrValuesLCD();
//    returnToRestPosition();
//  }
//  
//  teller++;
//  if (teller >= 600)
//  {
    temp = ntcTemperature(readNtcValue());
//    teller =0;
//    lcd.clear();
//    lcd.setCursor(0,0);
//    lcd.print(temp);
//    lcd.println( " Celcius");
//  }
//controlState = controlPosition ; // als test zodat de tracker altijd in de volg mode staat.
//  switch(controlState)
//  {
//  case restPosition:
//   // returnToRestPosition();
//    break;
//  case controlPosition:
//   // verticalServoControl();
//  //  horizontalServoControl();
//    break;
//  case gotoHorizontalPosition:
//    //panelHorizontalPosition();
//    break;
//  case gotoVerticalPosition: 
//   //panelVerticalPosition();
//    break;

 
  String systemStateNew = getStringBetween(getSerialCommand(),'$',';');
  if (!systemStateNew.equals(systemState))
  {
   systemState = "SYSTEM_AUTO" ;
  }
  
  lcd.print(systemState);
    lcd.setCursor(0,0);
  if (systemState.equals("SYSTEM_STOP"))
  {
    lcd.print(systemState);
    lcd.setCursor(0,0);
  }
  else if (systemState.equals("SYSTEM_MANUAL"))
  {
    lcd.print(systemState);
    lcd.setCursor(0,0);
  }

  else if (systemState.equals("SYSTEM_AUTO"))
  {
    lcd.clear();
    lcd.print(systemState);
    lcd.setCursor(0,0);
    verticalServoControl();
    horizontalServoControl();
  }
  else if (systemState.equals("SYSTEM_CLEANING"))
  {
    lcd.print(systemState);
    lcd.setCursor(0,0);
    panelVerticalPosition();
  }
  else if (systemState.equals("SYSTEM_MAINTENANCE"))
  {
    lcd.print(systemState);
    lcd.setCursor(0,0);
    panelHorizontalPosition();
  }
  else if (systemState.equals("SYSTEM_IDLE"))
  {
    lcd.print(systemState);
    lcd.setCursor(0,0);
    returnToRestPosition();
  }
    delay(100);
  }





