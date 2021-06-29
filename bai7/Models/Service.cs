using System;
using System.Collections.Generic;
using System.Linq;


namespace bai7.Models
{
    public class Service
    {
        public List<PersonModel> persons { get; set; }
        public Service(){

          persons = new List<PersonModel>(
             // new PersonModel{FirstName="hieu1",LastName="hoang1",Dob= new DateTime (2000,08,09),Gender="nam",PhoneNumber=123456789,BirthPlace="HN",Age=10,IsGraduated="yes",Email="hieu@gmai.com"}
          ); 
        }

        // public static List<PersonModel> Persons { get; set; }

        public PersonModel[] Get() => persons.ToArray();
        public PersonModel Get(int phoneNumber) => persons.SingleOrDefault(x => x.PhoneNumber == phoneNumber);

        public void Add(PersonModel person) => persons.Add(person);
        public void Edit(PersonModel person)
        {
            var b = Get(person.PhoneNumber);
            persons.Remove(b);
            persons.Add(person);
        }
        public void Delete(int phoneNumber)
        {
            var b = Get(phoneNumber);
            persons.Remove(b);
        }
    }
}