using System;

public static class RomanNumeralExtension
{
  public static string ToRoman(this int value)
  {
    if (value < 1) return string.Empty;
    if (value >= 1000) return "M" + ToRoman(value - 1000);
    if (value >= 900) return "CM" + ToRoman(value - 900);
    if (value >= 500) return "D" + ToRoman(value - 500);
    if (value >= 400) return "CD" + ToRoman(value - 400);
    if (value >= 100) return "C" + ToRoman(value - 100);
    if (value >= 90) return "XC" + ToRoman(value - 90);
    if (value >= 50) return "L" + ToRoman(value - 50);
    if (value >= 40) return "XL" + ToRoman(value - 40);
    if (value >= 10) return "X" + ToRoman(value - 10);
    if (value >= 9) return "IX" + ToRoman(value - 9);
    if (value >= 5) return "V" + ToRoman(value - 5);
    if (value >= 4) return "IV" + ToRoman(value - 4);
    if (value >= 1) return "I" + ToRoman(value - 1);

    throw new ArgumentOutOfRangeException("something bad happened");
  }
}