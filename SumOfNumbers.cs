using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
	internal class SumOfNumbers
	{
		static void Main(string[] args)
		{
			Random random = new Random();
			int maxValue = 100;
			int divisor1 = 3;
			int divisor2 = 5;
			int number = random.Next(maxValue + 1);
			int sum = 0;
			int startNumber = 3;

			Console.WriteLine(number);

			for (int i = startNumber; i <= number; ++i)
			{
				if (i % divisor1 == 0 || i % divisor2 == 0)
					sum += i;
			}

			Console.WriteLine(sum);
		}
	}
}
