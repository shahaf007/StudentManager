using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;

namespace StudentsManagement
{
    class Classroom
    {
        public ArrayList students = new ArrayList();
        const string path = @"D:\c#projects\StudentsManagement\data\names.txt";
        int subjects;
        string[] arrSubjects;
        public Classroom(string[] arrSubjects)
        {
            this.subjects = arrSubjects.Length;
            this.arrSubjects = arrSubjects;
            generateStudents();
        }
        public void generateStudents()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string name;
                while ((name = sr.ReadLine()) != null)
                {
                    students.Add(new student(name,subjects));
                }
            }
        }
        public void printStudents()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Students Data: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------- \n");
            if (students != null)
            {
                foreach (student student in students)
                {
                    student.print();
                    Console.WriteLine(" \n ");
                }

            }
            Console.WriteLine(" ----------------------------------- \n ");
        }
        public ArrayList getStudents()
        {
            return students;
        }
        public int getSubjects()
        {
            return subjects;
        }
        public string getSubjectNameByID(int id)
        {
            return arrSubjects[id];
        }
    }
}
