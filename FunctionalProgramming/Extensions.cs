using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
	public static class Extensions
	{
		public static void StartExample ()
		{		
			StringBuilder sb = new StringBuilder()
				.Append("John")
				.AppendWhen("Dr", true)
				.Append("Do");
			
		}
		public static Rectangle GroowFiveCM(this Rectangle rct, bool shouldGroow)
		{
			Rectangle newRct = new Rectangle();
			if (shouldGroow)
			{
				newRct.Height += 5;
				return newRct;
			}
			return rct;
		}
		public static StringBuilder AppendWhen(this StringBuilder sg, string newstring, bool isDoctor) =>
			isDoctor ? sg.Append(newstring) : sg;
		public static string ToUpperCaseA(this string name, bool shouldUpper) =>
			shouldUpper ? name.ToUpper() : name;

		#region Method chaining
		private static string GetHelloWorld(string hello, string world) => new StringBuilder()
			.Append(hello)
			.Append(world)
			.ToString()
			.TrimEnd()
			.ToUpper(); // HELLO WORLD

		#endregion
	}

}
