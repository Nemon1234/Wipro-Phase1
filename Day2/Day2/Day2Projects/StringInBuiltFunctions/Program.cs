using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInBuiltFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //String s1;
            //string s2;
            // here if i say s1. same methods i will se what i will see in s2. 
            // also if i say String. or string. same methods are there so both are same only 
            // dont get confuse ...so strings are referecne type only ...

            // how string we will learn later now let us see just some in built functions of 
            // string ..
            // one slide is stringlist there all methods and properties of strings are there 
            // which i will implent now 
            string str = "    Hello World      ";
            string str2 = "Hello";
            string str3 = "world";
            //properties and fields

            string sample = "";
            string sample2=string.Empty;// like this also i can use 

            //chars proeprty means index prerties in each string or any string i want to 
            // know in this position which character is there then i will use chars means 
            // i will not write chars using [] this thing is chars only 
            Console.WriteLine($"chars means : 6th chacatr in str:{str[6]}--first character in str2:{str2[0]}");
            Console.WriteLine($"Length :{str.Length}");

            // Modifying
            Console.WriteLine("\nModifying:");
            Console.WriteLine($"Insert: {str.Insert(6,"Beautiful ")}");
            Console.WriteLine($"Remove: {str.Remove(7,4)}");
            Console.WriteLine($"Replace: {str.Replace("World", "C#")}");
            Console.WriteLine($"Trim: '{str.Trim()}'");
            Console.WriteLine($"TrimStart: '{str.TrimStart()}'");
            Console.WriteLine($"TrimEnd: '{str.TrimEnd()}'");
            Console.WriteLine($"PadLeft: '{str2.PadLeft(15, '*')}'");
            Console.WriteLine($"PadRight: '{str2.PadRight(10, '-')}'");
            Console.WriteLine($"ToUpper: {str3.ToUpper()}");
            Console.WriteLine($"ToLower: {str2.ToLower()}");

            // extracting 
            Console.WriteLine("\n Extracting ...");
            string name = "Raghavendra";
            string name2 = "raghavendra kumar singh";
            Console.WriteLine($"Subsstring :{name.Substring(0,6)}");
            Console.WriteLine($"split :{string.Join(",", name2.Split(' '))}");
            Console.WriteLine($"Fullname : {string.Join("-", "ravi", "kumar")}");

            // Formatting
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("\nFormatting:");
            double number = 12345.6789;
            Console.WriteLine($"just tostring will convert it into string : {number.ToString()}");//just string 
            Console.WriteLine($"US Currency: {number.ToString("C", new CultureInfo("en-US"))}");
            Console.WriteLine($"Indian Currency: {number.ToString("C", new CultureInfo("en-IN"))}");
            Console.WriteLine($"Euro Currency: {number.ToString("C", new CultureInfo("fr-FR"))}");

            Console.WriteLine($"Exponential: {number.ToString("E")}");
            Console.WriteLine($"General: {number.ToString("G")}");
            Console.WriteLine($"Percentage: {number.ToString("P")}");
            DateTime date = DateTime.Now;
            Console.WriteLine($"Short Date: {date.ToString("d")}");
            Console.WriteLine($"Long Date: {date.ToString("D")}");
            Console.WriteLine($"Short Time: {date.ToString("t")}");
            Console.WriteLine($"Long Time: {date.ToString("T")}");

            // Searching
            Console.WriteLine("\nSearching:");
            string samplename = "Kiran Hello!";
            Console.WriteLine($"StartsWith 'K': {samplename.StartsWith("K")}");
            Console.WriteLine($"EndsWith '!': {samplename.EndsWith("!")}");
            Console.WriteLine($"IndexOf 'Hello': {samplename.IndexOf("Hello")}");
            Console.WriteLine($"Contains 'ran': {samplename.Contains("ran")}");

            // comparing 

            Console.WriteLine("\n Comparing");
            string ss1 = "daghu";
            string ss2 = "raghu";

            string kk = "solve";
            string kk2 = "solve";
            Console.WriteLine($"compare :{string.Compare(ss1, ss2)}");   //<0 means ss1 is smaller than ss2 
            Console.WriteLine($"compare :{string.Compare(ss2, ss1)}");// > 0 means ss2 is largrr comes after ss1 
            Console.WriteLine($"compare :{ss1.CompareTo(ss2)}");   //<0 means ss1 is smaller than ss2 
           
            Console.WriteLine($"Equals :{kk.Equals(kk2)}");//checks the content inside string 
           
            Console.ReadLine();
            
        }
    }
}
