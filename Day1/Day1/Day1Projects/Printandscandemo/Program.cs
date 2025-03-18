using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace Printandscandemo
{
   
    
     class Program
    {
        static void Main(string[] args)
        {
          
            int x, y, z;
           
            Console.WriteLine("enter values in x and y ...");
            x =Convert.ToInt32(Console.ReadLine());
            y=int.Parse(Console.ReadLine());
            
            z = x + y;
            Console.WriteLine("The sum of {0} and {1} is {2}", x, y, z);
            Console.WriteLine("The sum of {0,6} and {1,7} is {2,5}", x, y, z);
            Console.WriteLine("The sum of " + x + " and " + y + " is " + z);

            // latest trend or latest syntac which we are following is 

            Console.WriteLine($"The sum of {x}   and {y} is {z}");
            Console.WriteLine("\n printing constants ..");
            Console.WriteLine($"{23.45}");
            Console.WriteLine($"Febuary has either {28} or {29}");
            Console.WriteLine("\n enter values in a single line comma seperated ");
            string input= Console.ReadLine();
            int m, n;
            m = Convert.ToInt32(input.Split(',')[0]);
            n = Convert.ToInt32(input.Split(',')[1]);
            Console.WriteLine($"The sum of {m} and {n} is {m+n}");

            Console.WriteLine("\n enter values in a single line but choose your delimiter ");
            string input2 = Console.ReadLine();
            char[] chars = new char[] { ',', '.', '-', '_', '$',' ' };
            int m1, n1;
            m1 = Convert.ToInt32(input2.Split(chars)[0]);
            n1 = Convert.ToInt32(input2.Split(chars)[1]);
            Console.WriteLine($"The sum of {m1} and {n1} is {m1 + n1}");
            //explore other types also 
            double kk = 123.456;
            decimal ss = 234.567M;//convention u have to follow
            float ff = 234.45F;
            string name = "sudha";

            Console.WriteLine($"{kk}--{ss}--{ff}--{name}");

            // i want to find the range of data types 
            Console.WriteLine($"Integer max value is {int.MaxValue} \n Integer Least value is {int.MinValue}");
            Console.WriteLine($"Byte max value is {byte.MaxValue} \n Byte Least value is {byte.MinValue}");
            Console.ReadLine();


        }
    }
}
