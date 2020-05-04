using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
	class Program
	{
		static void Main(string[] args)
		{
			YieldExamle yieldExample = new YieldExamle();
			ValueTuplesExample valueTupleExample = new ValueTuplesExample();
			ExpresionsInsteadOfStatements expresionExample = new ExpresionsInsteadOfStatements();
			FuncsExample funcsExample = new FuncsExample();
			ExpressionBodiedMembers expBodMembers = new ExpressionBodiedMembers("name");
			ImmutableExample immutableExample = new ImmutableExample();

			funcsExample.StartExample();
			yieldExample.StartExample();
			valueTupleExample.StartExample();
			expresionExample.StartExample();
			expBodMembers.StartExample();
			immutableExample.StartExample();
			Extensions.StartExample();

			
		}		
	}
}
