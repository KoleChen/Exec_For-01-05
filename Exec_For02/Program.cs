using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入三角形行數:");
			int num = Convert.ToInt32(Console.ReadLine());
			for (int i = 1; i <= num; i++)
			{
				for (int a = 1; a <= num - i; a++)
				{
					Console.Write(" ");
				}
				for (int b = 1; b < 2 * i; b++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
}
