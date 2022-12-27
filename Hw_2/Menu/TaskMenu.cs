using Hw_2.Commands;

namespace Hw_2.Menu
{
	internal class TaskMenu
	{
		FubonachiNumber fubonachiNumber = new FubonachiNumber();
		WriteFileStrings writeFileStrings = new WriteFileStrings();
		WriteSiteCode writeSiteCode = new WriteSiteCode();
		SubMenus subMenus = new SubMenus();
		public void FibonachiNumberMenu()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Введите число");
			while (true)
			{
				if (int.TryParse(Console.ReadLine(), out var stringNumber))
				{
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine(fubonachiNumber.Fibonachi(stringNumber));
					subMenus.PrintExtraMenu();
					break;
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Введите число");
					Console.ForegroundColor = ConsoleColor.White;
					continue;
				}
			}
			if(int.TryParse(Console.ReadLine(), out var number)){
				{
					switch (number)
					{
						case 1:
							FibonachiNumberMenu();
							break;
						case 2:
							return;
						default:
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine("Введеное значение должно быть либо 1 либо 2");
							subMenus.PrintExtraMenu();
							break;
					}
				}

			}

		}

		public void WriteFileStringMenu()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Введите число строк, которые хотите получить");
			while (true)
			{
				if (int.TryParse(Console.ReadLine(), out var stringNumber))
				{
					Console.ForegroundColor = ConsoleColor.White;
					var str = writeFileStrings.WriteFile(stringNumber);
					foreach (string s in str)
					{
						Console.WriteLine(s);
					}
					subMenus.PrintExtraMenu();
					break;
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Введите число");
					Console.ForegroundColor = ConsoleColor.White;
				}
			}
			if(int.TryParse(Console.ReadLine(), out var number))
			{
				switch (number)
				{
					case 1:
						WriteFileStringMenu();
						break;
					case 2:
						return;
					default:
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Введеное значение должно быть либо 1 либо 2");
						subMenus.PrintExtraMenu();
						break;
				}
			}
		}
		public void WriteSideCodeMenu()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Введите адрес сайта, который хотите записать");
			while (true)
			{
				string url = Console.ReadLine();
				if (url != null)
				{
					Console.ForegroundColor = ConsoleColor.White;
					writeSiteCode.GetSiteCode(url);
					subMenus.PrintExtraMenu();
					break;
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Введите ссылку на сайт");
				}
			}
			if (int.TryParse(Console.ReadLine(), out var number))
			{
				switch (number)
				{
					case 1:
						WriteSideCodeMenu();
						break;
					case 2:
						return;
					default:
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Введеное значение должно быть либо 1 либо 2");
						subMenus.PrintExtraMenu();
						break;
				}
			}
		}
	}
}
