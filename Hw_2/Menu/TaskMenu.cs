using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hw_2.Commands;
using Microsoft.VisualBasic;

namespace Hw_2.Menu
{
	internal class TaskMenu
	{
		FubonachiNumber fubonachiNumber = new FubonachiNumber();
		WriteFileStrings writeFileStrings = new WriteFileStrings();
		WriteSiteCode writeSiteCode = new WriteSiteCode();
		public void PrintMainMenu()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("1 - Чтение");
			Console.WriteLine("2 - Запись");
			Console.WriteLine("3 - Вывод числа фибоначи");
			Console.WriteLine("4 - Выход");
			Console.ForegroundColor = ConsoleColor.White;
		}
		public void PrintExtraMenu()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("1 - Выполнить задачу снова");
			Console.WriteLine("2 - Вернуться в главное меню");
			Console.ForegroundColor = ConsoleColor.White;
		}
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
					PrintExtraMenu();
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
					//int.TryParse(Console.ReadLine(), out var number);
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
							PrintExtraMenu();
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
					PrintExtraMenu();
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
						PrintExtraMenu();
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
					PrintExtraMenu();
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
						PrintExtraMenu();
						break;
				}
			}
		}
	}
}
