using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
	public class FuncsExample
	{
		Func<int, int> addOne = n => n + 1;
		Func<int, int, int> sumTwoNumbers = (x, y) => x + y;
		Func<int, bool> isGreaterThenTwo = n => n >= 2;

		public void StartExample ()
		{
			if (isGreaterThenTwo(addOne(5)))
				Console.WriteLine(sumTwoNumbers(4, 5));

			Console.WriteLine(boolList.Count(x => x == true));
			Console.WriteLine(boolList.Count(valueIsFalse));
		}

		#region Hihger order functions

		Func<bool, bool> valueIsFalse = x => x == false;
		List<bool> boolList = new List<bool>() { true, false, false, true, true };		
		
		#endregion
	}
}
