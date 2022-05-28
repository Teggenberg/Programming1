using System;
using System.Diagnostics.Contracts;
using Tester;

namespace FSPG1
{
    class Submission
    {
        /*
         * This lab is NOT interactive - that means there should be no 
         * calls to the Console class (no Write/WriteLine/ReadLine/ReadKey)
         * 
         * You cannot use multiple return statements any of these methods. 
         * Additionally the use of var is not permitted
         * 
        */

        // Test 1 – Convert char array to int array
        // Given an array of char, phrase, convert each element to an
        // equivalent int value and place in an int array.
        // Return the int array
        public static int[] Test1(char[] phrase)
        {
            int[] result = new int[phrase.Length];

            for (int i = 0; i < phrase.Length; i++)
            {
                result[i] = phrase[i];
            }

            return result;
        }

        // Test 2 - Array statistics
        // Given an array of double, data, find the smallest element, 
        // the largest element and the numeric mean (average). Store the 
        // results in an array (in that order: smallest, largest, mean).
        // Return the array
        public static double[] Test2(double[] data)
        {
            double[] result = new double[3];

            result[0] = data[0];
            result[1] = data[0];
            double total = 0;

            for (int i = 0; i < data.Length; i++)
            {
                total += data[i];
               
                if(data[i] < result[0])
                {
                    result[0] = data[i];
                }

                if(data[i] > result[1])
                {
                    result[1] = data[i];
                }
            }

            result[2] = total / data.Length;
            
           

            return result;
        }

        // Test 3 - Normalize an array (of double)
        // Given an array of double, numbers, normalize the array. To 
        // normalize an array:
        // 1) Find the largest element stored in the array
        // 2) Divide each element in the array by the largest value
        //    and replace each array element with the result of the 
        //    division.
        // Since the array's contents are being modified, there is 
        // nothing to return
        public static void Test3(double[] numbers)
        {
            double biggest = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > biggest)
                {
                    biggest = numbers[i];
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] /= biggest;
            }



        }

        // Test 4 - Uniqueness
        // Given an array of string, names, verify that each name is unique
        // mean that none of the names are duplicated within the array.
        // If the array is unique, return true; otherwise, return false
        public static bool Test4(string [] names)
        {
            bool unique = true;
            

            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < names.Length; j++)
                {
                    if ((names[i] == names[j]) && (i != j))
                    {
                        unique = false;
                        break;
                    }
                }
            }
            return unique;
        }

        // Test 5 - Acronym
        // Given an array of string, words, create a string that is the 
        // acronym (first letter of each word). Return the string
        public static string Test5(string [] words)
        {
            string acronym = "";

            for(int i = 0; i < words.Length; i++)
            {
                acronym += words[i][0];
            }
            
            return acronym;
        }

        // Test 6 - Array reverse
        // Given a char array, letters, create another array that has the
        // same elements but in reverse order. Return the array
        // 
        // You are not allowed to use Array.Reverse (or any existing
        // method) to reverse the array
        //
        public static char[] Test6(char[] letters)
        {
            char[] mirror = new char[letters.Length];
            int reverse = letters.Length - 1;

            for(int i = 0; i < mirror.Length; i++)
            {
                mirror[reverse] = letters[i];
                reverse--;
            }

            

            return mirror;
        }

        // Test 7 - Transpose array
        // Given a 2-Dimension array of int, table, create a new array that 
        // 'transposes' the original array. Transposing means that each row 
        // in the original array will be a column in the new array and each
        // column in the original array will be a row in the new array.
        // For example, given
        //   4   3   1   5
        //   2   7   0   8
        //
        // The transposed array would be
        //   4   2
        //   3   7
        //   1   0
        //   5   8
        //
        public static int[,] Test7(int [,] table)
        {
            /*int[,] transpose = new int[table.GetLength(0)];*/
            int rows = table.GetLength(1);
            int cols = table.GetLength(0);
            int[,] newTable = new int[rows, cols];


            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    newTable[i, j] = table[j, i];
                }
            }
            
            return newTable;
        }

        // Test 8 – Return a 2D array
        // Given three arrays of the same type (int) and size, combine the 
        // arrays into a single 2D array. Return the 2D array
        // NOTE: This solution requires a single loop (not three)
        // {5,3,9},
        // {1,3,1},
        // {7,9,8}
        public static int [,] Test8(int [] mins, int [] maxes, int [] seeds)
        {
            int[][] toodee = new int[3][];
            toodee[0] = mins;
            toodee[1] = maxes;
            toodee[2] = seeds;
            int rows = mins.Length;
            int cols = toodee.GetLength(0);
            

            int[,] newTable = new int[cols, rows];


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {

                    newTable[j, i] = toodee[j][i];
                }
            }





            return newTable;
        }

        // Test 9 – Convert int array to char array
        // Given an array of int, ascii, convert each element to an
        // equivalent char value and place in a char array.
        // Return the char array
        public static char[] Test9(int[] ascii)
        {
            char[] converted = new char[ascii.Length];

            for(int i = 0; i < ascii.Length; i++)
            {
                converted[i] = (char)ascii[i];
            }
            return converted;
        }

        // Test 10 – Modify an existing array
        // Given an array of char (all uppercase), modify the array so
        // that every other element will be lowercase (even indexes are 
        // upper, odd indexes are lower)
        public static void Test10(char[] word)
        {
            for(int i =1; i<word.Length; i++)
            {
                word[i] = char.ToLower(word[i]);
                i++;
                
            }

            
        }
    }
}
