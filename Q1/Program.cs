using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//題目：計算三天後 DVD 應歸還時間
			DateTime brrowDate = new DateTime(2022, 10, 19); //借DVD的時間
			DateTime remandDate = brrowDate.AddDays(3);

			Console.WriteLine($"你的DVD應歸還時間在 {remandDate:yyyy-MM-dd}");

		}
	}
}
