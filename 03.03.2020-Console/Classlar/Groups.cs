using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._03._2020_Console.Classlar
{
    class Groups
    {
        public string GroupName;
        public List<Student> StudentList;
        public List<Exams> ExamList;
        public Groups()
        {
            StudentList = new List<Student>();
            ExamList = new List<Exams>();
            ExamList.Add(new Exams("Html"));
            ExamList.Add(new Exams("Css"));
            ExamList.Add(new Exams("Javascipt"));


        }

        public void AddStudent()
        {
           
            Console.WriteLine("Please write Student Firstname");
            string fsname = Console.ReadLine();
            Console.WriteLine("Please write Student Lastname");
            string lsname = Console.ReadLine();
        Start:
            Console.WriteLine("Please write Student Email");
            string email = Console.ReadLine();

            Student stu = new Student(fsname, lsname, email);

            foreach (var stulist in StudentList)
            {
                if (stulist.Email == stu.Email)
                {
                    Console.WriteLine("Dublicate Email");
                    goto Start;
                }
            }
            StudentList.Add(stu);

        }
        public void ShowStudents()
        {
            Student selectedStudent = null;
            foreach (var stu in StudentList)
            {
                Console.WriteLine($"Id:{stu.Id}, Studens :{stu.Firstname} {stu.Lastname}");
                Console.WriteLine("----------------");

            }
        Start:  
            Console.Write("Please select student id:");
            string stuid = Console.ReadLine();
            if (Utilities.isInt(stuid))
            {
                int id = Convert.ToInt32(stuid);
                bool correct = false;
                foreach (var stu in StudentList)
                {
                    if (stu.Id == id)
                    {
                        correct = true;
                        selectedStudent = stu;
                        break;
                    }
                }
                if (correct)
                {
                    Console.ForegroundColor=ConsoleColor.Cyan;
                    Console.WriteLine($"\nSelected Students :{selectedStudent.Firstname} {selectedStudent.Lastname} ");
                    ShowExams(selectedStudent);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Student id doesn't exist");
                    correct = false;
                    goto Start;
                }
            }
            else
            {
                Console.WriteLine("Please write only numeric number for student id");
                goto Start;
            }
        }
        public void ShowExams(Student selectStu)
        {
            Exams selectedExam= null;
            foreach (var exam in ExamList)
            {
                Console.WriteLine($"\nExamName :{exam.ExamName}");
            }
        Start:
            Console.Write("Please select Exam Name:");
            string exmName = Console.ReadLine();
            
                bool correct = false;
                foreach (var exam in ExamList)
                {
                    if (exam.ExamName.ToLower() == exmName.ToLower())
                    {
                        correct = true;
                        selectedExam = exam;
                        break;
                    }
                }
                if (correct)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"\nSelected Exam: {selectedExam.ExamName}");
                    selectStu.examList.Add(selectedExam);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Student:{selectStu.Firstname} Exam {selectedExam.ExamName} Create successfully");
                }
                else
                {
                    Console.WriteLine("Examname doesn't exist");
                    correct = false;
                    goto Start;
                }
            }
        }
    }

