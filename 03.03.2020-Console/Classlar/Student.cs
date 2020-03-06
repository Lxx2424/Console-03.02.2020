using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._03._2020_Console.Classlar
{
    class Student
    {
        public List<Exams> examList;
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public int Id { get;private set; }
        private static int stuId = 1;
        public Student(string Firstname,string Lastname,string Email)
        {
            examList = new List<Exams>();
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Email = Email;
            Id = stuId;
            stuId++;
        }

    }
}
