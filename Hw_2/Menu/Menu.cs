using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hw_2.Menu
{
	internal class Menu
	{
		TaskMenu taskMenu = new();
		DataBaseMenu dataBaseMenu = new ();
		DataBaseEntityMenu dataBaseEntityMenu = new ();
		SubMenus subMenus = new ();

		public void Start()
		{
			while (true) {
				subMenus.PrintMainMenu();
				if (uint.TryParse(Console.ReadLine(), out var num))
				{
					switch (num)
					{
						case 1:
							taskMenu.WriteFileStringMenu();
							break;
						case 2:
							taskMenu.WriteSideCodeMenu();
							break;
						case 3:
							taskMenu.FibonachiNumberMenu();
							break;
						case 4:
							dataBaseMenu.DataBaseComandMenu();
							break;
						case 5:
							dataBaseEntityMenu.DataBaseComandMenu();
							break;
						case 6:
							Console.ForegroundColor = ConsoleColor.Yellow;
							Console.WriteLine("Вы вышли!");
							Environment.Exit(0);
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
		}
	}
}
