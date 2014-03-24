int defrostControl(int systemStatus)
{
  static int noBlockingCounter = 0;
  static int finalDefrostCounter =0;
  static dState defrostState; // enum definition for defrost state
  const float hyst = 1.0;  // als nct1 "defrostStart" lager is dan ntc1 start ontdooi cyclus
  float ntc1;
  float ntc2;
  int stopDefrost;

  noBlockingCounter++;
  if (noBlockingCounter >= 60 )
  {
    ntc1        = ntcTemperature(readNtcValuePanel());   // sensor mounted on the solar panel under the glass
    ntc2        = ntcTemperature(readNtcValueOutside()); // sensor mounted in de vicinity of the solar panel
    stopDefrost = ntcTemperature(readPotValueEODS());    // temperature to stop the defrosting
    noBlockingCounter=0;
  }

  if (( systemStatus == 2 ) || (systemStatus == 7 ))
  {
    switch (defrostState)
    {
    case DEFROST_IDLE:
      if ((ntc1+hyst) < (ntc2))
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
  }
}






