using System;
using System.Collections.Generic;

public class Robot
{
  private readonly Random randomNum;
  private readonly HashSet<string> currentRobotNames = new HashSet<string>();

  public Robot()
  {
    randomNum = new Random();
    this.Name = GenerateUniqueName();
  }

  private string GenerateUniqueName()
  {
    var robotName = string.Empty;
    do
    {
      robotName = CreateRobotName();
    } while (currentRobotNames.Contains(robotName));

    currentRobotNames.Add(robotName);
    return robotName;
  }

  private string CreateRobotName()
  {
    var firstChar = (char)randomNum.Next(65, 90);
    var secondChar = (char)randomNum.Next(65, 90);
    return $"{firstChar}{secondChar}{randomNum.Next(100, 999)}";
  }

  public string Name { get; private set; }

  public void Reset()
  {
    this.Name = GenerateUniqueName();
  }
}