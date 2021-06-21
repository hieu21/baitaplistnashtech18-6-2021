using System;
namespace bai12{
    abstract class Person{
        private string firstName;
        private string lastName;
        private string gender;
        private DateTime dob;
        private int phoneNumber;
        private string birthPlace;
        private int age;
        private string isGraduated;

        

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string BirthPlace { get => birthPlace; set => birthPlace = value; }
        public int Age { get => age; set => age = value; }
        public string IsGraduated { get => isGraduated; set => isGraduated = value; }

        public Person(string firstName, string lastName, string gender, DateTime dob, int phoneNumber, string birthPlace, int age, string isGraduated)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.dob = dob;
            this.phoneNumber = phoneNumber;
            this.birthPlace = birthPlace;
            this.age = age;
            this.isGraduated = isGraduated;
        }

    }
}