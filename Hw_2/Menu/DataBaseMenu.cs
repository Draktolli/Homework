using Hw_2.DB;

namespace Hw_2.Menu
{
	internal class DataBaseMenu
	{
		DirectorProvider directorProvider = new();
		SubMenus SubMenus = new();
		
		public void DataBaseComandMenu()
		{
			SubMenus.PrintDataBaseMainMenu();
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
					directorProvider.Create(name, surname);
					SubMenus.PrintExtraMenu();
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
						SubMenus.PrintExtraMenu();
						break;
				}

			}
		}
		public void ReadMenu()
		{
			directorProvider.Read();
			SubMenus.PrintExtraMenu();
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
						SubMenus.PrintExtraMenu();
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
						directorProvider.Update(id, name, surname);
						SubMenus.PrintExtraMenu();
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
						SubMenus.PrintExtraMenu();
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
					directorProvider.Delete(id);
					SubMenus.PrintExtraMenu();
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
						SubMenus.PrintExtraMenu();
						break;
				}

			}
		}
	}
}
