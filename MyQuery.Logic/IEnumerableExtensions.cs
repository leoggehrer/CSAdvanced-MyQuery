using System;
using System.Collections.Generic;

namespace MyQuery.Logic
{
	public static class IEnumerableExtensions
	{
		public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Predicate<T> predicate)
		{
			source.CheckArgument(nameof(source));
			predicate.CheckArgument(nameof(predicate));

			var result = new List<T>();

			foreach (var item in source)
			{
				if (predicate(item))
					result.Add(item);
			}
			return result;
		}
		public static IEnumerable<TResult> Map<T, TResult>(this IEnumerable<T> source, Func<T, TResult> mapping)
		{
			source.CheckArgument(nameof(source));
			mapping.CheckArgument(nameof(mapping));

			var result = new List<TResult>();

			foreach (var item in source)
			{
				result.Add(mapping(item));
			}
			return result;
		}

	}
}
