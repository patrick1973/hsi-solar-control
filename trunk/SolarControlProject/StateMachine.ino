/**
 *------------------------------------------------------------------------------
 *The function getSerialSystemState(): \n
 *This function reveive the system state from the PC application trough the serial port.\n
 *Disassemble the the received commamnd message and change state and / or behaviour accordingly \n
 *------------------------------------------------------------------------------
 */

int getSerialSystemState()
{
  static int JogUpDown =15;
  static int JogLeftRight =0;
  static int iSysState= 5;

  String command = "";
  String systemStateNumber = "";

  String newReceivedMessage = getSerialCommand('$', '#');
  String systemState = getStringBetween(newReceivedMessage,'$',';');  // Get state name
  systemStateNumber = getStringBetween(newReceivedMessage,';','#');   // Get state number

  if (systemStateNumber.toInt() > 0 )
  {
    iSysState = systemStateNumber.toInt();
  }

  switch (  iSysState )
  {
  case 0: //dummy
    break;

  case 1: //SYS_MANUAL
    lcd.print("SYS_MANUAL      ");  
    lcd.setCursor(0,0);
    if ( systemState == "JOG_UP" || systemState == "JOG_DOWN" || systemState == "JOG_LEFT" || systemState == "JOG_RIGHT")
    {
      if ( systemState == "JOG_UP" )
      {
        JogUpDown = getVerticalPosFeedback(); //setup the actual servo position to the pos. of the manual control. to prefent fast moving servo's
        JogUpDown = JogUpDown+3;              //count in steps of 3 degree
        if ( JogUpDown >= MAX_VERTICAL )
        {
          JogUpDown = MAX_VERTICAL;
        }
        jogServoVertical( JogUpDown );        //write the manual value to the servo.
        lcd.setCursor(0,1);
        lcd.print("JOG_UP          ");    
      }
      else if ( systemState == "JOG_DOWN" )
      {
        JogUpDown = getVerticalPosFeedback();
        JogUpDown = JogUpDown-3;
        if ( JogUpDown <= MIN_VERTICAL )
        {
          JogUpDown = MIN_VERTICAL;
        }
        jogServoVertical( JogUpDown );
        lcd.setCursor(0,1);
        lcd.print("JOG_DOWN        ");
      } 
      else if ( systemState == "JOG_LEFT" )
      {
        JogLeftRight = getHorizontalPosFeedback();
        JogLeftRight=JogLeftRight+3;
        if ( JogLeftRight >= MAX_HORIZONTAL )
        {
          JogLeftRight = MAX_HORIZONTAL;
        }
        jogServoHorizontal( JogLeftRight );
        lcd.setCursor(0,1);
        lcd.print("JOG_LEFT        ");
      } 
      else if ( systemState == "JOG_RIGHT" )
      {
        JogLeftRight = getHorizontalPosFeedback();
        JogLeftRight=JogLeftRight-3;
        if ( JogUpDown <= MIN_HORIZONTAL )
        {
          JogUpDown = MIN_HORIZONTAL;
        }
        jogServoHorizontal( JogLeftRight );
        lcd.setCursor(0,1);
        lcd.print("JOG_RIGHT       ");
      } 
    }
    break;
  case 2: //SYS_AUTO
    lcd.setCursor(0,0);
    lcd.print("SYS_AUTO        ");  
    servo_vertical.write(checkVerticalPosition());
    servo_horizontal.write(checkHorizontalPosition());
    break;
  case 3: //SYS_CLEANING
    lcd.print("SYS_CLEANING    ");  
    lcd.setCursor(0,0);
    panelVerticalPosition();
    break;
  case 4: //SYS_MAINTENANCE
    lcd.print("SYS_MAINTENANCE ");   
    lcd.setCursor(0,0);
    panelHorizontalPosition();
    break;
  case 5: //SYS_IDLE
    lcd.print("SYS_IDLE        ");   
    lcd.setCursor(0,0);
    returnToRestPosition();
    break;
  case 6: 
    lcd.print("SYS_STOP        ");
    lcd.setCursor(0,0);
    break;
  case 7: 
    lcd.print("SYS_DEFROST     ");
    lcd.setCursor(0,0);
    break; 
  } 
  return iSysState;
}









