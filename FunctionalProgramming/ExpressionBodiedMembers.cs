using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
	public class ExpressionBodiedMembers
	{
		private string name;

		public ExpressionBodiedMembers(string nm) => name = nm;

		public string Name
		{
			get => name;

			set => name = value;
		}
		public string GetExpBodiedMemberName() => this.name;

		internal void StartExample()
		{
			Console.WriteLine(name);
		}
	}
	
}
