using System;
using System.Linq;
public static class DifferenceOfSquares
{
  public static int CalculateSquareOfSum(int max)
    => (int)Math.Pow(Enumerable.Range(0, max + 1).Sum(), 2d);

  public static int CalculateSumOfSquares(int max)
    => Enumerable.Range(0, max + 1).Sum(i => (int)Math.Pow(i, 2d));

  public static int CalculateDifferenceOfSquares(int max)
    => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}