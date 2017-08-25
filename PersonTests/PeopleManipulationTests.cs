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
    public class PeopleManipulationTests
    {
        [TestMethod()]
        public void InitPeople_1000()
        {
            //Arrange

            //Act
            List<Person> Result = PeopleManipulation.InitPeople();

            //Assert
            Assert.AreEqual(Result.Count,1000);
        }

        [TestMethod()]
        public void InitPeople_NameStartsWithPerson()
        {
            //Arrange

            //Act
            List<Person> persons = PeopleManipulation.InitPeople();

            //Assert
            Assert.AreEqual(persons.Count(p => p.Name.StartsWith("Person ")), 1000);
        }


        [TestMethod()]
        public void InitPeople_AgeBetween0And99()
        {
            //Arrange

            //Act
            List<Person> persons = PeopleManipulation.InitPeople();

            //Assert
            Assert.AreEqual(persons.Count(p => p.Age>0 && p.Age<100), 1000);
        }

    }
}