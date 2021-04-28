using System;
using System.Linq;
namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string wd = "racecar";
            if (wd == string.Join("", wd.ToLower().Reverse()))
                Console.WriteLine("True");

            Console.WriteLine($"{string.Join("",wd.ToLower().Reverse())}");
        }
    }
}
