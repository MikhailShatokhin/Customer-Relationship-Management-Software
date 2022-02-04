using System;
using System.Collections.Generic;
using System.Text;
using PetElevator.Shared;

namespace PetElevator.CRM
{
    public class Customer : Person
    {
        // Constructors

        public Customer(string firstName, string lastName, string phoneNumber) : base(firstName, lastName)
        {
            PhoneNumber = phoneNumber;
        }

        public Customer(string firstName, string lastName) : base(firstName, lastName)
        {

        }


        // Properties

        public string PhoneNumber { get; set; }
        public List<Pet> Pets { get; set; } = new List<Pet>();

    }
}
