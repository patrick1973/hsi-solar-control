void readADCvalues( int *adcValues0,int *adcValues1,int *adcValues2,int *adcValues3)
{
  
   Wire.beginTransmission(PCF8591);  // wake up PCF8591P
   Wire.write(0x04);                 // control byte - read ADC0 then auto-increment
   Wire.endTransmission();           // end tranmission
   Wire.requestFrom(PCF8591, 5);     // request to read 5 bytes from the PCF8591P
   *adcValues0=Wire.read();          // read the value of the adac channel
   *adcValues0=Wire.read();          // read the value of the adac channel
   *adcValues1=Wire.read();          // read the value of the adac channel
   *adcValues2=Wire.read();          // read the value of the adac channel
   *adcValues3=Wire.read();          // read the value of the adac channel
}

