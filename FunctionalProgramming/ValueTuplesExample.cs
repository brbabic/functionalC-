using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
	public class ValueTuplesExample
	{
		public void StartExample ()
		{
			string customerNameProvidedByTuple = GetCustomerByTuple(1).Item1;
			string customerNameProvidedByValueTuple = GetCustomer(1).name;
		}
		
		private (string name, string lastName, int age) GetCustomer(int id)
		{
			/// some logic
			return (name: "John", lastName: "Do", age: 55);
		}

		private Tuple<string, string, int> GetCustomerByTuple(int id)
		{
			/// some logic
			return new Tuple<string, string, int>("John", "Do", 55);
		}
		
	}
}
