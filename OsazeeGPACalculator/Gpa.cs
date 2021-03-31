using System;
using System.Collections.Generic;
using System.Text;

namespace OsazeeGPACalculator
{
    class Gpa
    {
        //solve for the grade point
        static public char ComputeGrade(int Score)
        {
            char grade = ' ';
            switch (Score)
            {
                case var d when d >= 70:
                    grade = 'A';
                    break;
                case var d when d >= 60:
                    grade = 'B';
                    break;
                case var d when d >= 50:
                    grade = 'C';
                    break;
                case var d when d >= 45:
                    grade = 'D';
                    break;
                case var d when d >= 40:
                    grade = 'E';
                    break;
                default:
                    grade = 'F';
                    break; 
            }
            return grade;
        }
        static public int ComputeGradePoint(char grade)
        {
            int point;
            switch (grade)
            {
                case 'A':
                    point = 5;
                    break;
                case 'B':
                    point = 4;
                    break;
                case 'C':
                    point = 3;
                    break;
                case 'D':
                    point = 2;
                    break;
                case 'E':
                    point = 1;
                    break;
                default:
                    point = 0;
                    break;

            }
            return point;
        }
        static public int QualityPoint(int courseUnit, int point)
        {
            return courseUnit * point;
        }
        static public double ComputeGPA(double totalQualityPoint, double totalGradeUnit)
        {
            var gpa = totalQualityPoint  / totalGradeUnit;
            return gpa;// check out for error
        }

    }
}
