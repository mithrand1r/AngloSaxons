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
    public class RaceTests
    {
        [TestMethod()]
        public void Height_Asian()
        {
            //Arrange
            var asian = new RealPersonFactory().GetPerson("Test Asian", 10, "Asian");
            
            //Act

            //Assert
            Assert.AreEqual(4.46, asian.Height);
        }

        [TestMethod()]
        public void Height_Jute()
        {
            //Arrange
            var jute = new RealPersonFactory().GetPerson("Test Jute", 10, "Jute");

            //Act

            //Assert
            Assert.AreEqual(8, jute.Height);
        }
    }
}