using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello Full Sail!";
            Console.WriteLine(hello + "\n");
            Console.WriteLine("\nWhat is your name?\n");
            string name = Console.ReadLine();
            Console.WriteLine("\nHow old are you?\n");
            string age = Console.ReadLine();
            Console.WriteLine("\nHello " + name + "!\n\nCongratultions for  " + age + " trips around the solar unit!\n");
            Console.ReadKey();
            

        }
    }
}
