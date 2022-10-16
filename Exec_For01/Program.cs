using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入三角形行數:");
			int num = Convert.ToInt32(Console.ReadLine());
			for (int i = num; i >= 1; i--)
			{
				string a = new string('*', i);
				Console.WriteLine(a);
			}
		}
	}
}
