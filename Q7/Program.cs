using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//題目：根據不同時間, 傳回不同問安方式 早:0~11 中:12~18 晚:19~23
			String input = String.Empty;
			DateTime date = new DateTime(2022, 1, 1, 19, 3, 3);
			input = Convert.ToString($"{date:HH}");
			int a = Convert.ToInt32(input);

			String result = String.Empty;
			if (a >= 0 && a < 12)
			{
				result = "早安";
			}else if (a >= 12 && a < 19)
			{
				result = "午安";
			}
			else
			{
				result = "晚安";
			}

			Console.WriteLine($"{result}");

		}
	}
}
