using System;
using System.Collections.Generic;
using System.Linq;

public class Anagram
{
  private readonly string _baseWord;
  public Anagram(string baseWord)
  {
    _baseWord = baseWord;
  }

  public string[] FindAnagrams(string[] potentialMatches) => potentialMatches.Where(WordIsAnagram).ToArray();

  private bool WordIsAnagram(string potentialMatch)
  {
    if (potentialMatch.Length != _baseWord.Length || string.Equals(potentialMatch, _baseWord, StringComparison.OrdinalIgnoreCase))
    {
      return false;
    }

    var lettersRemaining = _baseWord.Select(letter => letter.ToString()).ToList();

    foreach (var letter in potentialMatch)
    {
      if (!lettersRemaining.Contains(letter.ToString(), StringComparer.OrdinalIgnoreCase))
      {
        return false;
      }
      lettersRemaining.Remove(letter.ToString());
    }
    return true;
  }
}