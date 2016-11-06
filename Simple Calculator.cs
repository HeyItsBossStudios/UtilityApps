//This example was made in SoloLearn C#. you can copy paste this code to add on.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			
			string val1 = Console.ReadLine();
			string val2 = Console.ReadLine();
			string val3 = Console.ReadLine();
			
			double num1 = Convert.ToDouble(val1);
			double num2 = Convert.ToDouble(val2);
			
			if (val3 == "Add")
			{
				double answer = num1 + num2;
				string output = Convert.ToString(answer);
				Console.WriteLine(output);
			}
			
			if (val3 == "Sub")
			{
				double answer = num1 - num2;
				string output = Convert.ToString(answer);
				Console.WriteLine(output);
			}
			
			if (val3 == "Mult")
			{
				double answer = num1 * num2;
				string output = Convert.ToString(answer);
				Console.WriteLine(output);
			}
			
			if (val3 == "Div")
			{
				double answer = num1 / num2;
				string output = Convert.ToString(answer);
				Console.WriteLine(output);
			}
		}
	}
}
