/* This program takes student grades and conduct statistical analysis on those grades */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello! This program takes student grades and conduct statistical analysis on those grades!Add student grade in main program! here you go!!");
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
