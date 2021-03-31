using System;
using System.Collections.Generic;

namespace OsazeeGPACalculator
{
    class Program
    {
        List<CourseInfo> courseList;
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("This Program Computes GPA, requires you enter course Name and Code, Score and Course Unit");
            p.SetInput();//set the CourseInfo Property from User Input
            p.Display();// Output CourseInfo and GPA 
            Console.ReadKey();// type any key to end execution

        }
        public List<CourseInfo> GetInput()
        {
            return courseList;
        }
        public void SetInput()
        {
            courseList = new List<CourseInfo>();
            while (true)
            {
                
                try
                {
                    CourseInfo cs = new CourseInfo();
                    Console.WriteLine("Input Course Name and Code :");
                    var courseNameCode = Console.ReadLine();
                    cs.CourseNameCode = courseNameCode;
                
                    Console.WriteLine("Input Course Unit :");
                    var courseUnit = int.Parse(Console.ReadLine());
                    cs.CourseUnit = courseUnit;
                
                    Console.WriteLine("Input Course Score :");
                    var courseScore = int.Parse(Console.ReadLine());
                    cs.Score = courseScore;
                    cs.Grade = Gpa.ComputeGrade(cs.Score);
                    cs.GradePoint = Gpa.ComputeGradePoint(cs.Grade);

                    courseList.Add(cs);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                

               
                
                Console.WriteLine("\n");
                Console.WriteLine("Do you want to continue? (Y/N) :");
                var response = Console.ReadLine();
                if(response == "N" || response == "n")
                {
                    break;
                }
                Console.Clear();
            }
        }
        public void Display()
        {
            //heading
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("Your Course Information and GPA\n");
            Console.WriteLine($"|-----------------|--------------|---------|----------------|");
            Console.Write("|{0,-17}|", "COURSE & CODE");
            Console.Write("{0,-14}|", "COURSE UNIT");
            Console.Write("{0,-9}|", "GRADE");
            Console.Write("{0,-16}|\n", "GRADE-UNIT");
            Console.WriteLine($"|-----------------|--------------|---------|----------------|");
            var courseList = this.GetInput();
            var tqp = 0.0; // total quality point
            var tcu = 0.0; // total grade unit
            foreach(var course in courseList)
            {
                tqp += Gpa.QualityPoint(course.CourseUnit, course.GradePoint);
                tcu += course.CourseUnit;
                Console.Write($"|{course.CourseNameCode,-17}|");
                Console.Write($"{course.CourseUnit,-14}|");
                Console.Write($"{course.Grade,-9}|");
                Console.Write($"{course.GradePoint,-16}|\n");
            }
            Console.WriteLine($"|-----------------------------------------------------------|");
            Console.WriteLine("\n");
            Console.WriteLine($"Your GPA is = {Gpa.ComputeGPA(tqp, tcu):N2} to 2 decimal places.");
            Console.WriteLine("\n");
        }
    }
}
