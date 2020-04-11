using System;

public class Robot
{
  public Robot()
  {
    GenerateName();
  }

  private void GenerateName()
  {
    var randomNum = new Random();
    var firstChar = (char)randomNum.Next(65, 90);
    var secondChar = (char)randomNum.Next(65, 90);
    Name = $"{firstChar}{secondChar}{randomNum.Next(100, 999)}";
  }

  public string Name { get; private set; }

  public void Reset()
  {
    GenerateName();
  }
}