using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifdemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // simpleif();

            //elseifladder();

            quardrantmethod();

            Console.ReadLine();

        }

        private static void quardrantmethod()
        {
            int x, y;
            Console.WriteLine("Enter x,y co ordinates of the point");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n\nThe point ({x},{y}) lies in : ");
            if (x == 0)
                if (y == 0)
                    Console.WriteLine("on origin");
                else
                    Console.WriteLine("On Y axis ");
            else
                if (y == 0)
                Console.WriteLine("On X axis");
            else
                   if (x > 0)
                if (y > 0)
                    Console.WriteLine("in the first quadrant");
                else
                    Console.WriteLine("in the fourth quadrant");
            else
                      if (y > 0)
                Console.WriteLine("in the second quadrant");
            else
                Console.WriteLine("in the third quadrant");
        }

        private static void elseifladder()
        {
            int a, b, c, d;

            Console.WriteLine("enter values in a,b,c,d");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            // finding largest using ele if ladder 
            if (a > b && a > c && a > d)
                Console.WriteLine("{0} is larger...", a);
            else if (b > c && b > d)
                Console.WriteLine("{0} is larger...", b);
            else if (c > d)
                Console.WriteLine("{0} is larger...", c);
            else
                Console.WriteLine("{0} is larger....", d);
        }

        private static void simpleif()
        {
            // finding largest among 4 numbers using simple if 

            int a, b, c, d, l;

            Console.WriteLine("enter values in a,b,c,d");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            l = a;
            if (b > l)
            {
                l = b;

            }
            if (c > l)
            {
                l = c;
            }
            if (d > l)
            {
                l = d;
            }
            Console.WriteLine($"The laregst is {l}");
        }
    }
}
