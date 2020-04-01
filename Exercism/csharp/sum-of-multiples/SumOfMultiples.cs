using System;
using System.Linq;
using System.Collections.Generic;

public static class SumOfMultiples
{
  public static int Sum(IEnumerable<int> multiples, int max)
  {
    var multiplesNum = new List<int>();

    foreach (var num in multiples.Where(oneMultiple => oneMultiple > 0))
    {
      for (var i = 1; i < max; i++)
      {
        if (i % num == 0)
        {
          multiplesNum.Add(i);
        }
      }
    }
    return multiplesNum.Distinct().Sum();
  }
}