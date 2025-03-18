using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingandUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //value type is going inside ref type then it is called boxing 
            //while displaying ref type which is storing value type it is called 
            //unboxing 
            // now this process of boxing and unboxing should happen for same type of
            // data types compatibity should match 
            // means int x=45 i cannot put it in string eventhough string is reference type 

            object objone;
            int numberone;
            numberone = 77;
            objone = numberone;//boxing

            Console.WriteLine($"objectone is {objone}");// internally it will unbox means while displaying
                                                        // object will unwrap the data and display which is unboxin we call it as unboxing 

            // doing it with string data type 
            // Boxing: Converting a string value to an object type
            string originalString = "Hello, Boxing and Unboxing!";
            object boxedString = originalString;

            Console.WriteLine($"Boxed string:  {boxedString}");//unboxing

            // here i didnt faced the problem of typecasting above  becasue it is going into base 
            //data type object 
            // below is also doing unboxing but i am going from larger house to smaller house so typecastng
            // needed 
            int unboxint =(int) objone;// unboxing only but using typecasting
            string unboxedString = (string)boxedString;


            Console.WriteLine($"{unboxint}-- {unboxedString}");

            Console.ReadLine();

        }
    }
}
