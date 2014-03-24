/**
*********************************************************************************************************
** Function name:           verticalServoControl
** Descriptions:            Activate the servocontrol for vertical movement when this function is called the light calculations will start and the servo respond accordingly
** input parameters:        NONE
** Output parameters:       NONE
** Returned value:          NONE
********************************************************************************************************
*/
void verticalServoControl()
{
  servo_vertical.write(checkVerticalPosition());
}
/**
*********************************************************************************************************
** Function name:           horizontalServoControl
** Descriptions:            Activate the servocontrol for horizontal movement when this function is called the light calculations will start and the servo respond accordingly
** input parameters:        NONE
** Output parameters:       NONE
** Returned value:          NONE
********************************************************************************************************
*/
void horizontalServoControl()
{
  servo_horizontal.write(checkHorizontalPosition());
}
/**
 *The panel will return back to it's resting postiion.
 *this function can be used in the night or when there is a hale storm. Is there is any chance that the panel can be dammaged.
 */
void returnToRestPosition()
{
  servo_horizontal.write(5);
  servo_vertical.write(15);
}
/**
*The panel will turn to full horziontal position. at the present rotary position
*(like a table). This position can be used for maintenance purpose.
*/
void panelHorizontalPosition()
{
  servo_vertical.write(100);
}
/**
*The panel will turn to full vertical position. at the present rotary position
*this position can be used to wash down the panel. (cleaning for example)
*/
void panelVerticalPosition()
{
  servo_vertical.write(15);
}

void panelDefrostPosition()
{
   servo_vertical.write(45);
   // 
}
void jogServoVertical( int value )
{
  servo_vertical.write(value);
}

void jogServoHorizontal( int value )
{
  servo_horizontal.write(value);
}
int getHorizontalPosFeedback()
{
  return servo_horizontal.read();
}
int getVerticalPosFeedback()
{
  return servo_vertical.read();
}

