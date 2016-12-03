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

			Console.WriteLine("nを入力してください。");
			string nStr = Console.ReadLine();
			int nValue;
			if (!int.TryParse(nStr, out nValue))
			{
				Console.WriteLine("数値ではありません");
				return;
			}
			int answer = 0;

			switch (result)
			{
				case 1:
					Console.WriteLine("総和の算出：for文の動作確認");
					for (int i = 1; i <= nValue; i++)
					{
						answer += i;
					}
					break;
					
				case 2:
					Console.WriteLine("階乗の算出：while文の動作確認");
					int j = nValue;
					answer = j;
					while (j > 1)
					{
						j--;
						answer *= j;
					}
					break;
					
				case 3:
					Console.WriteLine("foreach文の動作確認");
					break;
					
				default:
					// case文で指定された数値でなかった場合
					Console.WriteLine("その番号の処理はありません。");
					break;
			}
			Console.WriteLine("結果は {0} です。", answer);

		}
	}
}
