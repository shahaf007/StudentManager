using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace StudentsManagement
{
    public delegate void Del();
    
    class System
    {
        private Classroom classroomn;
        private Analyzer analyzer;
        protected Del[] methodes;
        public System(Classroom classroom,Analyzer analyzer)
        {
            this.classroomn = classroom;
            this.analyzer = analyzer;
            setMethodes();
        }

        public void setMethodes()
        {
            Del printStudentsData = new Del(analyzer.printStudentsData);
            Del printBetterStudents = new Del(analyzer.printBetterStudents);
            Del printStudentsAbove = new Del(analyzer.printStudentsAbove);
            methodes = new Del[] { printStudentsData, printBetterStudents,printStudentsAbove };
        }
        private void runDel(int choice)
        {
            Del temp = methodes[choice - 1];
            temp();
        }
        public void run()
        {
            bool run = true;
            bool menu = true;

            while (run)
            {
                Console.Clear();
                if (menu)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Menu:\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1. Students Data \n2. Better Students\n3. students above (grade) in (subject)");
                    Console.WriteLine("---------------------------\n");
                }
                Console.WriteLine("TIP: to hide menu, type: 'H'. to show type: 'S' \n ");
                string input = Console.ReadLine();
                try{

                    if (input == "H")
                        menu = false;

                    else if (input == "S")
                        menu = true;
                    else if (int.Parse(input) - 1 < methodes.Length)
                    {
                        methodes[int.Parse(input) - 1]();
                        Console.ReadLine();
                    }


                }
                catch
                {

                }
            }

        }
    }
}
