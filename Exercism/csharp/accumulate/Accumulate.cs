using System;
using System.Collections.Generic;

public static class AccumulateExtensions
{
  // Method name = Accumulate
  // Returns an IEnumerable of type ?
  // Takes two arguements; collection and func
  // Special thing about this method is that it's a static method and first arg uses 'this'
  // which makes Accumulate an extension method that will act upon the collection of IEnum
  public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
  {
    foreach (var item in collection)
    {
      yield return func(item);
    }
  }
}