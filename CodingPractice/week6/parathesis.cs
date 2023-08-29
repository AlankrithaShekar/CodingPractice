using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.week6
{
    class parathesis
    {
		static long eval(long a, long b, char op)
		{
			if (op == '*')
			{
				return a * b;
			}
			else if (op == '+')
			{
				return a + b;
			}
			else if (op == '-')
			{
				return a - b;
			}
			return 0;
		}
		static long get_maximum_value(string exp)
		{
			int length = exp.Length;
			int numOfnum = (length + 1) / 2;
			var minArray= new long[numOfnum ,numOfnum];
			var maxArray = new long[numOfnum ,numOfnum];
			for (int i = 0; i<numOfnum; i++)
			{
				  minArray[i, i] = long.Parse(exp.Substring(2*i,1));
				  maxArray[i, i] = long.Parse(exp.Substring(2 * i, 1));
			}

			for (int s = 0; s<numOfnum - 1; s++)
			{
				  for (int i = 0; i<numOfnum - s - 1; i++)
				  {
					  int j = i + s + 1;
					  long minVal = long.MaxValue;
					  long maxVal = long.MinValue;
				      
					  for (int k = i; k<j; k++ )
				      {
						  long a = eval(minArray[i,k], minArray[k + 1,j], exp[2 * k + 1]);
						  long b = eval(minArray[i,k], maxArray[k + 1,j], exp[2 * k + 1]);
						  long c = eval(maxArray[i,k], minArray[k + 1,j], exp[2 * k + 1]);
						  long d = eval(maxArray[i,k], maxArray[k + 1,j], exp[2 * k + 1]);
						  minVal = Math.Min(minVal, Math.Min(a, Math.Min(b, Math.Min(c, d))));
						  maxVal = Math.Max(maxVal, Math.Max(a, Math.Max(b, Math.Max(c, d))));
					  }
					  minArray[i,j] = minVal;
					  maxArray[i,j] = maxVal;
				  }
			}
			return maxArray[0,numOfnum - 1];
}
        //static public void Main()
        //{
        //    string expression = Console.ReadLine();
        //    Console.WriteLine(get_maximum_value(expression));
        //}
    }
}
