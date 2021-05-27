using System;
using System.Linq;
using System.Reflection;
// #error version
namespace HelloCS
{
    class Program
    {
        static void Main(string[] args)
        {
            double heightInMetres = 1.88;
            Console.WriteLine($"The variable {nameof(heightInMetres)} has the value {heightInMetres}.");
           
            Console.WriteLine("Hello, C#!");
        }
    }
}
