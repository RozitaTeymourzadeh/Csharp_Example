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

            book.NameChanged += OnNameChanged;// subscribe to event 


            book.Name = "Student Property";
            book.Name = "Student Property as a book name";
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeBook book2 = book; // this type of assignment point to the same address in memory for book2

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Highest Value",stats.HighestGrade);// snip "cw"
            WriteResult("Lowest Value", (int)stats.LowestGrade);// snip "cw"
            WriteResult("Average Value", stats.AverageGrade);// snip "cw"
            WriteResult(stats.Description,stats.LetterGrade);
            Console.ReadLine();
        }

        /* Since WriteResult Method is going to be addressed by static Main method , it should be defined as static as well */
        static void OnNameChanged(object sender, NameChangedEventArgs args)// To be invoke by delegate
        {
            Console.WriteLine($"Grade book is changing name from {args.ExistingName} to {args.NewName}");
        }
        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}: {result}");
        }
        static void WriteResult(string description, float result)
        {
           // Console.WriteLine(description + " : " + result);
            Console.WriteLine($"{description}:{result:F2}");
        }
        static void WriteResult(string description, int result)
        {
            // Console.WriteLine(description + " : " + result);
            Console.WriteLine($"{description}:{result:F2}");
        }
    }
}
