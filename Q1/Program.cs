using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int sum = 0;

			for (int i = 1; i < 150; i++)
			{

				sum += i;


				if (sum > 150)
				{
					Console.WriteLine(i);
					return;
				}
			}
		}
	}
}
