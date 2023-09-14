using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace StudentsManagement
{
    class GradesList
    {
        //List<ArrayList> gradesAL = new ArrayList<>();
        grade[] grades;
        int cnt = 0;
        public GradesList(int numOfsubjects)
        {
            grades = new grade[numOfsubjects];
            for (int i = 0; i < numOfsubjects; i++)
            {
                grades[i] = new grade(i); ;
            }
        }
        public void addGrade(string grade)
        {
            grades[cnt % grades.Length].addGrade(int.Parse(grade));
            cnt = cnt + 1;
        }
        public grade getGradeByID(int ID)
        {
            return grades[ID - 1];
        }
        public void printGrades()
        {
            for (int i = 0; i < grades.Length; i++)
                grades[i].printGrades();
        }
        public int count()
        {
            return grades.Length;
        }
        public grade[] getGrades()
        {
            return grades;
        }
    }
}
