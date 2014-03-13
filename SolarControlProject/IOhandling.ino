void setupIO()
{
  Serial.begin(115200);
  servo_vertical.attach(5);   // attaches the servo on pin 5 (Elevation) to the servo object 
  servo_horizontal.attach(6); // attaches the servo on pin 6 (Horizontal) to the servo object
  
  pinMode(SCROLL_PIN, INPUT);
  pinMode(LED_PIN,OUTPUT);
  lcd.begin(16, 2);

}
/**
 *------------------------------------------------------------------------------
 *@return the actual raw value of the LDR that is used for left control
 *------------------------------------------------------------------------------
 */
int readLeftLdrValue()
{
  return analogRead(LDR_1_Left);
}
/**
 *------------------------------------------------------------------------------
 *@return the actual raw value of the LDR that is used for right control
 *------------------------------------------------------------------------------
 */
int readRightLdrValue()
{
  return analogRead(LDR_2_Right);
}
/**
 *------------------------------------------------------------------------------
 *@return the actual raw value of the LDR that is used for up control
 *------------------------------------------------------------------------------
 */
int readUpLdrValue()
{
  return analogRead(LDR_4_Up);
}
/**
 *------------------------------------------------------------------------------
 *@return the actual raw value of the LDR that is used for down control
 *------------------------------------------------------------------------------
 */
int readDownLdrValue()
{
  return analogRead(LDR_3_Down);
}

/**
 *------------------------------------------------------------------------------
 *@return the actual raw value of the potentiometer to adjust te tollerance value (misschien niet het juiste woord.
 *------------------------------------------------------------------------------
 */
int readHysteresisValue()
{
  return analogRead(TOLERANCEPIN);
}
/**
 *------------------------------------------------------------------------------
 *@return the actual raw value of the NTC
 *------------------------------------------------------------------------------
 */
int readNtcValue()
{
  return analogRead(NTCPIN);
}

