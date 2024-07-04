using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

public static class AccumulateExtensions
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        foreach (var item in collection)
        {
            yield return func(item);
        }
    }
}