using System;
using System.Collections;

namespace StudentsManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            Classroom classroom = new Classroom(new string[3] { "math", "english", "physics" });
            Analyzer analyzer = new Analyzer(classroom);
            System system = new System(classroom, analyzer);
            system.run();

        }
    }
}
