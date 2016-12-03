using System;

namespace xr1_5
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// 選択ステートメント
			Console.WriteLine("数字を入力してください。");
			string valueStr = Console.ReadLine();
			int result;
			if (int.TryParse(valueStr, out result))
			{
				Console.WriteLine("入力された値は数字でした。: {0}", result);
			}
			else {
				Console.WriteLine("入力あれた値は数字ではりませんでした。:{0}", result);
			}


		}
	}
}
