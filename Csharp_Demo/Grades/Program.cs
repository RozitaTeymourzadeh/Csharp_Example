/* This program takes student grades and conduct statistical aanalysis on those grades */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(12.3f);
            book.AddGrade(18.0f);
            book.AddGrade(20.0f);

            GradeBook book2 = book; // this type of assignment point to the same address in memory for book2

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.HighestGrade);// snip "cw"
            Console.WriteLine(stats.LowestGrade);// snip "cw"
            Console.WriteLine(stats.AverageGrade);// snip "cw"
            Console.ReadLine();
        }
    }
}
