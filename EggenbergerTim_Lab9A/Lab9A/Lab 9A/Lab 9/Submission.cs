using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9A
{
    public class Submission
    {
        public static Student[] enrollment = new Student[0];

        public static Student Test1(string last, string first, int idNo)
        {

            Student s1 = new Student(last, first, idNo);
            return s1;
        }

        public static Student Test2()
        {
            Student s2 = new Student();
            return s2;
        }

        public static bool Test3(Student enrolled)
        {

            bool enroll = true;
            
            for (int i = 0; i < enrollment.Length; i++)
            {
                if (enrollment[i] == null)
                {
                    enrollment[i] = enrolled;

                    return enroll;
                }
                else
                {
                    enroll = false;
                }
            
            }
            return enroll;
        }

        public static bool Test4(int idNumber)
        {
            bool enroll = true;
            
            for (int i = 0; i < enrollment.Length; i++)
            {
                if (enrollment[i]!= null) 
                {
                    int check = enrollment[i].GetIDNumber();


                    if (check == idNumber)
                    {
                        enrollment[i] = null;
                        break;
                    }
                    else
                    {
                        enroll = false;
                    }
                }
                
                

            }
            return enroll;
        }

        public static Student Test5(int idNumber)
        {
            bool exists = true;
            int count = 0;


            for (int i = 0; i < enrollment.Length; i++)
            {
                

                if (enrollment[i] != null)
                {
                    int check = enrollment[i].GetIDNumber();
                    


                    if (check == idNumber)
                    {
                        return enrollment[i];
                        count = i;
                        break;
                    }
                    else
                    {
                        exists = false;
                    }
                }

                

            }
            if (exists) return enrollment[count];
            else return null;



        }
    }
}
