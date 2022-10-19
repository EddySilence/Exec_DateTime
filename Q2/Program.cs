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

			//題目：計算圖書下個月歸還時間
			DateTime brrowDate = new DateTime(2022, 7, 1);
			DateTime remandDate = brrowDate.AddMonths(1);
			Console.WriteLine($"圖書下個月歸還時間 {remandDate:yyyy-MM-dd}");

		}
	}
}
