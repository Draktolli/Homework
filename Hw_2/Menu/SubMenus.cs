
namespace Hw_2.Menu
{
	internal class SubMenus
	{
		public void PrintMainMenu()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("1 - Чтение");
			Console.WriteLine("2 - Запись");
			Console.WriteLine("3 - Вывод числа фибоначи");
			Console.WriteLine("4 - Работа с базой данных");
			Console.WriteLine("5 - Работа с базой данных(Entity Framework)");
			Console.WriteLine("6 - Выход");
			Console.ForegroundColor = ConsoleColor.White;
		}
		public void PrintDataBaseMainMenu()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("1 - Чтение");
			Console.WriteLine("2 - Запись");
			Console.WriteLine("3 - Обновление");
			Console.WriteLine("4 - Удаление");
			Console.WriteLine("5 - Выход");
			Console.ForegroundColor = ConsoleColor.White;
		}
		public void PrintExtraMenu()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("1 - Выполнить задачу снова");
			Console.WriteLine("2 - Вернуться в главное меню");
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
}
