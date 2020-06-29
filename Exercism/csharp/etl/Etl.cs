using System;
using System.Collections.Generic;

public static class Etl
{
  public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
  {
    var newDictionary = new Dictionary<string, int>();

    foreach (var pair in old)
    {
      foreach (var item in pair.Value)
      {
        newDictionary.Add(item.ToLower(), pair.Key);
      }
    }
    return newDictionary;
  }
}