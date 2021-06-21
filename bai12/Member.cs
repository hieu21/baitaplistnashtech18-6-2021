using System;
namespace bai12
{
    class Member : Person
    {
        public Member(string firstName, string lastName, string gender, DateTime dob, int phoneNumber, string birthPlace, int age, string isGraduated) : base(firstName, lastName, gender, dob, phoneNumber, birthPlace, age, isGraduated)
        {
        }
    }

}