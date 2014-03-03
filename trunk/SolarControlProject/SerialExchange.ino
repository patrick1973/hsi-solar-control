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


