using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MyQuery.Logic.UnitTest
{
    [TestClass]
	public class IEnumerableExtensionsUnitTest
	{
        /// <summary>
        /// This test checks whether all even numbers are filtered out of a series of numbers from -10 to 10.
        /// </summary>
        [TestMethod]
        public void ValidateEvenFilter_ListOfNumbersFromMinus10To10_ExpectedEvenNumbers()
        {
            var source = new[] { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var expected = new[] { -10, -8, -6, -4, -2, 0, 2, 4, 6, 8, 10 };
            var actual = source.Filter(x => x % 2 == 0);

            CollectionAssert.AreEqual(expected, actual.ToArray(), "The 'Filter' is not working properly.");
        }

        /// <summary>
        /// This test checks whether all add numbers are filtered out of a series of numbers from -10 to 10.
        /// </summary>
        [TestMethod]
        public void ValidateEvenFilter_ListOfNumbersFromMinus10To10_ExpectedOddNumbers()
        {
            var source = new[] { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var expected = new[] { -9, -7, -5, -3, -1, 1, 3, 5, 7, 9 };
            var actual = source.Filter(x => x % 2 != 0);

            CollectionAssert.AreEqual(expected, actual.ToArray(), "The 'Filter' is not working properly.");
        }

        /// <summary>
        /// This test checks whether the int elements of a field are converted into a field with string elements. The elements must contain the same value in both types (1 -> "1").
        /// </summary>
        [TestMethod]
        public void MapIntToString_ListOfIntNumbersFromMinus10To10_ExpectedStringValues()
        {
            var source = new[] { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var expected = new[] { "-10", "-9", "-8", "-7", "-6", "-5", "-4", "-3", "-2", "-1", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            var actual = source.Map(x => x.ToString());

            CollectionAssert.AreEqual(expected, actual.ToArray(), "The 'Map' is not working properly.");
        }

        /// <summary>
        /// This test checks whether the int elements of a field are converted into a field with string elements. The elements must contain the same value in both types (1 -> "1").
        /// </summary>
        [TestMethod]
        public void MapStringToInt_ListOfIntNumbersFromMinus10To10_ExpectedIntValues()
        {
            var source = new[] { "-10", "-9", "-8", "-7", "-6", "-5", "-4", "-3", "-2", "-1", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            var expected = new[] { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var actual = source.Map(x => System.Convert.ToInt32(x));

            CollectionAssert.AreEqual(expected, actual.ToArray(), "The 'Map' is not working properly.");
        }

        /// <summary>
        /// This test checks whether the int elements of a field are converted into a field with string elements. The elements must contain the same value in both types (1 -> "1").
        /// </summary>
        [TestMethod]
        public void ToArray_ListOfIntNumbersFromMinus10To10_ExpectedIntArray()
        {
            IEnumerable<int> source = new[] { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] expected = new[] { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var actual = source.ToArray();

            Assert.AreEqual(expected.GetType(), actual.GetType(), "They are different types");
            CollectionAssert.AreEqual(expected, actual.ToArray(), "The 'ToArray' is not working properly.");
        }

        /// <summary>
        /// This test checks whether the int elements of a field are converted into a field with string elements. The elements must contain the same value in both types (1 -> "1").
        /// </summary>
        [TestMethod]
        public void ToArray_ListOfStringNumbersFromMinus10To10_ExpectedStringArray()
        {
            IEnumerable<string> source = new[] { "-10", "-9", "-8", "-7", "-6", "-5", "-4", "-3", "-2", "-1", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            string[] expected = new[] { "-10", "-9", "-8", "-7", "-6", "-5", "-4", "-3", "-2", "-1", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            var actual = source.ToArray();

            Assert.AreEqual(expected.GetType(), actual.GetType(), "They are different types");
            CollectionAssert.AreEqual(expected, actual.ToArray(), "The 'ToArray' is not working properly.");
        }

        /// <summary>
        /// This test checks whether the int elements of a field are converted into a field with string elements. The elements must contain the same value in both types (1 -> "1").
        /// </summary>
        [TestMethod]
        public void ToList_ListOfIntNumbersFromMinus10To10_ExpectedIntList()
        {
            IEnumerable<int> source = new List<int> { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> expected = new() { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var actual = source.ToList();

            Assert.AreEqual(expected.GetType(), actual.GetType(), "They are different types");
            CollectionAssert.AreEqual(expected, actual.ToArray(), "The 'ToList' is not working properly.");
        }

        /// <summary>
        /// This test checks whether the int elements of a field are converted into a field with string elements. The elements must contain the same value in both types (1 -> "1").
        /// </summary>
        [TestMethod]
        public void ToList_ListOfStringNumbersFromMinus10To10_ExpectedStringList()
        {
            IEnumerable<string> source = new[] { "-10", "-9", "-8", "-7", "-6", "-5", "-4", "-3", "-2", "-1", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            List<string> expected = new() { "-10", "-9", "-8", "-7", "-6", "-5", "-4", "-3", "-2", "-1", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            var actual = source.ToList();

            Assert.AreEqual(expected.GetType(), actual.GetType(), "They are different types");
            CollectionAssert.AreEqual(expected, actual.ToArray(), "The 'ToList' is not working properly.");
        }

        /// <summary>
        /// This test checks the calculation of a sum from a list of numbers.
        /// </summary>
        [TestMethod]
        public void CalculateSum_From1To10_Result55()
        {
            double expected = 55.0;
            var source = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var actual = source.Sum(i => i);

            Assert.AreEqual(expected, actual, "The total must be 55.");
        }

        /// <summary>
        /// This test checks the calculation of a sum from a list of numbers.
        /// </summary>
        [TestMethod]
        public void CalculateSum_FromMinus10To10_Result0()
        {
            double expected = 0.0;
            var source = new double[] { -1, -2, -3, -4, -5, -6, -7, -8, -9, -10, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var actual = source.Sum(i => i);

            Assert.AreEqual(expected, actual, "The total must be 0");
        }

        /// <summary>
        /// This test determines the minimum from a list.
        /// </summary>
        [TestMethod]
        public void FindTheMinimum_From1To10_Result1()
        {
            double expected = 1.0;
            var source = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var actual = source.Min(i => i);

            Assert.AreEqual(expected, actual, "The minimum is 1.0.");
        }

        /// <summary>
        /// This test determines the minimum from a list.
        /// </summary>
        [TestMethod]
        public void FindTheMinimum_FromMinus1To10_ResultMinus1()
        {
            double expected = -1.0;
            var source = new int[] { -1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var actual = source.Min(i => i);

            Assert.AreEqual(expected, actual, "The minimum is -1.0.");
        }

        /// <summary>
        /// This test determines the maximum from a list.
        /// </summary>
        [TestMethod]
        public void FindTheMaximum_From1To10_Result10()
        {
            double expected = 10.0;
            var source = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var actual = source.Max(i => i);

            Assert.AreEqual(expected, actual, "The maximum is 10.0.");
        }

        /// <summary>
        /// This test determines the minimum from a list.
        /// </summary>
        [TestMethod]
        public void FindTheMaximum_FromZeroToMinmus10_ResultZero()
        {
            double expected = 0.0;
            var source = new int[] { 0, -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 };
            var actual = source.Max(i => i);

            Assert.AreEqual(expected, actual, "The minimum is 0.0.");
        }

        /// <summary>
        /// This test checks the calculation of a average from a list of numbers.
        /// </summary>
        [TestMethod]
        public void CalculateAverage_From0To10_Result5()
        {
            double expected = 5.0;
            var source = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var actual = source.Average(i => i);

            Assert.AreEqual(expected, actual, "The average is 5.0.");
        }

        /// <summary>
        /// This test checks the calculation of a average from a list of numbers.
        /// </summary>
        [TestMethod]
        public void CalculateAverage_FromMinus5To5_Result0()
        {
            double expected = 0.0;
            var source = new int[] { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };
            var actual = source.Average(i => i);

            Assert.AreEqual(expected, actual, "The average is 0.0.");
        }

        /// <summary>
        /// This test checks whether an action is called for all elements of a list.
        /// </summary>
        [TestMethod]
        public void ForEach_ForListOfNumbersFromMinus5To5_ShouldBeCalledForEveryone()
        {
            var expected = new List<double> { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };
            var source = new int[] { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };
            var actual = new List<double>();

            source.ForEach(e => actual.Add(e));
            CollectionAssert.AreEqual(expected, actual, "Expected list does not match the current list.");
        }

        /// <summary>
        /// This test checks whether an action is called for all elements of a list.
        /// </summary>
        [TestMethod]
        public void ForEach_ForListOfNumbersFromMinus5To5_ShouldBeCalledForEveryoneWithIndex()
        {
            var expected = new List<double> { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };
            var source = new int[] { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };
            var actual = new List<double>();

            source.ForEach((i, e) => actual.Insert(i, e));
            CollectionAssert.AreEqual(expected, actual, "Expected list does not match the current list.");
        }

        /// <summary>
        /// This test checks the sorting of a collection.
        /// </summary>
        [TestMethod]
        public void Sort_ACollectionOfNumbersFrom5ToMinus5_ShouldSortTheListing()
        {
            var expected = new int[] { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };
            var source = new int[] { 0, 1, 2, 3, 4, 5, -5, -4, -3, -2, -1, };
            var actual = source.SortBy(e => e);

            CollectionAssert.AreEqual(expected, actual.ToArray(), "The two lists are not sorted in the same way.");
        }

        /// <summary>
        /// This test checks the sorting of a collection.
        /// </summary>
        [TestMethod]
        public void Sort_ACollectionOfNumbersFrom0To10_ShouldSortTheListing()
        {
            var expected = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var source = new int[] { 0, 1, 2, 3, 4, 5, 10, 8, 9, 7, 6 };
            var actual = source.SortBy(e => e);

            CollectionAssert.AreEqual(expected, actual.ToArray(), "The two lists are not sorted in the same way.");
        }

        /// <summary>
        /// This test checks the removal of duplicate entries in collections.
        /// </summary>
        [TestMethod]
        public void Distinct_ACollectionOfNumbersFrom0To10_ShouldProvideAListingWithDistinctValues()
        {
            var expected = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var source = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 0, 2, 3, 3, 10 };
            var actual = source.Distinct();

            CollectionAssert.AreEqual(expected, actual.ToArray(), "Not all duplicates have been removed.");
        }

        /// <summary>
        /// This test checks the removal of duplicate entries in collections.
        /// </summary>
        [TestMethod]
        public void Distinct_ACollectionOfNumbersFrom1To2_ShouldProvideAListingWithDistinctValues()
        {
            var expected = new int[] { 1, 2 };
            var source = new int[] { 1, 1, 2, 2, 2, 2 };
            var actual = source.Distinct();

            CollectionAssert.AreEqual(expected, actual.ToArray(), "Not all duplicates have been removed.");
        }
    }
}
