using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
	public class YieldExamle
	{
		
		private IEnumerable<bool> GetFalseValues(List<bool> booleanList)
		{
			List<bool> tmpListOfFalse = new List<bool>();
			foreach (var bl in booleanList)
			{
				if (bl == false) tmpListOfFalse.Add(bl);
			}
			return tmpListOfFalse;

		}
		private IEnumerable<bool> GetFalseValuesUsingYield(List<bool> booleanList)
		{
			foreach (var bl in booleanList)
			{
				if (bl == false) yield return bl;
			}
		}

		public void StartExample()
		{
			List<bool> boolList = new List<bool>() { true, true, false, true, false, false, true };

			IEnumerable<bool> withoutYield = GetFalseValues(boolList);
			IEnumerable<bool> withYield = GetFalseValuesUsingYield(boolList);
		}

	}
}
