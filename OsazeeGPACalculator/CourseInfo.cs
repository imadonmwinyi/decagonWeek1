using System;
using System.Collections.Generic;
using System.Text;

namespace OsazeeGPACalculator
{
    public class CourseInfo
    {
        public string CourseNameCode;
        public char Grade { get; set; }

        
        public int GradePoint { get; set; }
        private int _score;
        private int _courseUnit;
        public int Score
        {
            get
            {
                return _score;

            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _score = value;
                }
                else { 
                    throw new ArgumentException($"{value} is an invalid Score");
                }
                
            }
        }
        public int CourseUnit
        {
            get { return _courseUnit; }
            set
            {
                if (value >= 1 && value <= 10)
                {
                    _courseUnit = value;
                }
                else
                {
                    throw new ArgumentException($"{value} is out of range for Course Unit"); 
                }

            }
        }


    }     
    
}
