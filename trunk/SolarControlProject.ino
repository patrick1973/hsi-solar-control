#include <Servo.h>
#include <LiquidCrystal.h>
#include "Init.h"


void setup()
{ 
  setupIO();
  Serial.begin(9600);
  
}

void loop()
{
//  Serial.print("horizontaal verschil : ");
//  Serial.print(differenceHorizontal());
//  Serial.print("verticaal verschil : ");
//  Serial.println(differenceVertical());
//  Serial.println(readToleranceValue());

//Serial.print( "Vertical pos : ");
//Serial.print(checkVerticalPosition());
//Serial.print(" Horizontal pos : ");
//Serial.println(checkHorizontalPosition());


//lcd.print(ntcTemperature());
int knopje = digitalRead(SCROLL_PIN);
digitalWrite(LED_PIN,knopje);
if (knopje == HIGH)
{
showLdrValues();
}
else
{
  showSerovPositions();
}
  servo_vertical.write(checkVerticalPosition());
  servo_horizontal.write(checkHorizontalPosition());
}

