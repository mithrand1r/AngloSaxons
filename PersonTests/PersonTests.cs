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
    public class PersonTests
    {
        [TestMethod()]
        public void ToString_NameAndAgeFilled()
        {
            //Arrange
            Person TestPerson = new Person();
            TestPerson.Name = "Henk";
            TestPerson.Age = 10;

            //Act
            String Result = TestPerson.ToString();
            
            //Assert
            Assert.AreEqual("My name is Henk and I am 10 years",Result);
        }

        [TestMethod()]
        public void ToString_AgeEmpty()
        {
            //Arrange
            Person TestPerson = new Person();
            TestPerson.Name = "Henk";

            //Act
            String Result = TestPerson.ToString();

            //Assert
            Assert.AreEqual("My name is Henk and I am 0 years", Result);
        }

    }
}