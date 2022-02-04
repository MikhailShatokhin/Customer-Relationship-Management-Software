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
            List<string> testObject = new List<string> Vaccinations();

            //Act
            string result = testObject.ListVaccinations("Rabies", "Distemper", "Parvo");

            //Assert





            //Person person = new Person("Test", "Testerson");

            //string fullName = person.FullName;

            //Assert.AreEqual("Test Testerson", fullName);
        }
    }
}
