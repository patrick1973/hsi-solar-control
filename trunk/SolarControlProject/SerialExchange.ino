void showLdrValuesSerial()
{
  Serial.print("begin");
  Serial.print(readLeftLdrValue());
  Serial.print(",");
  Serial.print(readRightLdrValue());
  Serial.print(",");
  Serial.print(readUpLdrValue());
  Serial.print(",");
  Serial.print(readDownLdrValue());
  Serial.print(",");
  Serial.println("end");
}

String getStringBetween(String strSource, char charBegin, char charEnd)
{
  int startIndex, stopIndex;
  startIndex = strSource.indexOf(charBegin)+1;
  stopIndex =  strSource.indexOf(charEnd);
  return strSource.substring(startIndex,stopIndex);
}

String getSerialCommand()
{
  String inputString = "";
  while(Serial.available())
  {
    char inChar = (char)Serial.read(); 
    
    inputString += inChar;
  } 
  return getStringBetween(inputString, '$', '#');
}


