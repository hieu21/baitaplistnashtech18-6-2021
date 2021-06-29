using System;
using System.ComponentModel.DataAnnotations;

namespace bai7.Models
{
    public class PersonModel
    {
        public PersonModel( string firstName, string lastName, string gender, DateTime dob, int phoneNumber, string birthPlace, int age, string isGraduated, string email)
        {
            
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Dob = dob;
            PhoneNumber = phoneNumber;
            BirthPlace = birthPlace;
            Age = age;
            IsGraduated = isGraduated;
            Email = email;
        }

        public PersonModel(){

        }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateTime Dob { get; set; }
        // [StringLength(9)]
        [RegularExpression("^\\d{9,}$")]
        [Required]
        public int PhoneNumber { get; set; }
        public string BirthPlace { get; set; }
        public int Age { get; set; }
        public string IsGraduated { get; set; }
        [EmailAddress]
        [Required]
        public string Email{get;set;}


    }
}
