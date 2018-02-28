using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_JakeStadalsky
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dAmount1;
            decimal dAmount2;
           
            decimal dSum;

            Console.WriteLine("Enter the amount for the first number:");
            dAmount1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the amount for the second number:");
            dAmount2 = decimal.Parse(Console.ReadLine());



            dSum = dAmount1 + dAmount2;

            Console.WriteLine("The result is {0:}", dSum);
            Console.ReadKey(true);

            {



                int x;
                int y;
                int z;
                int sum1;
                int sum2;
                int product;


                x = 2;
                y = 4;
                z = 6;
                sum1 = x + y;
                sum2 = z + 10;
                product = sum1 * sum2;

                Console.WriteLine(product);
                Console.ReadLine();
            }
            {
                Console.WriteLine("Hello\tWorld!");
                Console.WriteLine("Hello\nWorld!");
                Console.WriteLine("\"Hello World!\"");
                Console.WriteLine("Hello\\World!");
                Console.ReadLine();
            }
        }

    }
}
