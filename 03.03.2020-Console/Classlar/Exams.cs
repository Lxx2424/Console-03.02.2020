using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._03._2020_Console.Classlar
{
    class Exams
    {
        public string ExamName { get; set; }
        public List<Student> StudentList { get; set; }
     
        public Exams(string ExamName)
        {
            this.ExamName = ExamName;
         
        }
    }
}
