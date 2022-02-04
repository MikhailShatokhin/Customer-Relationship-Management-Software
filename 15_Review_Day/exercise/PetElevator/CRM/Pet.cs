using System;
using System.Collections.Generic;
using System.Text;

namespace PetElevator.CRM
{
    class Pet
    {
        //Constructors
        public Pet (string petName, string species)
        {
            PetName = petName;
            Species = species;
        }

        //Properties
        public string PetName { get; set; }
        public string Species { get; set; }
        public List<Pet> Vaccinations { get; set; } = new List<Pet>();

        //Methods
        public string ListVaccinations()
        {
            string petVacs = string.Join(",", Vaccinations);
            
            return petVacs;
        }

    }
}
