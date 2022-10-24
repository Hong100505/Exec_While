using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int MaxNumber = 300;
			int MiniNumber = 1;



			while (MaxNumber >= MiniNumber)
			{
				if (MaxNumber % MiniNumber == 0)
				{
					Console.WriteLine(MiniNumber);

				}
				MiniNumber += 1;
			}
		}
	}
}
