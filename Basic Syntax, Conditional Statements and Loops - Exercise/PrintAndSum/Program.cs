namespace PrintAndSum;

class Program
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = first; i <= second; i++)
        {
            Console.Write(i + " ");
            sum += i;
        }
        Console.WriteLine($"\nSum: {sum}");
    }
}