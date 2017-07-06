using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()// type ctor (constructor) to get initialize constructor, Only initial costructor does have return type and the name is the same of class
        {
            grades = new List<float>();
        }
        public GradeStatistics ComputeStatistics()// here return type is "GradeStatistics"
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0;
            foreach(float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;

            return stats;
        }
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        //List<float> grades = new List<float>();// add this line to initialize instructor
        private List<float> grades;
    }

    
}
