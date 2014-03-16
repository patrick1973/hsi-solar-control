
/**
*------------------------------------------------------------------------------
*Calculate the average value of the top sensor and the left sensor
*@return the average value of left top
*------------------------------------------------------------------------------
*/
int avg_Left_Top()
{
  return (readLeftLdrValue() + readUpLdrValue()) /2;
}
/**
*------------------------------------------------------------------------------
*Calculate the average value of the bottom sensor and the left sensor
*@return the average value of left bottom
*------------------------------------------------------------------------------
*/
int avg_Left_Bottom()
{
  return (readLeftLdrValue() + readDownLdrValue())/2;
}
/**
*------------------------------------------------------------------------------
*Calculate the average value of the top sensor and the right sensor
*@return the average value of right top
*------------------------------------------------------------------------------
*/
int avg_Right_Top()
{
  return (readRightLdrValue() + readUpLdrValue())/2;
}
/**
*------------------------------------------------------------------------------
*Calculate the average value of the bottom sensor and the right sensor
*@return the average value of left top
*------------------------------------------------------------------------------
*/
int avg_Right_Bottom()
{
  return (readRightLdrValue() + readDownLdrValue())/2;
}

/**
*------------------------------------------------------------------------------
*Calculate the deifference between calcultaed top value and calculated bottom value.
*@return the diffirence of up and down
*------------------------------------------------------------------------------
*/
int differenceVertical()
{
  return ((avg_Left_Top() + avg_Right_Top()) - (avg_Left_Bottom()+ avg_Right_Bottom()));
}

/**
*------------------------------------------------------------------------------
*Calculate the average value of the right sensor and the left sensor
*@return the diffirence of left and right
*------------------------------------------------------------------------------
*/
int differenceHorizontal()
{
  return ((avg_Left_Top()+ avg_Left_Bottom()) - (avg_Right_Top()+ avg_Right_Bottom()));
}

/**
*------------------------------------------------------------------------------
*@return position of the vertical servo
*------------------------------------------------------------------------------
*/
int checkVerticalPosition()
{
  static int valueVertical = 15; // min value is 15 miss allignment of the mechanical settings.
  if(-1*readHysteresisValue() > differenceVertical() || differenceVertical() > readHysteresisValue()) //Controleer of de gemeten gemiddelde waarde buiten de hystiresis ligt
  {
    if (( avg_Left_Top()+ avg_Right_Top()) > (avg_Left_Bottom() + avg_Right_Bottom()))                // naar boven
    {
      valueVertical=--valueVertical;
      if (valueVertical < MIN_VERTICAL)
      {
        valueVertical = MIN_VERTICAL;
      }
    }
    else if ((avg_Left_Top() + avg_Right_Top()) < (avg_Left_Bottom() + avg_Right_Bottom()))          // naar beneden
    {
      valueVertical = ++valueVertical;
      if (valueVertical > MAX_VERTICAL)
      {
        valueVertical = MAX_VERTICAL;
      } 
    }
  }
  return valueVertical;
}

/**
*------------------------------------------------------------------------------
*@return position of the horizontal servo
*------------------------------------------------------------------------------
*/
int checkHorizontalPosition()
{
  static int valueHorizontal = 0;
  if(-1*readHysteresisValue() > differenceHorizontal() || differenceHorizontal() > readHysteresisValue())
  {
    if (( avg_Left_Top()+ avg_Left_Bottom()) > (avg_Right_Top() + avg_Right_Bottom())) 
    {
      valueHorizontal=++valueHorizontal;
      if (valueHorizontal > MAX_HORIZONTAL)
      {
        valueHorizontal = MAX_HORIZONTAL;
      }
    }
    else if ((avg_Left_Top() + avg_Left_Bottom()) < (avg_Right_Top() + avg_Right_Bottom()))
    {
      valueHorizontal = --valueHorizontal;
      if (valueHorizontal < MIN_HORIZONTAL)
      {
        valueHorizontal = MIN_HORIZONTAL;
      } 
    }
  }
  return valueHorizontal;
}

