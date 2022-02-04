using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PetElevator.CRM;

namespace PetElevator.Tests
{
    [TestClass]
    public class PetTests
    {
        [TestMethod]
        public void ListVaccinationsTest()
        {
            //Arrange
            List<string> testObject = new List<string>
            {
                "Rabies, Distemper, Parvo"
            };

            //Act
            List<string> result = new List<string>
            {
                "Rabies","Distemper","Parvo"
            };

            //Assert
            Assert.AreEqual(testObject, result);




            //Person person = new Person("Test", "Testerson");

            //string fullName = person.FullName;

            //Assert.AreEqual("Test Testerson", fullName);
        }
    }
}
