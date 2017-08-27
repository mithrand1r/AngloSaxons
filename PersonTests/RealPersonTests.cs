using Microsoft.VisualStudio.TestTools.UnitTesting;
using People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Tests
{
    [TestClass()]
    public class RealPersonTests
    {
        [TestMethod()]
        public void ToString_NameAndAgeFilled()
        {
            //Arrange
            var TestPerson = new RealPerson("Henk", 10);

            //Act
            String Result = TestPerson.ToString();

            //Assert
            Assert.AreEqual("My name is Henk and I am 10 years", Result);
        }

        [TestMethod()]
        public void ToString_AgeEmpty()
        {
            //Arrange
            var TestPerson = new RealPerson("Henk");

            //Act
            String Result = TestPerson.ToString();

            //Assert
            Assert.AreEqual("My name is Henk and I am 30 years", Result);
        }

        [TestMethod()]
        public void ToString_RaceEmpty()
        {
            //Arrange
            var TestPerson = new RealPerson("Henk", 10);

            //Act
            String Result = TestPerson.Race;

            //Assert
            Assert.AreEqual("Caucasian", Result);
        }

        [TestMethod()]
        public void AddYearsToAge_100()
        {
            //Arrange
            var TestPerson = new RealPerson("Henk", 99);

            //Act
            TestPerson.AddYearsToAge(1);
            int Result = TestPerson.Age;

            //Assert
            Assert.AreEqual(100, Result);
        }

        [TestMethod()]
       public void AddYearsToAge_notOlderThan100()
        {
            //Arrange
            var TestPerson = new RealPerson("Henk", 100);

            //Act
            TestPerson.AddYearsToAge(1);
            int Result = TestPerson.Age;

            //Assert
            Assert.AreEqual(100, Result);
        }

        [TestMethod()]
        public void AddYearsToAge_notNegative()
        {
            //Arrange
            var TestPerson = new RealPerson("Henk", 10);

            //Act
            TestPerson.AddYearsToAge(-1);
            int Result = TestPerson.Age;

            //Assert
            Assert.AreEqual(10, Result);
        }

    }
}