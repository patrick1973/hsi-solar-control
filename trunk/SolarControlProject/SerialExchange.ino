void showLdrValuesSerial()
{
  Serial.print("$");
  Serial.print(readLeftLdrValue());
  Serial.print(",");
  Serial.print(readRightLdrValue());
  Serial.print(",");
  Serial.print(readUpLdrValue());
  Serial.print(",");
  Serial.print(readDownLdrValue());
  Serial.print(",");
  Serial.print(SystemState);
  Serial.print(",");
  Serial.print(getHorizontalPosFeedback());
  Serial.print(",");
  Serial.print(getVerticalPosFeedback());
  Serial.print(",");
  Serial.print(Thermistor(readNtcValueOutside()),2);
  Serial.print(",");
  Serial.print(Thermistor(readNtcValuePanel()),2);
  Serial.print(",");
  Serial.print(Thermistor(readPotValueEODS()),2);
  Serial.print(",");
  Serial.println("#");
}

String getStringBetween(String strSource, char charBegin, char charEnd)
{
  int startIndex, stopIndex;
  startIndex = strSource.indexOf(charBegin)+1;
  stopIndex =  strSource.indexOf(charEnd);
  return strSource.substring(startIndex,stopIndex);
}

String getSerialCommand(char beginChar, char endChar)
{
  String inputString = "";
  while(Serial.available())
  {
    char inChar = (char)Serial.read(); 
    
    inputString += inChar;
  } 
  return getStringBetween(inputString, beginChar, endChar);
}

/**
*------------------------------------------------------------------------------
*Read the time and or date from the C# application
*------------------------------------------------------------------------------
*/
String readDateTime()
{
  String inputString = "";
  while(Serial.available())
  {
    char inChar = (char)Serial.read(); 
    inputString += inChar;
   return inputString;
  } 
}
