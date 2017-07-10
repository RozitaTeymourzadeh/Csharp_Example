﻿/* This program takes student grades and conduct statistical analysis on those grades */

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
            book.NameChanged = new NameChangedDelegate(OnNameChanged);
            book.Name = "Student Property";
            book.AddGrade(12.3f);
            book.AddGrade(18.0f);
            book.AddGrade(20.0f);

            GradeBook book2 = book; // this type of assignment point to the same address in memory for book2

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Highest Value",stats.HighestGrade);// snip "cw"
            WriteResult("Lowest Value", (int)stats.LowestGrade);// snip "cw"
            WriteResult("Average Value", stats.AverageGrade);// snip "cw"
            Console.ReadLine();
        }

        /* Since WriteResult Method is going to be addressed by static Main method , it should be defined as static as well */
        static void OnNameChanged(string existingName, string newName)// To be invoke by delegate
        {
            Console.WriteLine($"Grade book changing name from {existingName} to {newName}");
        }
        static void WriteResult(string description, float result)
        {
           // Console.WriteLine(description + " : " + result);
            Console.WriteLine($"{description}:{result:C}");
        }
        static void WriteResult(string description, int result)
        {
            // Console.WriteLine(description + " : " + result);
            Console.WriteLine($"{description}:{result:F2}");
        }
    }
}
