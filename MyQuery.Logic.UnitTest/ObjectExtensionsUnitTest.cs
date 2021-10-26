using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyQuery.Logic.UnitTest
{
    [TestClass]
	public class ObjectExtensionsUnitTest
	{
		/// <summary>
		/// A zero reference is to be checked in this test. The test method should throw an 'ArgumentNullException' 
		/// in the case of a null reference.
		/// </summary>
		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void CheckArgument_NullReference_ExpectedArgumentNullException()
		{
			string name = null;

			name.CheckArgument(nameof(name));
		}

		/// <summary>
		/// One argument is to be checked in this test. This argument refers to a value and is therefore 
		/// not a null reference. The test method must not be an exception.
		/// </summary>
		[TestMethod]
		public void CheckArgument_StringReference_ExpectedNoneArgumentNullException()
		{
			string name = "Max";

			name.CheckArgument(nameof(name));
		}
		/// <summary>
		/// This test checks whether an 'ArgumentNullException' is thrown in the case of a null reference 
		/// and whether the name of the argument is also contained in the error text.
		/// </summary>
		[TestMethod]
		public void CheckArgument_NullArgumentWithTestName_ExpectedArgumentNullExceptionWithTestName()
		{
			object testName = null;
			string expected = $"Value cannot be null. (Parameter '{nameof(testName)}')";

			try
			{
				testName.CheckArgument(nameof(testName));
				Assert.Fail("The ArgumentNullException is not thrown.");
			}
			catch (ArgumentNullException anex)
			{
				Assert.AreEqual(expected, anex.Message);
			}
		}

		/// <summary>
		/// This test checks whether an 'ArgumentNullException' is thrown in the case of a null reference 
		/// and whether the name of the argument is also contained in the error text.
		/// </summary>
		[TestMethod]
		public void CheckArgument_NullArgumentWithLastName_ExpectedArgumentNullExceptionWithLastName()
		{
			object lastName = null;
			string expected = $"Value cannot be null. (Parameter '{nameof(lastName)}')";

			try
			{
				lastName.CheckArgument(nameof(lastName));
				Assert.Fail("The ArgumentNullException is not thrown.");
			}
			catch (ArgumentNullException anex)
			{
				Assert.AreEqual(expected, anex.Message);
			}
		}
	}
}
