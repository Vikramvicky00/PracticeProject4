using System;
using System.Collections.Generic;
using System.Linq;

namespace OOpsBasedSystemForStoringSchoolData
{
    public class SchoolManagementOperations
    {
        public static List<Student> studList = new List<Student>() 
        { 
            new Student("vikram","9","A"),new Student("Vinay","10","B"),
            new Student("Lokesh","9","A"),new Student("Vamsi","10","B")
        };

        public static List<Teacher> TeacherList = new List<Teacher>() 
        {
            new Teacher("King", "10th", "A") , new Teacher("Shruthi", "9th", "B"),
            new Teacher("Ben", "9th", "B") , new Teacher("Pooja", "9th", "A"),
            new Teacher("Mahesh", "10th", "A") , new Teacher("Mounika", "9th", "A") 
        };

        public static List<Subject> SubjectList = new List<Subject>() 
        {
            new Subject("English","10","King"), new Subject("English", "10", "Shruthi"),
            new Subject("Maths","5","Mounika"), new Subject("Social", "8", "Pooja"),
            new Subject("Science","7","Pooja"), new Subject("Maths", "5", "Ben"),
            new Subject("Hindi","1","Mahesh"), new Subject("History", "3","Shruthi"),
         };

       
        public static void GetStudentsInClass()
        {
            Console.WriteLine("Enter Class:");
            var className = Console.ReadLine();
            var studentsInClass = studList.FindAll(s => s.Class == className).ToList();
            if (studentsInClass.Count != 0) 
            {
                Console.WriteLine($"Students in class '{className}':");
                foreach (var student in studentsInClass)
                {
                    Console.WriteLine($"Student: {student.Name}, Class: {student.Class}, Section: {student.Section}");
                }
            }
            else
            {
                Console.WriteLine($"No students found in class '{className}'.");
                return;
            }
        }
        public static void GetSubjectsTaughtByTeacher()
        {
            Console.WriteLine("Enter Teacher Name:");
            var teacherName = Console.ReadLine();

            var subjectsTaughtByTeacher = SubjectList.Where(s => s.TeacherName == teacherName).ToList();
            if (subjectsTaughtByTeacher.Count != 0)
            {
                Console.WriteLine($"Subjects taught by '{teacherName}':");
                foreach (var subject in subjectsTaughtByTeacher)
                {
                    Console.WriteLine($"Subject: {subject.Name}, Subject Code: {subject.SubjectCode}, Teacher: {subject.TeacherName}");
                }
            }
            else
            {
                Console.WriteLine($"No subjects found taught by '{teacherName}'.");
                return;
            }
        }
        //public static void AddStudent()
        //{
        //    Student student = new Student();
        //    Console.WriteLine("Enter Student Name:");
        //    student.Name = Console.ReadLine();
        //    Console.WriteLine("Enter Class:");
        //    student.Class = Console.ReadLine();
        //    Console.WriteLine("Enter Section:");
        //    student.Section = Console.ReadLine();

        //    studList.Add(student);
        //    Console.WriteLine("Student added successfully!");
        //}
        //public static void AddTeacher()
        //{
        //    Teacher teacher= new Teacher();
        //    Console.WriteLine("Enter Teacher Name:");
        //    teacher.Name= Console.ReadLine();
        //    Console.WriteLine("Enter Class:");
        //    teacher.Class = Console.ReadLine();
        //    Console.WriteLine("Enter Section:");
        //    teacher.Section = Console.ReadLine();

        //    TeacherList.Add(teacher);
        //    Console.WriteLine("Teacher added successfully!");
        //}
        //public static void AddSubject()
        //{
        //    Subject subject = new Subject();
        //    Console.WriteLine("Enter Subject Name:");
        //    subject.Name= Console.ReadLine();
        //    Console.WriteLine("Enter Subject Code:");
        //    subject.SubjectCode  = Console.ReadLine();
        //    Console.WriteLine("Enter Teacher Name:");
        //    subject.TeacherName = Console.ReadLine();

        //    var teacher = TeacherList.FirstOrDefault(t => t.Name == subject.TeacherName);
        //    if (teacher != null)
        //    {
        //        string name = teacher.Name;
        //        subject.TeacherName = name;
        //        SubjectList.Add(subject);
        //        Console.WriteLine("Subject added successfully!");
        //    }
        //    else
        //    { 
        //        Console.WriteLine($"Teacher with name '{subject.TeacherName}' not found. Subject could not be added.");
        //    }
        //}
    }

}