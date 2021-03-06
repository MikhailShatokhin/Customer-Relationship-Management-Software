using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PetElevator.HR;

namespace PetElevator.Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void FullNameReturnsCorrectFormat()
        {
            Employee employee = new Employee("Test", "Testerson");

            string fullName = employee.FullName;

            Assert.AreEqual("Testerson, Test", fullName);
        }

        [TestMethod]
        public void RaiseSalaryTest_Positive()
        {
            Employee employee = new Employee("Test", "Testerson");
            employee.Salary = 100;

            employee.RaiseSalary(5); //raise 5%

            Assert.IsTrue(employee.Salary == 100 * 1.05);
        }

        [TestMethod]
        public void RaiseSalaryTest_Negative()
        {
            Employee employee = new Employee("Test", "Testerson");
            employee.Salary = 100;

            employee.RaiseSalary(-10); //"raise" by negative 10%

            Assert.AreEqual(100, employee.Salary); //salary should remain same
        }
        [TestMethod]
        public void GetBalanceDueTest()
        {

            //Arrange
            Employee testObject = new Employee("John", "Fult");
            Dictionary<string, double> actual = new Dictionary<string, double>();
            actual.Add("Grooming", 10.0);
            actual.Add("Walking", 10.0);
            actual.Add("Sitting", 10.0);

            //Act
            double result = testObject.GetBalanceDue(actual);

            //Assert
            Assert.AreEqual(25.0, result);
        }



    }
}
