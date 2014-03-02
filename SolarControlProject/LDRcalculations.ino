


/**
*------------------------------------------------------------------------------
*@return the average value of left top
*------------------------------------------------------------------------------
*/
int avg_Left_Top()
{
  return (readLeftLdrValue() + readUpLdrValue()) /2;
}
/**
*------------------------------------------------------------------------------
*@return the average value of left bottom
*------------------------------------------------------------------------------
*/
int avg_Left_Bottom()
{
  return (readLeftLdrValue() + readDownLdrValue())/2;
}
/**
*------------------------------------------------------------------------------
*@return the average value of left top
*------------------------------------------------------------------------------
*/
int avg_Right_Top()
{
  return (readRightLdrValue() + readUpLdrValue())/2;
}
/**
*------------------------------------------------------------------------------
*@return the average value of left top
*------------------------------------------------------------------------------
*/
int avg_Right_Bottom()
{
  return (readRightLdrValue() + readDownLdrValue())/2;
}

/**
*------------------------------------------------------------------------------
*@return the diffirence of up and down
*------------------------------------------------------------------------------
*/
int differenceVertical()
{
  return ((avg_Left_Top() + avg_Right_Top()) - (avg_Left_Bottom()+ avg_Right_Bottom()));
}

/**
*------------------------------------------------------------------------------
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
  static int valueVertical = 0;
  if(-1*readToleranceValue() > differenceVertical() || differenceVertical() > readToleranceValue())
  {
    if (( avg_Left_Top()+ avg_Right_Top()) > (avg_Left_Bottom() + avg_Right_Bottom()))
    {
      valueVertical=--valueVertical;
      if (valueVertical < 1)
      {
        valueVertical = 1;
      }
    }
    else if ((avg_Left_Top() + avg_Right_Top()) < (avg_Left_Bottom() + avg_Right_Bottom()))
    {
      valueVertical = ++valueVertical;
      if (valueVertical > 100)
      {
        valueVertical = 100;
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
  if(-1*readToleranceValue() > differenceHorizontal() || differenceHorizontal() > readToleranceValue())
  {
    if (( avg_Left_Top()+ avg_Left_Bottom()) > (avg_Right_Top() + avg_Right_Bottom()))
    {
      valueHorizontal=++valueHorizontal;
      if (valueHorizontal > 179)
      {
        valueHorizontal = 179;
      }
    }
    else if ((avg_Left_Top() + avg_Left_Bottom()) < (avg_Right_Top() + avg_Right_Bottom()))
    {
      valueHorizontal = --valueHorizontal;
      if (valueHorizontal < 1)
      {
        valueHorizontal = 1;
      }
      
    }
  }
  return valueHorizontal;
}

//int checkVerticalPosition()
//{
//  static int valueVertical = 0;
//  if(-1*readToleranceValue() > differenceVertical() || differenceVertical() > readToleranceValue())
//  {
//    if (( avg_Left_Top()+ avg_Right_Top()) > (avg_Left_Bottom() + avg_Right_Bottom()))
//    {
//      valueVertical = ++valueVertical;
//      if (valueVertical > 179)
//      {
//        valueVertical = 179;
//      }
//    }
//    else if ((avg_Left_Top() + avg_Right_Top()) < (avg_Left_Bottom() + avg_Right_Bottom()))
//    {
//      valueVertical=--valueVertical;
//      if (valueVertical < 1)
//      {
//        valueVertical = 1;
//      }
//    }
//  }
//  return valueVertical;
//}
//int checkHorizontalPosition()
//{
//  static int valueHorizontal = 0;
//  if(-1*readToleranceValue() > differenceHorizontal() || differenceHorizontal() > readToleranceValue())
//  {
//    if (( avg_Left_Top()+ avg_Left_Bottom()) > (avg_Right_Top() + avg_Right_Bottom()))
//    {
//      valueHorizontal = --valueHorizontal;
//      if (valueHorizontal < 1)
//      {
//        valueHorizontal = 1;
//      }
//    }
//    else if ((avg_Left_Top() + avg_Left_Bottom()) < (avg_Right_Top() + avg_Right_Bottom()))
//    {
//      valueHorizontal=++valueHorizontal;
//      if (valueHorizontal > 179)
//      {
//        valueHorizontal = 179;
//      }
//    }
//  }
//  return valueHorizontal;
//}