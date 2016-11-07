//You can Copy Paste this code to add on to it.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Caculator
{
	class Program
	{
	
		static void Main(string[] args)
		{
	    const int avg = 4;
	    
	    string Var = Console.ReadLine();
			double num1 = Convert.ToDouble(Var);
			
			string Var2 = Console.ReadLine();
			double num2 = Convert.ToDouble(Var2);
			
			string Var3 = Console.ReadLine();
			double num3 = Convert.ToDouble(Var3);
			
			string Var4 = Console.ReadLine();
			double num4 = Convert.ToDouble(Var4);
			
			double Answer = (num1 + num2 + num3 + num4) / avg;
			string output = Convert.ToString(Answer);
			Console.WriteLine("The average of " + num1 + " , " + num2 + " , " + num3 + " and " + num4 + " is " + output);
			
		}
	}
}
