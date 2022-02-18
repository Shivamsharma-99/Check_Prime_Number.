using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Number: ");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("This number is prime no.");
            }
            else
            {
                Console.WriteLine("This number is not prime");
            }
            Console.ReadLine();
        }
    }
}
