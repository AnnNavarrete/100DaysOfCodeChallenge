using System;
using System.Collections.Generic;

[Flags]
public enum Allergen
{
  Eggs = 1,
  Peanuts = 2,
  Shellfish = 4,
  Strawberries = 8,
  Tomatoes = 16,
  Chocolate = 32,
  Pollen = 64,
  Cats = 128
}

public class Allergies
{
  private readonly Allergen _allergies;
  public Allergies(int mask)
  {
    _allergies = (Allergen)mask;
  }

  public bool IsAllergicTo(Allergen allergen)
  {
    return _allergies.HasFlag(allergen);
  }

  public Allergen[] List()
  {
    var allergies = new List<Allergen>();
    foreach (Allergen allergy in Enum.GetValues(typeof(Allergen)))
    {
      if (IsAllergicTo(allergy))
      {
        allergies.Add(allergy);
      }
    }
    return allergies.ToArray();
  }
}