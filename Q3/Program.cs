using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//題目：取得本月一日
			DateTime today = DateTime.Today;
			int todayMonth = today.Month;
			DateTime monthFirstDay = new DateTime(today.Year, todayMonth, 1);
			Console.WriteLine($"本月的第一日是 {monthFirstDay:MM-dd}");

		}
	}
}
