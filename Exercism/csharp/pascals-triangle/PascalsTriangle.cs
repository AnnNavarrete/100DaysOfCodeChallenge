using System;
using System.Collections.Generic;

public static class PascalsTriangle
{
  public static IEnumerable<IEnumerable<int>> Calculate(int rows)
  {
    var column = new int[rows][];

    for (var rowPosition = 0; rowPosition < rows; rowPosition++)
    {
      var numOfColumn = 1 + rowPosition;
      var row = new int[numOfColumn];

      for (var columnPosition = 0; columnPosition < numOfColumn; columnPosition++)
      {
        if (columnPosition == 0 || columnPosition == numOfColumn - 1)
        {
          row[columnPosition] = 1;
          continue;
        }
        var previousRow = column[rowPosition - 1];
        var leftPreviousRow = previousRow[columnPosition - 1];
        var rightPreviousRow = previousRow[columnPosition];
        var sum = leftPreviousRow + rightPreviousRow;
        row[columnPosition] = sum;
      }
      column[rowPosition] = row;

    }
    return column;
  }
}