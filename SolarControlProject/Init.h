#include <arduino.h>

// setup values for the Steinman calculations used for the NTC
#define THERMISTORNOMINAL 10000 // resistance at 25 degrees C     
#define TEMPERATURENOMINAL 25   // temp. for nominal resistance (almost always 25 C)
#define NUMSAMPLES 5            // how many samples to take and average
#define BCOEFFICIENT 3950       // The beta coefficient of the thermistor (usually 3000-4000)
#define SERIESRESISTOR 10000    // the value of the 'other' resistor

Servo servo_vertical;
Servo servo_horizontal;

// Digital pin setup
const int SCROLL_PIN   = 2;
const int LED_PIN      = 13;

// analoge pin setup
const int LDR_1_Left   = A0;       // LDR connected to Analog Pin 0 Left
const int LDR_2_Right  = A1;       // LDR connected to Analog Pin 1 Right
const int LDR_3_Down   = A2;       // LDR connected to Analog Pin 2 Down
const int LDR_4_Up     = A3;       // LDR connected to Analog Pin 3 Up
const int TOLERANCEPIN = A4;       // potmeter connection for tolerance value
const int NTCPIN       = A5;       // input pin for NTC

// display pin setup
const int RS_PIN =  12;
const int E_PIN  =  11;
const int D4_pin =  10;
const int D5_PIN =  9;
const int D6_PIN =  8;
const int D7_PIN =  7;

// create display object
LiquidCrystal lcd(RS_PIN, E_PIN, D4_pin, D5_PIN, D6_PIN, D7_PIN);

/**
 *restPosition        both servo's are sent to position 0
 *controlPosition     find the best suncovarage, normal control
 *horizontalPosition  place the pannel horizontal, cleaning / repairs 
 *verticalPosition    defrosting hiding for hale showers
 */

typedef enum Control
{
  restPosition,       
  controlPosition,
  gotoHorizontalPosition,
  gotoVerticalPosition 
}
state;

typedef enum machineStates
{
  SYSTEM_STOP,
  SYSTEM_MANUAL,
  SYSTEM_AUTO,
  SYSTEM_CLEANING,
  SYSTEM_MAINTENANCE,
  SYSTEM_IDLE
}mStates;

