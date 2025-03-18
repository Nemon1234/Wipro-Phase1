using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopsdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // whileloop();
            //  dowhileloop();
            // dowhileloop2();

            //  denomination();

            forloopsdemos();

            Console.ReadLine();


        }

        private static void forloopsdemos()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.Write($"{i}  ");
            }
            Console.WriteLine("\n\nFinding factorial using for loop of a number...");
            float f = 1.0F;
            int number;
            int counter; ;
            Console.WriteLine("\nenter the number to find facorial");
            number = Convert.ToInt32(Console.ReadLine());
            for (counter = 1; counter <= number; counter++)
            {
                f = f * counter;
            }
            Console.WriteLine($"The factorial of {number} is {f}");
        }

        private static void denomination()
        {
            int sum = 0;
            int x = 1;
            int y = 5;
            int z = 10;
            int noofnotes = 0;
            while (sum < 480)
            {
                sum = x + y + z;
                noofnotes = noofnotes + 1;
                x = x + 1;
                y = y + 5;
                z = z + 10;

            }
            Console.WriteLine($"The no of notes : {noofnotes} and total notes {noofnotes * 3}");
        }

        private static void dowhileloop2()
        {
            int counter = 1;
            Console.WriteLine("\n start the counter using do while loop");
            //   int keepgoing = 1;
            do
            {
                Console.Write($"{counter}  ");

                if (counter % 100 == 0 && counter != 0)
                {
                    Console.WriteLine("\n Do you want to continue <y/n>?");
                    if (Console.ReadLine() != "y")
                    {
                        // keepgoing = 0;
                        break;
                    }
                }
                counter++;


            } while (true);
        }

        private static void dowhileloop()
        {
            int counter = 1;// here if i give 120 means condition then also one 
            // time do while will execute which will not happen in while loop
            do
            {
                Console.Write($"{counter}  ");
                counter++;

            } while (counter <= 100);
        }

        private static void  whileloop()
        {
            int counter = 1;

            while (counter <= 100)
            {
                Console.Write($"{counter}  ");
              counter = counter + 1;// if u comment this code ininfite loop
            }
        }
    }
}
