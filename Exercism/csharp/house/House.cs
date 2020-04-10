using System;
using System.Collections.Generic;

public static class House
{
  private static string Recite(int verseNumber, string verse)
  {
    if (verseNumber == 0)
    {
      return verse;
    }

    var rhyme = new Dictionary<int, string>()
        {
            {1, "house that Jack built."},
            {2, "malt that lay in"},
            {3, "rat that ate"},
            {4, "cat that killed"},
            {5, "dog that worried"},
            {6, "cow with the crumpled horn that tossed"},
            {7, "maiden all forlorn that milked"},
            {8, "man all tattered and torn that kissed"},
            {9, "priest all shaven and shorn that married"},
            {10, "rooster that crowed in the morn that woke"},
            {11, "farmer sowing his corn that kept"},
            {12, "horse and the hound and the horn that belonged to"},
        };

    return Recite(verseNumber - 1, $"{verse} the {rhyme[verseNumber]}");
  }

  public static string Recite(int verseNumber) => Recite(verseNumber, "This is");

  public static string Recite(int startVerse, int endVerse)
  {
    var verses = new List<string>();

    for (var verseNumber = startVerse; verseNumber <= endVerse; verseNumber++)
    {
      verses.Add(Recite(verseNumber));
    }
    return string.Join("\n", verses);
  }
}