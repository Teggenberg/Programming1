using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Full Sail!\n\n"); //display message when program starts
            Console.WriteLine("What is your name partner?\n\n"); //requests name from user
            string name = Console.ReadLine(); //allows user to enter their name
            Console.Write("\n\n" + name + "? That's sus bro. Please enter your age in Earth years: "); //repeats user's name back, and requests age on the same line
            string age = Console.ReadLine(); //allows user to input age
            Console.WriteLine("\n\nWell " + name + ", if that is your real name... Congratulations on " + age + " laps around the sun! Whoopty-doo!\n\n"); 
            Console.Write("Press any key to indicate that you are not a robot..."); //added for fun, hoping I don't get points deducted for this
            Console.ReadLine(); //prompts user to press any key
            Console.WriteLine("\n\nAuthentication error...\n\n"); //indicates user may be a robot, added for fun

            Console.ReadKey(); //allows program to end when any key is struck.
        }
    }
}
