#include <arduino.h>

// setup values for the Steinman calculations used for the NTC
#define THERMISTORNOMINAL 10000 // resistance at 25 degrees C     
#define TEMPERATURENOMINAL 25   // temp. for nominal resistance (almost always 25 C)
#define NUMSAMPLES 5            // how many samples to take and average
#define BCOEFFICIENT 3950       // The beta coefficient of the thermistor (usually 3000-4000)
#define SERIESRESISTOR 10000    // the value of the 'other' resistor

// setup Values for the ADC / DAC PCF8591P on the I2C
#define PCF8591 (0x90 >> 1)     // PCF8591P I2C bus address
#define ADC0 0x00               // control bytes for reading individual ADCs
#define ADC1 0x01
#define ADC2 0x02
#define ADC3 0x03

const int MAX_VALUE_ADC_PCF8591P = 255; // expander is 8 bit 
const int MAX_VALUE_ADC_ARDUINO =1023;  // arduino is 10 bit


Servo servo_vertical;
Servo servo_horizontal;
const int MIN_VERTICAL = 15;
const int MAX_VERTICAL = 100;
const int MIN_HORIZONTAL = 1;
const int MAX_HORIZONTAL = 179;

// Digital pin setup
const int SCROLL_PIN   = 2;
const int LED_PIN      = 13;

// analoge pin setup
const int LDR_1_Left   = A0;       // LDR connected to Analog Pin 0 Left
const int LDR_2_Right  = A1;       // LDR connected to Analog Pin 1 Right
const int LDR_3_Down   = A2;       // LDR connected to Analog Pin 2 Down
const int LDR_4_Up     = A3;       // LDR connected to Analog Pin 3 Up

// display pin setup
const int RS_PIN =  12;
const int E_PIN  =  11;
const int D4_pin =  10;
const int D5_PIN =  9;
const int D6_PIN =  8;
const int D7_PIN =  7;

// create display object
LiquidCrystal lcd(RS_PIN, E_PIN, D4_pin, D5_PIN, D6_PIN, D7_PIN);

int adcValues0,adcValues1,adcValues2,adcValues3;

