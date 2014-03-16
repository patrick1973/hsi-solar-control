
/**
 *------------------------------------------------------------------------------
 * This function is used to measure the actual temperature in degree celcius
 *@return the actual measured NTC temperature in degree celcius
 *------------------------------------------------------------------------------
 */
float ntcTemperature(int temperature)
{
  int samples[NUMSAMPLES];        // create an array for storing the temperature samples.
  float average;                  // create a float variable to store the result of the average valvue
  
  for (int i=0;i<NUMSAMPLES; i++) // take N samples in a row, with a slight delay
  {
    samples[i] = temperature;
    delay(2);
  }

  average = 0;
  for (int i=0;i<NUMSAMPLES;i++)
  {
    average += samples[i];
  }
  average /= NUMSAMPLES;

  // convert the value to resistance
  average = MAX_VALUE_ADC_PCF8591P / average - 1;
  average = SERIESRESISTOR / average;

  float steinhart;
  steinhart = average / THERMISTORNOMINAL;           // (R/Ro)
  steinhart = log(steinhart);                        // ln(R/Ro)
  steinhart /= BCOEFFICIENT;                         // 1/B * ln(R/Ro)
  steinhart += 1.0 / (TEMPERATURENOMINAL + 273.15);  // + (1/To)
  steinhart = 1.0 / steinhart;                       // Invert
  steinhart -= 273.15;                               // convert to C

  return steinhart;
}

