using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()// type ctor (constructor) to get initialize constructor, Only initial costructor does have return type and the name is the same of class. 
        {
            _name = "Empty";
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

        public void WriteGrades(TextWriter destination)// "@out" @ is there to convert out keyword to normal variable
        {
            for (int i = 0; i < grades.Count; i++)
            {
                destination.WriteLine(grades[i]);
            }
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can not be null or empty!!");
                }

                    if (_name != value && NameChanged != null)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;
                        NameChanged(this, args);// this is referring to all elements in this grade. you can see those by typing "this."
                    }
                    _name = value;
                
            }
        }

        public event NameChangedDelegate NameChanged;
        //List<float> grades = new List<float>();/* add this line to initialize instructor
        /*public variable starts with capital letter and private variable start in small letter*/
        private List<float> grades;//field
        private string _name;//property, property is used for bounding and serialization not field
    }

    
}
