using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//題目：列出指定年份的每一個星期日
			//解題：先找出第一個星期日，之後一直+7
			Console.WriteLine("輸入年分 ");
			String year = Console.ReadLine();//今年
			DateTime Date = new DateTime(Convert.ToInt32(year), 1, 1);

			//今年最後一天
			DateTime lastMonthDate = Date.AddYears(1);
			lastMonthDate = lastMonthDate.AddDays(-1);

			DayOfWeek DateWeek = Date.DayOfWeek;
			int IntWeek = (int)DateWeek;
			while (IntWeek != 0)
			{
				Date = Date.AddDays(1);
				DateWeek = Date.DayOfWeek;
				IntWeek = (int)DateWeek;
			}

			Console.WriteLine($"年分{Date:yyyy}的每個星期天是以下日期");
			for (DateTime i = Date; i <= lastMonthDate; i = i.AddDays(7))
			{
				Console.WriteLine($"{i:MM-dd}");
			}


		}
	}
}
