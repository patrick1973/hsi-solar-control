
void showLdrValuesLCD()
{
  lcd.clear();
  lcd.print("L: ");
  lcd.print(readLeftLdrValue());
  lcd.setCursor(8,0);
  lcd.print("R: ");
  lcd.print(readRightLdrValue());
  lcd.setCursor(0,1);
  lcd.print("T: ");
  lcd.print(readUpLdrValue());
  lcd.setCursor(8,1);
  lcd.print("B: ");
  lcd.print(readDownLdrValue());
  lcd.setCursor(0,0);
  delay(1000);
}

void showSerovPositionsLCD()
{
  lcd.clear();
  lcd.print("Hor: ");
  lcd.print(checkHorizontalPosition());
  lcd.setCursor(0,1);
  lcd.print("Vert: ");
  lcd.print(checkVerticalPosition());
  lcd.setCursor(0,0);
  delay(100);
}

