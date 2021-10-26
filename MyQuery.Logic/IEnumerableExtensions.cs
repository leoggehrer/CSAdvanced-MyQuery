using System;
using System.Collections.Generic;

namespace MyQuery.Logic
{
    /// <summary>
    /// The extensions for the IEnumerable <T> type are combined in this extension class.
    /// </summary>
    public static class IEnumerableExtensions
	{
		/// <summary>
		/// Filters a sequence of values based on a predicate.
		/// </summary>
		/// <typeparam name="T">The type of the elements of source.</typeparam>
		/// <param name="source">An IEnumerable from type T to filter.</param>
		/// <param name="predicate"></param>
		/// <returns>A function to test each element for a condition.</returns>
		public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> predicate)
		{
			source.CheckArgument(nameof(source));

			var result = new List<T>();

			foreach (var item in source)
			{
				if (predicate != null && predicate(item))
				{
					result.Add(item);
				}
			}
			return result;
		}
		/// <summary>
		/// Projects each element of a sequence into a new form.
		/// </summary>
		/// <typeparam name="T">The type of the elements of source.</typeparam>
		/// <typeparam name="TResult">The type of the value returned by mapping.</typeparam>
		/// <param name="source">A sequence of values to invoke a transform function on.</param>
		/// <param name="mapping">A transform function to apply to each element.</param>
		/// <returns>An IEnumerable<T> whose elements are the result of invoking the transform function on each element of source.</returns>
		public static IEnumerable<TResult> Map<T, TResult>(this IEnumerable<T> source, Func<T, TResult> mapping)
		{
			source.CheckArgument(nameof(source));

			var result = new List<TResult>();

			foreach (var item in source)
			{
				if (mapping != null)
				{
					result.Add(mapping(item));
				}
			}
			return result;
		}
		/// <summary>
		/// Creates a Array<T> from an IEnumerable<T>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of source.</typeparam>
		/// <param name="source">A sequence to create an array from.</param>
		/// <returns>An array that contains the elements from the input sequence.</returns>
		public static T[] ToArray<T>(this IEnumerable<T> source)
		{
			source.CheckArgument(nameof(source));

			return new List<T>(source).ToArray();
		}
		/// <summary>
		/// Creates a List<T> from an IEnumerable<T>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of source.</typeparam>
		/// <param name="source">A sequence to create a list from.</param>
		/// <returns>A list that contains the elements from the input sequence.</returns>
		public static List<T> ToList<T>(this IEnumerable<T> source)
		{
			source.CheckArgument(nameof(source));

			return new List<T>(source);
		}
		/// <summary>
		/// Returns the number of elements in a sequence.
		/// </summary>
		/// <typeparam name="T">The type of the elements of source.</typeparam>
		/// <param name="source">A sequence that contains elements to be counted.</param>
		/// <returns>The number of elements in the input sequence.</returns>
		public static int Count<T>(this IEnumerable<T> source)
		{
			var result = 0;

			if (source != null)
			{
				foreach (var item in source)
				{
					result++;
				}
			}
			return result;
		}
		/// <summary>
		/// Computes the sum of a sequence of numeric values.
		/// </summary>
		/// <typeparam name="T">The type of the elements of source.</typeparam>
		/// <param name="source"></param>
		/// <param name="selector">A transform function to convert each element to a double.</param>
		/// <returns>The sum of the values in the sequence.</returns>
		public static double Sum<T>(this IEnumerable<T> source, Func<T, double> selector)
		{
			source.CheckArgument(nameof(source));
			selector.CheckArgument(nameof(selector));

			var result = 0.0;

			foreach (var item in source)
			{
				result += selector(item);
			}
			return result;
		}
		/// <summary>
		/// Returns the minimum value in a sequence of values.
		/// </summary>
		/// <typeparam name="T">The type of the elements of source.</typeparam>
		/// <param name="source">A sequence of elements to determine the minimum value of.</param>
		/// <param name="selector">A transform function to convert each element to a double.</param>
		/// <returns>The minimum value in the sequence.</returns>
		public static double? Min<T>(this IEnumerable<T> source, Func<T, double> selector)
		{
			source.CheckArgument(nameof(source));
			selector.CheckArgument(nameof(selector));

			double? result = null;

			foreach (var item in source)
			{
				if (result == null)
					result = selector(item);
				else if (selector(item) < result.Value)
					result = selector(item);
			}
			return result;
		}
		/// <summary>
		/// Returns the maximum value in a sequence of values.
		/// </summary>
		/// <typeparam name="T">The type of the elements of source.</typeparam>
		/// <param name="source">A sequence of elements to determine the maximum value of.</param>
		/// <param name="selector">A transform function to convert each element to a double.</param>
		/// <returns>The maximum value in the sequence.</returns>
		public static double? Max<T>(this IEnumerable<T> source, Func<T, double> selector)
		{
			source.CheckArgument(nameof(source));
			selector.CheckArgument(nameof(selector));

			double? result = null;

			foreach (var item in source)
			{
				if (result == null)
					result = selector(item);
				else if (selector(item) > result.Value)
					result = selector(item);
			}
			return result;
		}
		/// <summary>
		/// Computes the average of a sequence of numeric values.
		/// </summary>
		/// <typeparam name="T">The type of the elements of source.</typeparam>
		/// <param name="source">A sequence of elements to calculate the average of.</param>
		/// <param name="selector">A transform function to convert each element to a double.</param>
		/// <returns>The average value in the sequence.</returns>
		public static double? Average<T>(this IEnumerable<T> source, Func<T, double> selector)
		{
			source.CheckArgument(nameof(source));
			selector.CheckArgument(nameof(selector));

			double? result = null;
			int counter = 0;

			foreach (var item in source)
			{
				counter++;
				if (result == null)
					result = selector(item);
				else
					result += selector(item);
			}
			return counter > 0 ? result / counter : result;
		}
		/// <summary>
		/// Performs the specified action on each element of the IEnumerable<T>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of source.</typeparam>
		/// <param name="source">A sequence of elements to perform the action.</param>
		/// <param name="action">The Action<T> delegate to perform on each element of the IEnumerable<T>.</param>
		/// <returns>The source itself.</returns>
		public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Action<T> action)
		{
			source.CheckArgument(nameof(source));
			action.CheckArgument(nameof(action));

			foreach (var item in source)
			{
				action(item);
			}
			return source;
		}
		/// <summary>
		/// Performs the specified action on each element of the IEnumerable<T>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of source.</typeparam>
		/// <param name="source">A sequence of elements to perform the action.</param>
		/// <param name="action">The Action<T> delegate to perform on each element of the IEnumerable<T>.</param>
		/// <returns>The source itself.</returns>
		public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Action<int, T> action)
		{
			source.CheckArgument(nameof(source));
			action.CheckArgument(nameof(action));

			var idx = 0;

			foreach (var item in source)
			{
				action(idx, item);
				idx++;
			}
			return source;
		}

		private class SortByComparer<T, TKey> : IComparer<T>
			where TKey : IComparable
		{
			private Func<T, TKey> OrderBy { get; }
			public SortByComparer(Func<T, TKey> orderBy)
			{
				orderBy.CheckArgument(nameof(orderBy));

				OrderBy = orderBy;
			}
			public int Compare(T x, T y)
			{
				return OrderBy(x).CompareTo(OrderBy(y));
			}
		}
		/// <summary>
		/// Sorts the elements of a sequence in ascending order.
		/// </summary>
		/// <typeparam name="T">The type of the elements of source.</typeparam>
		/// <typeparam name="TKey">The type of the key returned by orderBy.</typeparam>
		/// <param name="source">A sequence of values to order.</param>
		/// <param name="orderBy">A function to extract a key from an element.</param>
		/// <returns>An IEnumerable<T> whose elements are sorted according to a key.</returns>
		public static IEnumerable<T> SortBy<T, TKey>(this IEnumerable<T> source, Func<T, TKey> orderBy)
			where TKey : IComparable
		{
			source.CheckArgument(nameof(source));
			orderBy.CheckArgument(nameof(orderBy));

			var result = source.ToArray();

			Array.Sort(result, new SortByComparer<T, TKey>(orderBy));
			return result;
		}
		/// <summary>
		/// Returns distinct elements from a sequence.
		/// </summary>
		/// <typeparam name="T">The type of the elements of source.</typeparam>
		/// <param name="source">The sequence to remove duplicate elements from.</param>
		/// <returns>An IEnumerable<T> that contains distinct elements from the source sequence.</returns>
		public static IEnumerable<T> Distinct<T>(this IEnumerable<T> source)
		{
			source.CheckArgument(nameof(source));

			var result = new List<T>();

			foreach (var item in source)
			{
				if (item != null && result.Contains(item) == false)
				{
					result.Add(item);
				}
			}
			return result;
		}
	}
}
