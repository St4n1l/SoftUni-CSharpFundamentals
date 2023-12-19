namespace Orders;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double allOrdersCost = 0;
        for (int i = 0; i < n; i++)
        {
            double priceCapsule = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int capsules = int.Parse(Console.ReadLine());
            double orderPrice = priceCapsule * days * capsules;
            Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
            allOrdersCost += orderPrice;
        }
        Console.WriteLine($"Total: ${allOrdersCost:f2}");
    }
}