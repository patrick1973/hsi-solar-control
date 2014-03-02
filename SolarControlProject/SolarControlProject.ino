#include <Servo.h>
#include <LiquidCrystal.h>
#include "Init.h"

void setup()
{ 
  setupIO(); 
}

void loop()
{
  readDateTime();
  showLdrValuesSerial();
  //lcd.print(ntcTemperature());
  int knopje = digitalRead(SCROLL_PIN);
  digitalWrite(LED_PIN,knopje);
  if (knopje == HIGH)
  {
    showLdrValuesLCD();
  }
  
  servo_vertical.write(checkVerticalPosition());
  servo_horizontal.write(checkHorizontalPosition());

}


