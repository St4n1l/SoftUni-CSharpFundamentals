using System;
using System.Linq;
using System.Text;

namespace ExplodingString
{
    class Program
    {
        static void Main(string[] args)
        {
            string explosion = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            int power = 0;
            for (int i = 0; i < explosion.Length; i++)
            {
                if (explosion[i] == '>')
                {
                    power += int.Parse(explosion[i + 1].ToString());
                    result.Append(explosion[i]);
                }
                else if (power == 0)
                {
                    result.Append(explosion[i]);
                }
                else
                {
                    power--;
                }
            }

            Console.WriteLine(result);
        }
    }
}