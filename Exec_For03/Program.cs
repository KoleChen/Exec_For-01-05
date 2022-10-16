using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For03
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入行數:");
			int num = Convert.ToInt32(Console.ReadLine());
			for (int i = num-1; i >= 0; i--)
			{
				string value1 = new string(' ', i);
				string value2 = new string('*', num - i);
				Console.WriteLine(value1 + value2);
			}
		}
	}
}
