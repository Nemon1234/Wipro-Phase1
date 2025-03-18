using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //What are Nullable Types?
            //In C#, value types (like int, double, bool, etc.) cannot be
            //null by default. However, you can use Nullable<T> or the shorthand T?
            //to allow value types to store null

            //  int number = null;// not allowing ..as it is not possible 

            // Nullable integer
            int? number = null;

            // Nullable boolean
            bool? isAvailable = null;

            // Nullable double
            double? price = 99.99;// here i can put null also and also number optional

            // Checking if value exists
            if (number.HasValue)
            {
                Console.WriteLine("Number: " + number.Value);
            }
            else
            {
                Console.WriteLine("Number is null.");
            }

            Console.WriteLine("Another way of declaring nullable types ..");
            // Using Nullable<T>
            Nullable<int> number1 = null;

            // Alternative shorthand syntax (equivalent to Nullable<int>)
            int? anotherNumber = 20;

            // Checking if value exists
            if (number1.HasValue)
            {
                Console.WriteLine("Number: " + number1.Value);
            }
            else
            {
                Console.WriteLine("Number1 is null.");
            }

            Console.WriteLine("Another Number: " + anotherNumber);

            // Using GetValueOrDefault()
            Console.WriteLine($"Number (default 100 if null):  {number1.GetValueOrDefault(100)}");
            Console.ReadLine();

        }
    }
}
