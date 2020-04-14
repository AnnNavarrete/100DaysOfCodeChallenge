using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class LargestSeriesProduct
{
  public static long GetLargestProduct(string digits, int span)
  {
    if (span < 0)
    {
      throw new ArgumentException(nameof(span));
    }
    var regex = new Regex(@"[^\d]");
    var isInvalid = regex.IsMatch(digits);

    if (isInvalid)
    {
      throw new ArgumentException($"{nameof(digits)}should not include characters");
    }

    var splitDigits = digits.Select(digit => long.Parse(digit.ToString())).ToArray();

    if (span > splitDigits.Length)
    {
      throw new ArgumentException($"{nameof(span)}should not be longer than {nameof(digits)}");
    }

    var pointer = span;

    var largestSum = 0L;

    for (var i = 0; i <= splitDigits.Length - span; i++)
    {
      var end = i + span;
      var take = splitDigits[i..end];
      var sum = take.Aggregate(1L, (totalSum, currentValue) => totalSum * currentValue);

      if (sum > largestSum)
      {
        largestSum = sum;
      }
    }
    return largestSum;
  }
}