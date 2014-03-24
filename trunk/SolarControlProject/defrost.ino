int defrostControl()
{
  static int noBlockingCounter = 0;
  static int finalDefrostCounter =0;
  static dState defrostState; // enum definition for defrost state
  const float hyst = -6.0;  // als nct1 "defrostStart" lager is dan ntc1 start ontdooi cyclus
  static double ntc1;
  static double ntc2;
  static double stopDefrost;

  noBlockingCounter++;
  if (noBlockingCounter >= 60 )
  {
    ntc1        = Thermistor(readNtcValuePanel());   // sensor mounted on the solar panel under the glass
    ntc2        = Thermistor(readNtcValueOutside()); // sensor mounted in de vicinity of the solar panel
    stopDefrost = Thermistor(readPotValueEODS());    // temperature to stop the defrosting
    noBlockingCounter=0;
  }
  lcd.setCursor(0,1);
  lcd.print(ntc1);
  lcd.print("-");
  lcd.print(ntc2);
  lcd.print("-");
  lcd.print(stopDefrost);
  
  if ((SystemState == 2) || (SystemState == 7))
  {
     switch (defrostState)
    {
    case DEFROST_IDLE:
      if ((ntc1-hyst) < (ntc2))
      {
        defrostState = DEFROST_ACTIVE;
      }
      break;

    case DEFROST_ACTIVE:
      led13Control(HIGH);
      panelDefrostPosition();
      if (ntc1 > stopDefrost)
      {
        defrostState = FINALIZING_DEFROST;
      }
      break;

    case FINALIZING_DEFROST:
      finalDefrostCounter++;
      led13Control(HIGH);
      panelDefrostPosition();
      delay(1000);
      if ( finalDefrostCounter >= 120 ) // remain in this state for 2 miutes with defrost on
      {
        defrostState = FINISHED_DEFROST;
      }
      break;

    case FINISHED_DEFROST:
      led13Control(LOW);      //stop defrost
      finalDefrostCounter=0;
      defrostState = DEFROST_IDLE;
      break;
    }
    return defrostState;
  }
    return -1;
}






