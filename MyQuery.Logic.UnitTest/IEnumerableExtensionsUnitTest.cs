using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using MyQuery.Logic;

namespace MyQuery.Logic.UnitTest
{
	[TestClass]
	public class IEnumerableExtensionsUnitTest
	{
		[TestMethod]
		public void ApplyFilter_EvenNumbersFromList1_10_ShouldResultAllEvenNumbers()
		{
			IEnumerable<int> list = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			IEnumerable<int> expected = new int[] { 2, 4, 6, 8, 10 };
			IEnumerable<int> actual = list.Filter(x => x % 2 == 0);

			CollectionAssert.AreEqual((ICollection)actual, (ICollection)expected);
		}
		[TestMethod]
		[ExpectedException(typeof(System.ArgumentNullException))]
		public void ApplyFilter_PredicateIsNull_ShouldResultArgumentNullException()
		{
			IEnumerable<int> list = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			list.Filter(null);
		}
	}
}
