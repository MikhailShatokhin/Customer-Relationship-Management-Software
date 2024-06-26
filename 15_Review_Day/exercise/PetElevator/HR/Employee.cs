﻿using System.Collections.Generic;
using PetElevator.Shared;

namespace PetElevator.HR
{
    public class Employee : Person
    {
        public int EmployeeId { get; private set; }
        public string Title { get; set; }
        public Department Department { get; set; }
        public double Salary { get; set; }

        public override string FullName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }

        public Employee(string firstName, string lastName) : this(firstName, lastName, "", 0)
        {
        }

        public Employee(string firstName, string lastName, string title, double salary) : base(firstName, lastName)
        {
            Title = title;
            Salary = salary;
        }

        public void RaiseSalary(double percentage)
        {
            if (percentage > 0)
            {
                Salary *= (percentage / 100) + 1;
            }
        }

        public override double GetBalanceDue(Dictionary<string, double> servicesRendered)
        {
            double balanceDue = 0;
            foreach (KeyValuePair<string, double> item in servicesRendered)
            {
                if (item.Key == "Walking")
                {
                    balanceDue += item.Value / 2;
                }
                else
                {
                    balanceDue += item.Value;
                }

            }
            return balanceDue;

        }
    }
}
