using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For05
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入一個數字:");
			int num = Convert.ToInt32(Console.ReadLine());
			for (int i = 1; i <= num; i++)
			{
				for (int j = 1; j <= num - i; j++)
				{
					Console.Write("+");
				}

				for (int j = 1; j <= i; j++)
				{
					Console.Write(i);
				}

				Console.WriteLine();
			}
		}
	}
}
