using Hw_2.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_2.Menu
{
	internal class DataBaseEntityMenu
	{
		DirectorsCommands directorCommands = new();
		SubMenus subMenus = new SubMenus();
		public void DataBaseComandMenu()
		{
			subMenus.PrintDataBaseMainMenu();
			if (uint.TryParse(Console.ReadLine(), out var num))
			{
				switch (num)
				{
					case 1:
						ReadMenu();
						break;
					case 2:
						CreateMenu();
						break;
					case 3:
						UpdateMenu();
						break;
					case 4:
						DeleteMenu();
						break;
					case 5:
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.WriteLine("Вы вышли из меню работы с БД!");
						return;
					default:
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Число должно быть больше 0, и меньше 4 повторите снова!");
						break;
				}
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Неверное значение, оно обязательно должно являться цифрой от 1 до 4!");
				Console.ForegroundColor = ConsoleColor.White;
			}
		}
		public void CreateMenu()
		{
			while (true)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("Введите имя");
				Console.ForegroundColor = ConsoleColor.White;
				string name = Console.ReadLine();
				Console.WriteLine("Введите Фамилию");
				string surname = Console.ReadLine();
				Console.ForegroundColor = ConsoleColor.White;
				if (name != null && surname != null)
				{
					directorCommands.Create(name, surname);
					subMenus.PrintExtraMenu();
					break;
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("Вы не ввели одно из значеениий");
					Console.ForegroundColor = ConsoleColor.White;
					continue;
				}
			}
			if (int.TryParse(Console.ReadLine(), out var number))
			{
				switch (number)
				{
					case 1:
						CreateMenu();
						break;
					case 2:
						DataBaseComandMenu();
						return;
					default:
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Введеное значение должно быть либо 1 либо 2");
						subMenus.PrintExtraMenu();
						break;
				}

			}
		}
		public void ReadMenu()
		{
			directorCommands.Read();
			subMenus.PrintExtraMenu();
			if (int.TryParse(Console.ReadLine(), out var number))
			{
				switch (number)
				{
					case 1:
						ReadMenu();
						break;
					case 2:
						DataBaseComandMenu();
						return;
					default:
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Введеное значение должно быть либо 1 либо 2");
						subMenus.PrintExtraMenu();
						break;
				}

			}
		}
		public void UpdateMenu()
		{
			string name = "";
			string surname = "";
			while (true)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("Введите id");
				if (Guid.TryParse(Console.ReadLine(), out Guid id))
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("Введите имя");
					Console.ForegroundColor = ConsoleColor.White;
					name = Console.ReadLine();
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("Введите Фамилию");
					surname = Console.ReadLine();
					Console.ForegroundColor = ConsoleColor.White;
					if (name != null && surname != null)
					{
						directorCommands.Update(id, name, surname);
						subMenus.PrintExtraMenu();
						break;
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.WriteLine("Вы не ввели одно из значеениий");
						Console.ForegroundColor = ConsoleColor.White;
						continue;
					}
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Неверный id");
					Console.ForegroundColor = ConsoleColor.Yellow;
					continue;
				}
			}
			if (int.TryParse(Console.ReadLine(), out var number))
			{
				switch (number)
				{
					case 1:
						UpdateMenu();
						break;
					case 2:
						DataBaseComandMenu();
						return;
					default:
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Введеное значение должно быть либо 1 либо 2");
						subMenus.PrintExtraMenu();
						break;
				}

			}
		}
		public void DeleteMenu()
		{
			while (true)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("Введите id");
				if (Guid.TryParse(Console.ReadLine(), out Guid id))
				{
					Console.ForegroundColor = ConsoleColor.White;
					directorCommands.Delete(id);
					subMenus.PrintExtraMenu();
					break;
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Неверный id");
					Console.ForegroundColor = ConsoleColor.Yellow;
					continue;
				}
			}
			if (int.TryParse(Console.ReadLine(), out var number))
			{
				switch (number)
				{
					case 1:
						DeleteMenu();
						break;
					case 2:
						DataBaseComandMenu();
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
