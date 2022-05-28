using System;
using FSPG;


/////////////////////////////////////////////////////////////////////////////
// TODO:    BEFORE YOU WRITE ANY CODE: 
//          Read the Instructions.pdf file.
//          Run the example.exe to see how this program will behave.
//          Read through all of the TODOs. This will give you an overview
//          of how the program will be put together.

namespace Practice
{
    class Program
    {
        static string[] Greetings = { "Hello there!", "Welcome to the practice!", "Hi, user!",
                                "Hey, I am a program.", "You're running the best program ever!" };

        static void Main(string[] args)
        {
            // TODO: Display a random string from the Greetings array.
            Random random = new Random(); //creat a random object
            int index = random.Next(Greetings.Length); //assign random to Greetings array

            Console.WriteLine(Greetings[index]);


            Console.ReadLine();
            Console.Clear();

            // TODO: Ask the user for a positive number and then print the square of that number.
            //       Make sure your progarm does not crash if the user enters bad input.
            //       Make sure the user can keep entering input until they enter good input.



            bool intProvided = false;
            while (!intProvided)
            {

                Console.WriteLine("Enter a positive number: ");
                string squareit = Console.ReadLine();
                int num;
                bool isInt = int.TryParse(squareit, out num);

                if (isInt && int.Parse(squareit) > 0)
                {
                    Console.WriteLine("\n\n" + squareit + " squared = " + int.Parse(squareit) * int.Parse(squareit));
                    intProvided = true;
                }
                else
                {

                    Console.WriteLine("\n\n\"" + squareit + "\" is an invalid entry.\n\nPlease try agian.\n");



                }

            }

            do
            {
                Console.WriteLine("test");
            }
            while (false);


            
          



            Console.ReadLine();
            Console.Clear();

            // TODO: Create an array of doubles. Use a random number (in the range of 3 to 6) for the size.
            //       For each element of the array, ask the user to enter a value and store
            //       it in the array. The input does not have to be error checked.



            /*Random rndint = new Random();
              int arrayLength = rndint.Next(3, 6);
              double[] Doubles = new double[arrayLength];

              Console.WriteLine("Please populate the array with doubles, we'll need you to choose " + arrayLength + " doubles.");


              while (arrayLength > 0)
              {
                  Console.Write("Please enter a double: ");
                  string d = Console.ReadLine();
                  Doubles[arrayLength - 1] = double.Parse(d);

                  arrayLength--;
              }
*/

            /*double FindAverage()
            {
                double ave = (Doubles[0] + Doubles[1] + Doubles[2] + Doubles[3] + Doubles[4] + Doubles[5]) / arrayLength;



                return ave;
            }*/


            // TODO: Call the FindAverage method passing in the array of doubles and display
            //       the return value to the screen.

            
            


            Console.ReadLine();
        }

        // TODO: Write a method called FindAverage that takes an array of doubles and returns a double
        //       Don't forget to mark the method as static.

        public static double[] CreateDoubleArray()
        {
            Random rndint = new Random();
            int arrayLength = rndint.Next(3, 6);
            double[] Doubles = new double[arrayLength];

            Console.WriteLine("\n\nPlease populate the array with doubles, we'll need you to choose " + arrayLength + " doubles.");


            while (arrayLength > 0)
            {
                Console.Write("\n\nPlease enter a double: ");
                string d = Console.ReadLine();
                Doubles[arrayLength - 1] = double.Parse(d);

                arrayLength--;
            }

            //double ave = (Doubles[0] + Doubles[1] + Doubles[2] + Doubles[3] + Doubles[4] + Doubles[5]) / arrayLength;
            string WriteDBLS = "";
            foreach (var item in Doubles)
            {
                
                WriteDBLS += item.ToString() + ", ";
            }

            Console.WriteLine(WriteDBLS);

            return Doubles;
        }


        static double FindAverage()
        {
            double[] averageJoe = CreateDoubleArray();
            int ajindex = averageJoe.Length;
            double ave = 0.0;
            
            while (ajindex > 0) 
            {

                ave += averageJoe[ajindex - 1]; 




                ajindex--;
            }

            ave = ave / averageJoe.Length;

            Console.Write("\n\nThe average of your selections = " + ave);

            return ave;
        }




        // TODO: In the FindAverage method compute the average (the sum of all values divided by the number of values)
        //       of the values in the array parameter and return it.

    }
}
using System;
using FSPG;


