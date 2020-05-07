using System;

namespace MulltiCastDelegateApp
{
	public delegate void ArithemticDelegate (int a, int b);
	
	class MainClass
	{
		public static void Main (string[] args)
		{
			ArithemticDelegate myArithmetic = MathsClass.Multiplication;
			myArithmetic += MathsClass.Addition;

			myArithmetic.Invoke (12, 34);
		}
	}
}
