using System;
using System.Linq;

public static class Hamming
{
  private static bool DoCharsMatch(char firstChar, char secondChar) => firstChar == secondChar;
  private static int CountMismatches(bool match) => match ? 0 : 1;

  public static int Distance(string firstStrand, string secondStrand)
  {
    if (firstStrand.Length != secondStrand.Length)
    {
      throw new ArgumentException();
    }

    return firstStrand
          .Zip(secondStrand, DoCharsMatch)
          .Sum(CountMismatches);
  }
}