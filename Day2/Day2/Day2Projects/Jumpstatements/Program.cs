using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jumpstatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //withing in the program u want to jump from one section to another section 
            // then go to is used u have to use label: 
            int num;
          L1: Console.WriteLine("\n enter value for num ..");
            num = Convert.ToInt16((Console.ReadLine()));
            if (num == 1)
            {
                goto test1;
            }
            else
            {
                goto L1;
            }
        test1: Console.WriteLine("Its all done..");

           // breakandcontnuebothdemo();
            //  continuedemo();
           
            Console.ReadLine();
        }

        private static void breakandcontnuebothdemo()
        {
            // i want to take values from you means numbers when u give 
            // negative number i will by passs or froget that value and finally 
            // i shoudl print sum of only psoitive values 

            int sum = 0;
            int num;
            do
            {
                Console.WriteLine("Enter the number ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                {
                    continue;
                }
                else
                {
                    sum = sum + num;
                }
                if (num == 0)
                {
                    break;
                }

            } while (true);
            Console.WriteLine($"The sum of only psositive num:{sum}");
        }

        private static void continuedemo()
        {
            // program on continue keyword
            int counter = 0;
            while (counter <= 10)
            {

                counter++;
                if (counter == 5)
                {
                    continue;
                }
                Console.WriteLine($"{counter}");
            }
        }
    }
}
