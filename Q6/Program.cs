using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//題目：根據日期, 傳回今天是本月的上旬, 中旬或下旬
			Console.WriteLine("請寫出今天的日期");
			String input = Console.ReadLine();
			DateTime date = Convert.ToDateTime(input);

			int dateDay = date.Day;
			String result = String.Empty;
			if (dateDay <= 10)
			{
				result = "上旬";
			}
			else if (dateDay > 10 && dateDay <= 20)
			{
				result = "中旬";
			}
			else
			{
				result = "下旬";
			}

			Console.WriteLine($"今天是本月的{result}");

		}
	}
}
