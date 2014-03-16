void setupIO()
{
  Serial.begin(115200);       // setup serial communications with PC
  Wire.begin();               // setup the I2C communications with PCF8591P
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
byte readHysteresisValue()
{
  return adcValues3;
}
/**
 *------------------------------------------------------------------------------
 *@return the actual raw value of the NTC placed outside the panel.
 *------------------------------------------------------------------------------
 */
byte readNtcValueOutside()
{
  return adcValues0;
}

/**
 *------------------------------------------------------------------------------
 *@return the actual raw value of the NTC placed on the panel.
 *------------------------------------------------------------------------------
 */
byte readNtcValuePanel()
{
  return adcValues1;
}
/**
 *------------------------------------------------------------------------------
 *@return the actual raw value of the POT to create a switch value for the EODS.
 *------------------------------------------------------------------------------
 */
byte readPotValueEODS()
{
  return adcValues2;
}
