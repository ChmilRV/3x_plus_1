using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3x_plus_1
{
	class Program
	{
		static void Main(string[] args)
		{
			int max = 0;
			int maxDig = 0;
			int maxDigStep = 0;
			int maxIterCount = 0;
			int maxDigIter = 0;

			for (int i = 3; i < 10; i++)
			{
				int count = 0;
				int x = i;
				Console.WriteLine($"{count}:\t\t{x}");
				while (x != 1)
				{
					if (x % 2 != 0)
						x = 3 * x + 1;
					else
						x /= 2;
					count++;
					if (count > maxIterCount)
					{
						maxIterCount = count;
						maxDigIter = i;
					}
					if (x > max)
					{
						max = x;
						maxDig = i;
						maxDigStep = count;
					}
					Console.WriteLine($"{count}:\t{x}");
				}
				Console.WriteLine("\n________________________________\n");
			}
			Console.WriteLine($"Max:\t{max}");
			Console.WriteLine($"MaxDig:\t{maxDig}");
			Console.WriteLine($"MaxDigStep:\t{maxDigStep}");
			Console.WriteLine($"MaxIter:\t{maxIterCount}");
			Console.WriteLine($"MaxDigIter:\t{maxDigIter}");
			Console.ReadKey();
		}
	}
}
