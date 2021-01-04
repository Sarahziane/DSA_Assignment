using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA_Assignment
{
  public  class Student
    {
        private string studentNumber;
    //    public  LinkedList<Student> CustomDataList = new LinkedList<Student>();
        public string StudentNumber
        {
            get { return this.studentNumber; }
            set
            {
                if (value == null)
                { throw new ArgumentNullException(); }
                this.studentNumber = value;
            }

        }
        private string firstName;
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value == null)
                { throw new ArgumentNullException(); }
                this.firstName = value;
            }

        }
        private string lastName;
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value == null)
                { throw new ArgumentNullException(); }
                this.lastName = value;
            }

        }
        private float averageScore;
        public float AverageScore
        {
            get { return this.averageScore; }
            set
            {
                this.averageScore = value;
            }
        }
     
        public Student ()
        { 

        }
        public Student(string firstName, string lastName, string studentNumber, float averageScore)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.averageScore = averageScore;
            this.studentNumber = studentNumber ;
        }

      

    

    }
}
