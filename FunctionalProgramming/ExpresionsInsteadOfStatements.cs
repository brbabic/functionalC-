using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
	public class ExpresionsInsteadOfStatements
	{

		public void StartExample ()
		{
			string salutationWithStatement = GetSalutation(2);
			string salutationWithExpresion = GetSalutationWithExpresion(2);
		}
		private string GetSalutation(int hour)
		{
			string salutation; // placeholder
			if (hour < 12)
				salutation = "Good morning";
			else
				salutation = "Good afternoon";
			return salutation; // mutated variable	
		}
		private string GetSalutationWithExpresion(int hour) =>
			hour < 12 ? "Good morning" : "Good afternoon";

		
	}
}
