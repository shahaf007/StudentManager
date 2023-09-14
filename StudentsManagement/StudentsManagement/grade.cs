using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace StudentsManagement
{
    class grade
    {
        int subjectID;
        ArrayList grades = new ArrayList();

        public grade(int subject)
        {
            this.subjectID = subject;
        }

        public void addGrade(int num)
        {
            grades.Add(num);
        }

        public void printGrades()
        {
            Console.WriteLine("Subject's id: " + subjectID);
            foreach (int num in grades)
                Console.WriteLine(num);
        }
        public ArrayList getGrades()
        {
            return grades;
        }
        public int getSubID()
        {
            return subjectID;
        }
        public int getNumOfGrades()
        {
            return grades.Count;
        }
    }
}
