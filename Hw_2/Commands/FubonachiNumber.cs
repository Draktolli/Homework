namespace Hw_2.Commands;

public class FubonachiNumber
{
    public int Fibonachi(int number)
    {
        if(number < 1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new Exception("Чичло должно быть больше 0");
			Console.ForegroundColor = ConsoleColor.White;
		}
        if (number == 1 || number == 2)
        {
            return 1;
        }
        else
        {
            return Fibonachi(number - 1) + Fibonachi(number - 2);
        }
    }
}