using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            var product = new StringBuilder();
            int num = 0;

            if (number == "0" || multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int sum = int.Parse(number[i].ToString()) * multiplier;
                sum += num;
                if (sum >= 10)
                {
                    product.Append(sum % 10);
                    num = sum / 10;
                    if (i == 0 && num != 0)
                    {
                        product.Append(num);
                    }
                    continue;
                }

                product.Append(sum);
                if (sum <= 10)
                {
                    num = 0;
                }

            }

            var reversedProduct = new StringBuilder();

            for (int i = product.Length - 1; i >= 0; i--)
            {
                reversedProduct.Append(product[i]);
            }

            Console.WriteLine(reversedProduct);
        }
    }
}
