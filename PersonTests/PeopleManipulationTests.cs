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
        public void InitPeople_10000()
        {
            //Arrange

            //Act
            List<Person> Result = PeopleManipulation.InitPeople();

            //Assert
            Assert.AreEqual(Result.Count,10000);
        }

        [TestMethod()]
        public void InitPeople_NameStartsWithPerson()
        {
            //Arrange

            //Act
            List<Person> persons = PeopleManipulation.InitPeople();

            //Assert
            Assert.AreEqual(persons.Count(p => p.Name.StartsWith("Person ")), 10000);
        }


        [TestMethod()]
        public void InitPeople_AgeBetween0And99()
        {
            //Arrange

            //Act
            List<Person> persons = PeopleManipulation.InitPeople();

            //Assert
            Assert.AreEqual(persons.Count(p => p.Age>0 && p.Age<100), 10000);
        }


        [TestMethod()]
        public void InitPeople_AllRacesRepresented()
        {
            //Arrange

            //Act
            List<Person> persons = PeopleManipulation.InitPeople();

            //Assert
            Assert.AreEqual(true, persons.Count(p => p.Race.Name == "Angle") > 0,"No Angles found");
            Assert.AreEqual(true, persons.Count(p => p.Race.Name == "Saxon") > 0, "No Saxons found");
            Assert.AreEqual(true, persons.Count(p => p.Race.Name == "Jute") > 0, "No Jutes found");
            Assert.AreEqual(true, persons.Count(p => p.Race.Name == "Asian") > 0,"No Asians found");
        }

        [TestMethod()]
        public void InitPeople_NoEmptyRaces()
        {
            //Arrange

            //Act
            List<Person> persons = PeopleManipulation.InitPeople();

            //Assert
            //No empty races allowed
            Assert.AreEqual(true, persons.Count(p => p.Race == null) == 0);
        }

    }
}