/////////////////////////////////////////////////////////////////////////////
// TODO:    BEFORE YOU WRITE ANY CODE: 
//          Read the Instructions.pdf file.
//          Run the example.exe to see how this program will behave.
//          Read through all of the TODOs. This will give you an overview
//          of how the program will be put together.

namespace Practice
{
    class Program
    {
        static string[] Greetings = { "Hello there!", "Welcome to the practice!", "Hi, user!",
                                "Hey, I am a program.", "You're running the best program ever!" };

        static void Main(string[] args)
        {
            // TODO: Display a random string from the Greetings array.
            Random random = new Random(); //creat a random object
            int index = random.Next(Greetings.Length); //assign random to Greetings array

            Console.WriteLine(Greetings[index]);


            Console.ReadLine();
            Console.Clear();

            // TODO: Ask the user for a positive number and then print the square of that number.
            //       Make sure your progarm does not crash if the user enters bad input.
            //       Make sure the user can keep entering input until they enter good input.



            bool intProvided = false;
            while (!intProvided)
            {

                Console.WriteLine("Enter a positive number: ");
                string squareit = Console.ReadLine();
                int num;
                bool isInt = int.TryParse(squareit, out num);

                if (isInt && int.Parse(squareit) > 0)
                {
                    Console.WriteLine("\n\n" + squareit + " squared = " + int.Parse(squareit) * int.Parse(squareit));
                    intProvided = true;
                }
                else
                {

                    Console.WriteLine("\n\n\"" + squareit + "\" is an invalid entry.\n\nPlease try agian.\n");



                }

            }

            FindAverage();
            



            Console.ReadLine();
            Console.Clear();

            // TODO: Create an array of doubles. Use a random number (in the range of 3 to 6) for the size.
            //       For each element of the array, ask the user to enter a value and store
            //       it in the array. The input does not have to be error checked.



            /*Random rndint = new Random();
              int arrayLength = rndint.Next(3, 6);
              double[] Doubles = new double[arrayLength];

              Console.WriteLine("Please populate the array with doubles, we'll need you to choose " + arrayLength + " doubles.");


              while (arrayLength > 0)
              {
                  Console.Write("Please enter a double: ");
                  string d = Console.ReadLine();
                  Doubles[arrayLength - 1] = double.Parse(d);

                  arrayLength--;
              }
*/

            /*double FindAverage()
            {
                double ave = (Doubles[0] + Doubles[1] + Doubles[2] + Doubles[3] + Doubles[4] + Doubles[5]) / arrayLength;



                return ave;
            }*/


            // TODO: Call the FindAverage method passing in the array of doubles and display
            //       the return value to the screen.

            CreateDoubleArray();
            


            Console.ReadLine();
        }

        // TODO: Write a method called FindAverage that takes an array of doubles and returns a double
        //       Don't forget to mark the method as static.

        public static double[] CreateDoubleArray()
        {
            Random rndint = new Random();
            int arrayLength = rndint.Next(3, 6);
            double[] Doubles = new double[arrayLength];

            Console.WriteLine("\n\nPlease populate the array with doubles, we'll need you to choose " + arrayLength + " doubles.");


            while (arrayLength > 0)
            {
                Console.Write("\n\nPlease enter a double: ");
                string d = Console.ReadLine();
                Doubles[arrayLength - 1] = double.Parse(d);

                arrayLength--;
            }

            //double ave = (Doubles[0] + Doubles[1] + Doubles[2] + Doubles[3] + Doubles[4] + Doubles[5]) / arrayLength;
            string WriteDBLS = "";
            foreach (var item in Doubles)
            {
                
                WriteDBLS += item.ToString() + ", ";
            }

            Console.WriteLine(WriteDBLS);

            return Doubles;
        }


        static double FindAverage()
        {
            double[] averageJoe = CreateDoubleArray();
            int ajindex = averageJoe.Length;
            double ave = 0.0;
            
            while (ajindex > 0) 
            {

                ave += averageJoe[ajindex - 1]; 




                ajindex--;
            }

            ave = ave / averageJoe.Length;

            Console.Write("\n\nThe average of your selections = " + ave);

            return ave;
        }




        // TODO: In the FindAverage method compute the average (the sum of all values divided by the number of values)
        //       of the values in the array parameter and return it.

    }
}
