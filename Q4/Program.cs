using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//題目：取得本月最後一天
			//解題：先取得本月，然後取得下個月的第一天-1就是本月的最後一天。
			DateTime today = DateTime.Today;
			int todayMonth = today.Month;
			todayMonth++;
			DateTime nextMonthFirstDay = new DateTime (today.Year, todayMonth, 1);
			nextMonthFirstDay = nextMonthFirstDay.AddDays(-1);
			Console.WriteLine($"本月最後一天 {nextMonthFirstDay:MM-dd}");

		}
	}
}
