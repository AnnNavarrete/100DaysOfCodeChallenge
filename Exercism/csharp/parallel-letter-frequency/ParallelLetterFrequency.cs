using System;
using System.Collections.Generic;

public static class ParallelLetterFrequency
{
  public static Dictionary<char, int> Calculate(IEnumerable<string> texts)
  {
    var letterFrequency = new Dictionary<char, int>();

    foreach (var str in texts)
    {
      var letters = str.ToLower().ToCharArray();
      foreach (var letter in letters)
      {
        if (!Char.IsLetter(letter))
        {
          continue;
        }
        if (letterFrequency.ContainsKey(letter))
        {
          letterFrequency[letter]++;
        }
        else
        {
          letterFrequency.Add(letter, 1);
        }
      }
    }
    return letterFrequency;
  }
}