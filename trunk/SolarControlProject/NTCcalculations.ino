
/**
 *------------------------------------------------------------------------------
 * This function is used to measure the actual temperature in degree celcius
 *@return the actual measured NTC temperature in degree celcius
 *------------------------------------------------------------------------------
 */
double Thermistor(int RawADC) {
 double Temp;
 Temp = log(10000.0*((MAX_VALUE_ADC_PCF8591P /RawADC-1))); 
 Temp = 1 / (0.001129148 + (0.000234125 + (0.0000000876741 * Temp * Temp ))* Temp );
 Temp = Temp - 273.15;            // Convert Kelvin to Celcius
 return Temp;
}



 
 


