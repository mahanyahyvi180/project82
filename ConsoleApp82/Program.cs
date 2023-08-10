using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp82
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                Console.Write("enter number:");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("enter another number:");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(num1 / num2);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("error");
                Console.ReadLine();
            }
        }
    }
}
