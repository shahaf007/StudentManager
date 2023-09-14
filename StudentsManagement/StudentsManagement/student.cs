using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;

namespace StudentsManagement
{
    class student
    {
        public string name { get; set; }
        protected static int id = 0;
        public int pID { get; set; }

        //public ArrayList grades = new ArrayList(); // 1. math 2. english 3. physics
        public GradesList grades;
        const string path = @"D:\c#projects\StudentsManagement\data\grades1.txt";
        public student(string name, int subjects)
        {
            grades = new GradesList(subjects);
            this.name = name;
            pID = id;
            id++;
            refresh();
        }
        public void refresh()
        {
            string temp;
            string copyPath = path;
            int index = 1;
            while (File.Exists(copyPath))
            {
                using (StreamReader sr = new StreamReader(copyPath))
                {
                    while ((temp = sr.ReadLine()) != null)
                    {
                        if (temp.Contains("id") && temp.Contains(pID.ToString()))
                        {
                            temp = sr.ReadLine();
                            for (int i = 0; i < grades.count(); i++)
                            {
                                grades.addGrade(temp);
                                temp = sr.ReadLine();
                                if ((temp == null) || (temp.Contains("id")))
                                    break;
                            }
                        }
                    }
                }
                copyPath = (copyPath.Substring(0, copyPath.LastIndexOf(index.ToString())) + (index + 1) + ".txt");
                index = index + 1;
            }
        }
        public grade[] getAllGrades()
        {
            return grades.getGrades();
        }
        public grade getGradesByID(int ID)
        {
            return grades.getGradeByID(ID);
        }
        public int getSubjects()
        {
            return grades.count();
        }
        public void print()
        {
            Console.Write("name: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(name);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" | id: " + pID);
            //Console.WriteLine("grades: ");
            grades.printGrades();
        }
        public void printID()
        {
            Console.Write("name: " + name);
            Console.WriteLine(" | id: " + pID);
        }
        public string getID()
        {
            return ("name: " + name + " id: " + pID);
        }

    }
}
