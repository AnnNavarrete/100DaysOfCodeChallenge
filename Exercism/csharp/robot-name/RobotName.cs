using System;
using System.Runtime.Caching;

public class Robot
{
  private readonly Random randomNum;

  public Robot()
  {
    randomNum = new Random();
    this.Name = GenerateUniqueName();
  }

  private string GenerateUniqueName()
  {
    var robotNameCache = MemoryCache.Default;

    var nameExist = false;
    var robotName = string.Empty;
    do
    {
      robotName = CreateRobotName();
      nameExist = robotNameCache[robotName] != null;
    } while (nameExist);

    robotNameCache[robotName] = true;
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