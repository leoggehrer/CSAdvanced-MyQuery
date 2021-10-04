using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuery.Logic
{
	public static class ObjectExtensions
	{
		public static void CheckArgument(this object source, string argName)
		{
			if (source == null)
				throw new ArgumentNullException(argName);
		}
	}
}
