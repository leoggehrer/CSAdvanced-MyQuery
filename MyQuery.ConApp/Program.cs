using System;
using MyQuery.Logic;

namespace MyQuery.ConApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Demo MyQuery");

			var intList = new int[] { 1, 2, 3, 4, 5, 6 };
			var strList = intList.Map(i => i.ToString());
			var dblList = intList.Map(i => Convert.ToDouble(i));
		}
	}
}
