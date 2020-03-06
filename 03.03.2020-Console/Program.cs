
using _03._03._2020_Console.Classlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _03._03._2020_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Groups grp = new Groups();
            grp.GroupName = "K101";
            do
            {
                Console.WriteLine("1.Add Student to Group");
                Console.WriteLine("2.Add Student to Exam ");
                Console.WriteLine("3.Show Students");
                Console.WriteLine("4.Exit");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        grp.AddStudent();
                        break;
                    case "2":
                        grp.ShowStudents();
                        break;
                    case "3":
                        foreach (var stu in grp.StudentList)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"\nStudents:{stu.Firstname} {stu.Lastname}");
                            foreach (var exam in stu.examList)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine($"\nExamName:{exam.ExamName}");
                            }
                        }
                        break;
                    default:
                        break;
                }
            } while (userInput!="4");


        }
    }
}
