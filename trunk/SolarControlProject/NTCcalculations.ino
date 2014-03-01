// resistance at 25 degrees C
#define THERMISTORNOMINAL 10000      
// temp. for nominal resistance (almost always 25 C)
#define TEMPERATURENOMINAL 25   
// how many samples to take and average, more takes longer
// but is more 'smooth'
#define NUMSAMPLES 5
// The beta coefficient of the thermistor (usually 3000-4000)
#define BCOEFFICIENT 3950
// the value of the 'other' resistor
#define SERIESRESISTOR 10000    

/**
*------------------------------------------------------------------------------
* This function is used to measure the actual temperature in degree celcius
*@return the actual measured NTC temperature in degree celcius
*------------------------------------------------------------------------------
*/
float ntcTemperature()
{
  int samples[NUMSAMPLES];
  float average;
  // take N samples in a row, with a slight delay
  for (int i=0;i<NUMSAMPLES; i++)
  {
    samples[i] = readNtcValue();
    delay(2);
  }
  
  average = 0;
  for (int i=0;i<NUMSAMPLES;i++)
  {
    average += samples[i];
  }
  average /= NUMSAMPLES;
  
  // convert the value to resistance
  average = 1023 / average - 1;
  average = SERIESRESISTOR / average;
  
  float steinhart;
  steinhart = average / THERMISTORNOMINAL;     // (R/Ro)
  steinhart = log(steinhart);                  // ln(R/Ro)
  steinhart /= BCOEFFICIENT;                   // 1/B * ln(R/Ro)
  steinhart += 1.0 / (TEMPERATURENOMINAL + 273.15); // + (1/To)
  steinhart = 1.0 / steinhart;                 // Invert
  steinhart -= 273.15;                         // convert to C
  
  return steinhart;
}
