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
				return;
			}

			switch (result)
			{
				case 1:
					Console.WriteLine("for文の動作確認");

					break;
				case 2:
					Console.WriteLine("while文の動作確認");

					break;
				case 3:
					Console.WriteLine("foreach文の動作確認");
					break;
					
				default:
					// case文で指定された数値でなかった場合
					Console.WriteLine("その番号の処理はありません。");
					break;
			}
		}
	}
}
