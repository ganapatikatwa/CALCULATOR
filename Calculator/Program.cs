using System;
namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int firstnum= Convert.ToInt32(Console.ReadLine()); //Explicit Convertion

            Console.WriteLine("Enter Second Number");
            int secondnum = Convert.ToInt32(Console.ReadLine()); //Explicit Convertion

            int result= firstnum + secondnum;
            Console.WriteLine("Addition of"+firstnum+"and"+secondnum+"is"+result); // using cancating
            Console.WriteLine("Addition of {0} and {1} is {2}" , firstnum, secondnum,result);// using place holders
        }
    }
}