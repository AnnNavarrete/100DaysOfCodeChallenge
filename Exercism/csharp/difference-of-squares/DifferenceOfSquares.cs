using System;

public static class DifferenceOfSquares
{
  public static int CalculateSquareOfSum(int max)
  {
    var sumOfNum = 0d;

    for (var i = 0; i <= max; i++)
    {
      sumOfNum += i;
    }
    return (int)Math.Pow(sumOfNum, 2d);
  }

  public static int CalculateSumOfSquares(int max)
  {
    var sumOfNum = 0;

    for (var i = 0; i <= max; i++)
    {
      sumOfNum += (int)Math.Pow(i, 2d);
    }
    return sumOfNum;
  }

  public static int CalculateDifferenceOfSquares(int max)
  {
    return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
  }
}