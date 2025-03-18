using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b, c, choice;
            char ch;
            Console.Clear();
            Console.WriteLine("enter values in a and b...");

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("A.addition....");
                Console.WriteLine("B.substraction...");
                Console.WriteLine("C.Multiplication....");
                Console.WriteLine("D.Division...");
                Console.WriteLine("enter your choice....");
                //   choice = Convert.ToInt32(Console.ReadLine());
                ch = Convert.ToChar(Console.ReadLine());
                switch (ch)
                {
                    case 'A':
                    case 'a':
                        c = a + b;
                        Console.WriteLine($"The sum is {c}");
                        break;
                    case 'B':
                        c = (a > b) ? (a - b) : (b - a);
                        Console.WriteLine($"The subtraction is {c}");
                        break;
                    case 'C':
                        c = a * b;
                        Console.WriteLine($"The prodcut is {c}");
                        break;
                    case 'D':
                        c = a / b;
                        Console.WriteLine($"The division is {c}");
                        break;
                    default:
                        Console.WriteLine("enter values in between 1 and 4 only");
                        break;
                }
                Console.WriteLine("Do you want to continue<y/n>?");
                if(Console.ReadLine()!="y")
                {
                    break;
                }

            } while (true);
            
           
            Console.ReadLine();
        }
    }
}
