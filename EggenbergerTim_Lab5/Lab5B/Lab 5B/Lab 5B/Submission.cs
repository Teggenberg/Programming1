using System;
using Tester;

namespace FSPG1
{
    class Submission
    {
        /*
         * This lab is NOT interactive - that means there should be no 
         * calls to the Console class (no Write/WriteLine/ReadLine/ReadKey)
         * 
         * The use of var is not permitted
         * 
        */

        // Test 1 – How many multiples
        // Given three int's, start, end and factor, using a loop, count how 
        // multiples of factor occur between start and end(inclusive)
        
        
        public static int Test1(int start, int end, int factor)
       
        {
            int diff = end - start--;
            int count = 0;
            int factmod = end % factor;

            end -= factmod;

            while(end > start)
            {
                end -= factor;

                count++;


            }
            return count;
        }

        // Test 2 - Factorial
        // Given an int, number, calculate the factorial for number. A factorial 
        // is the result of multiplying all integers between 1 and the target 
        // (number) (so 3 factorial, 3!, is 3 X 2 X 1 = 6)
        public static int Test2(int number)
        {
            int factori1 = number;
            int factori2 = number -1;
            int count = 1;
            while(factori2 > 1)
            {


                factori1 *= factori2;
                factori2--;

                count++;
                
                




            }
            return factori1;
        }

        // Test 3 - Raise to a power
        // Given two int's, root and exponent, use a loop to raise root to 
        // exponent. You are not allowed to use Math.Pow to compute the answer – 
        // you must use a loop. Additionally, exponent will be greater than or 
        // equal to 0 (no negative exponents)
        public static int Test3(int root, int exponent)
        {
            int power = root;
            while (exponent > 1)
            {
                root *= power;
                exponent--;


            }
            
            return root;
        }

        // Test 4 - Consumable
        // Given two doubles (onHand and consume) that represent the amount of 
        // an on-hand resource (onHand) and the amount of the resource that is 
        // consumed per cycles (think a time period). You are to determine how 
        // many cycles (time periods), before the on-hand amount is used up. 
        // For example, if you have 1 gallon of milk (onHand)and use 1 quart 
        // (1/4 gallon) per day (consume), determine when you expect to run out 
        // of milk (4 days).  Return the number representing when the on-hand 
        // amount reaches 0 (or becomes negative)
        // You may find it necessary to use the Round method from the Math class 
        // to avoid floating-point errors. I'd suggest rounding the results of 
        // each computation to 3 decimal places.
        public static int Test4(double onHand, double consume)
        {
            
            int count = 0;
            while(onHand > 0.001)
            {
                Math.Round(onHand, 3);
                Math.Round(consume, 2);
                onHand -= consume;
                
                count++;
                



            }
            return count;
        }

        // Test 5 - Prime number
        // Given an int, number, determine if number is a prime number. Recall 
        // prime numbers are numbers that are divisible on by 1 and themselves. 
        // By definition negative values, 0 and 1 are not prime numbers (2 is 
        // the smallest prime number). If number is prime, return true, 
        // otherwise return false.
        public static bool Test5(int number)
        {
            bool prime = true;


            if (number <= 1)
            {
                prime = false;
               

            }
            else
            {
                for (int i = 2; i < number; i++)
                {



                    if (number % i == 0)
                    {
                        prime = false;
                        break;
                    }
                    else if (number == 2)
                    {
                        prime = true;

                    }




                }

            }

            
            



            return prime;
        }

        // Test 6 - Build a string
        // Given a char, starter, and an int, number, create a string the is made
        // up of starter the next number of characters (in order). For example, 
        // if starter is 'A' and number is 5, the string should be ABCDE (the
        // starting value of A followed by the next 4 letters, in order) 
        public static string Test6(char starter, int number)
        {
           
            int count = 0;
            string newWord = "";
            newWord += starter.ToString();
            char nextChar;

            
            
            nextChar = (char)(((int)starter) + 1);




            while (number > 1)
            {

                

                newWord += nextChar;

                
                nextChar = (char)(((int)nextChar) + 1);

                number--;

            }

            return newWord;
        }

        // Test 7 - Making change
        // Given a double, amount, that represents an amount of US money, 
        // determine the minimum number of coins required to equal that 
        // amount. Use on quarters, dimes, nickels and pennies. There are 
        // two approaches to this problem. The first uses modulo division 
        // and the second uses loops. You are not allowed to solve using
        // modulo division. For example, given 2.63, you would need 10 
        // quarters, 1 dime and 3 pennies, for a total of 14 coins.
        // You will probably find it necessary to use the Round method 
        // from the Math class to avoid floating-point errors. Since you 
        // are dealing with US currency/coins, I'd suggest rounding the 
        // results of each computation to 2 decimal places.
        public static int Test7(double amount)
        {
            double penny = 0.01;
            double nickel = 0.05;
            double dime = 0.10;
            double quarter = 0.25;

            
            int coins = 0;

            while (amount > 0.01)
            {
                Math.Round(amount, 2);
                Math.Round(quarter, 2);
                Math.Round(dime, 2);
                Math.Round(nickel, 2);
                Math.Round(penny, 2);

                amount += .00005;
                
                if (amount >= 0.25)
                {
                    amount -= quarter;
                    Math.Round(amount, 2);
                    coins++;
                }
                else if (amount >= 0.10)
                {
                    amount -= dime;
                    Math.Round(amount, 2);
                    coins++;
                }
                else if (amount >= 0.05)
                {
                    amount -= nickel;
                    Math.Round(amount, 2);
                    coins++;
                }
                else if (amount >= 0.01)
                {
                    amount += .0005;
                    amount -= penny;
                    Math.Round(amount, 2);
                    coins++;
                }
                else
                {
                    amount = 0;
                    
                }

            }

            return coins;
        }

        // Test 8 – Return the multiples
        // Given two int's factor and qty, find the first qty multiples of 
        // factor (including factor as the first multiple) and add each to 
        // a string (separate each multiple with a single space). For 
        // example, given 5 (factor) and 7 (qty), the resulting string 
        // would be 5 10 15 20 25 30 35
        public static string Test8(int factor, int qty)
        {
            string factors = "";
            int count = 1;
            
            

            while (qty > 0)
            {

                factors += factor * count;
                factors += " ";
                count++;
                qty--;
                    
                

            }
            return factors;
        }

        // Test 9 – Sum of values
        // Given two int's start and end, find the sum of all values between 
        // start and end (inclusive). For example, given 11 (start) and 19 
        // (end), the result is 135
        public static int Test9(int start, int end)
        {
            
            int sum = 0;
            int w = start;
            int count = end - w;

            while( count >= 0)
            {
                sum += start;
                start++;
                count--;

            }
            
            return sum;
        }

        // Test 10 – Sum of values
        // Given an instance of the Random class, gener, use it to generate 
        // qty random integers in the range min (inclusive) to max (exclusive).
        // Find the and return the sum of the random numbers you generate. For 
        // example, given gener, 3, 7, 5, you will generate 5 random numbers 
        // between 3 and 7 (actually 3 and 6 because 7 is excluded) and find 
        // the sum of those 5 numbers. Return the sum
        // NOTE: You are given the Random object (gener) so you should not 
        // declare/instantiate another Random object
        public static int Test10(Random gener, int min, int max, int qty)
        {
            
            int rando = 0;

            while (qty > 0)
            {
                rando += gener.Next(min, max );
                /*Console.WriteLine(rando.ToString());*/
                qty--;

            }
            

            return rando;
        }
    }
}
