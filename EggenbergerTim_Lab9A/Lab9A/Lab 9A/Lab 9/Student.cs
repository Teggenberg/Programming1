using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9A
{
    public class Student
    {
        // Add member fields here

        string mfirst;
        string mlast;
        int idNum;


        // Add default and overloaded constructors here

        public Student()
        {
            mfirst = "";
            mlast = "";
            idNum = 1000000;
        }

        public Student(string lName, string fName, int iD)
        {
            mfirst = fName;
            mlast = lName;
            idNum = iD;
        }


        // add Getters and Setters here

        public string GetFirstName()
        {
            return mfirst;
        }
        public string GetLastName()
        {
            return mlast;
        }
        public int GetIDNumber()
        {
            return idNum;
        }

        public void SetFirstName(string fName)
        {
            mfirst = fName; 
        }
        public void SetLastName(string lName)
        {
            mlast = lName;
        }
        public void SetIDNumber(int iD)
        {
            idNum = iD;
        }



















        /******************************************************************************************************
        *                                                                                                     *
        *                                                                                                     *
        *                                                                                                     *
        *                                                                                                     *
        *                      do not modify any of the following code                                        *
        *                                                                                                     *
        *                                                                                                     *
        *                                                                                                     *
        *                                                                                                     *
        *                                                                                                     *
        ******************************************************************************************************/
        public override string ToString()
        {
            return "ID #: " + GetIDNumber() + "\tName: " + GetLastName() + ", " + GetFirstName();
        }

        public override bool Equals(object obj)
        {
            bool same = true;
            Student s2 = (Student)obj;
            if (this.GetLastName() != s2.GetLastName() || this.GetFirstName() != s2.GetFirstName() || this.GetIDNumber() != s2.GetIDNumber())
            {
                same = false;
            }
            return same;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
