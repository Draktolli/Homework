namespace Hw_2.Commands;

public class WriteFileStrings
{
    public List<string> WriteFile(int num)
    {
        var strings = File.ReadLines("../../../TextFiles/TextFile1.txt").Take(num).ToList();
        return strings;
    }
}