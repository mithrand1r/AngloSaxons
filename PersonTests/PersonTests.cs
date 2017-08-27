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
            var TestPerson = new RealPerson("Henk",10);

            //Act
            String Result = TestPerson.ToString();
            
            //Assert
            Assert.AreEqual("My name is Henk and I am 10 years",Result);
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
            var TestPerson = new RealPerson("Henk",10);

            //Act
            String Result = TestPerson.Race;

            //Assert
            Assert.AreEqual("Caucasian", Result);
        }


    }
}