
void readADCvalues( int *adcValues,int lenght)
{
   Wire.beginTransmission(PCF8591);  // wake up PCF8591P
   Wire.write(0x04);                 // control byte - read ADC0 then auto-increment
   Wire.endTransmission();           // end tranmission
   Wire.requestFrom(PCF8591, 5);     // request to read 5 bytes from the PCF8591P
   adcValues[0] = Wire.read();       // read the value of the adac channel
   adcValues[0] = Wire.read();       // read the value of the adac channel
   adcValues[1] = Wire.read();       // read the value of the adac channel
   adcValues[2] = Wire.read();       // read the value of the adac channel
   adcValues[3] = Wire.read();       // read the value of the adac channel
   Serial.print(adcValues[0]);
   Serial.print("--");
    Serial.print(adcValues[1]);
   Serial.print("--");
    Serial.print(adcValues[2]);
   Serial.print("--");
    Serial.print(adcValues[3]);
   Serial.print("\n");
}
