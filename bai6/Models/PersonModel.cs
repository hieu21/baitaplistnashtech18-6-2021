using System;
using System.Collections.Generic;

namespace bai6.Models
{
    public class PersonModel
    {
        public PersonModel(string firstName, string lastName, string gender, DateTime dob, int phoneNumber, string birthPlace, int age, string isGraduated)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Dob = dob;
            PhoneNumber = phoneNumber;
            BirthPlace = birthPlace;
            Age = age;
            IsGraduated = isGraduated;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public int PhoneNumber { get; set; }
        public string BirthPlace { get; set; }
        public int Age { get; set; }
        public string IsGraduated { get; set; }

        
    }
}