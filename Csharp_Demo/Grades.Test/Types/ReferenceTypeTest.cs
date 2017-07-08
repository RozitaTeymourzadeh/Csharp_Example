using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Class is reference type where as enum and struct are value type. In order to know about each parameter, we can press F12 on each parameter to see it leads us to class sourse code or struct and enum sourse code*/
// . reference type
// . value type
// . struct and enum
// . passing parameters
// . ref and out
// .immutability
// . Arrays
namespace Grades.Test.Types
{

    [TestClass]
    public class TypeTest
    {
        /*testm sniped*/
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];
            AddGrades(grades);
            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
           grades[1] = 89.1f;
        }

        [TestMethod]
        public void UppercaseSring()
        {
            string name = "scott";
            name = name.ToUpper();
            Assert.AreEqual("SCOTT", name);
        }
        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015,1,1);
            date = date.AddDays(1);
            Assert.AreEqual(2, date.Day);
        }
        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(ref x);
            Assert.AreEqual(47, x);
        }
        private void IncrementNumber(ref int number)
        {
            number += 1;
        }
        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;
            GiveBookAName(ref book2);
            Assert.AreEqual("A GradeBook", book2.Name);
        }
        private void GiveBookAName(ref GradeBook book)
        {
            book = new GradeBook();// it moves to another address in memory and book no longer point to the same address of book1 and book2
            book.Name = "A GradeBook";
        }
        [TestMethod]
        public void StringComparison()
        {
            string name1 = "Scott";
            string name2 = "scott";

            bool result = String.Equals(name1, name2, System.StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;
            x1 = 4;
            Assert.AreNotEqual(x1,x2);
        }
        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;
            g1.Name = "Rozita Book";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
