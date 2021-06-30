using System;
using System.Collections.Generic;
using bai13.Model;
using System.Linq;

namespace bai13.Services
{
    public class Service : IService
    {
        public static List<Person> persons = new List<Person>(){
            new Person{Id = 1, FirstName ="Hieu",LastName ="Do",DateOfBirth = new DateTime(1999,9,21),Gender ="Nam",BirthPlace ="HN"},
            new Person{Id = 2, FirstName ="Lan",LastName ="Nguyen",DateOfBirth = new DateTime(1993,7,11),Gender ="Nu",BirthPlace ="SG"},
            new Person{Id = 3, FirstName ="Linh",LastName ="Le",DateOfBirth = new DateTime(1995,5,20),Gender ="Nam",BirthPlace ="ND"},
            new Person{Id = 4, FirstName ="Hai",LastName ="Hoang",DateOfBirth = new DateTime(1997,9,1),Gender ="Nam",BirthPlace ="NA"},
            new Person{Id = 5, FirstName ="Duc",LastName ="Tran",DateOfBirth = new DateTime(2000,3,2),Gender ="Nam",BirthPlace ="DN"},
            new Person{Id = 6, FirstName ="Hoa",LastName ="Pham",DateOfBirth = new DateTime(1999,11,15),Gender ="Nu",BirthPlace ="HN"}
        };
        int nextId = 7;
        public List<Person> GetAll() => persons;
        public Person Get(int id) => persons.FirstOrDefault(x => x.Id == id);
      

        public void Add(Person person)
        {
            person.Id = nextId++;
            persons.Add(person);
        }

        public void Update(Person person)
        {
            var index = persons.FindIndex(p => p.Id == person.Id);
            if (index == -1)
                return;

            persons[index] = person;
        }
        public void Delete(int id)
        {
            var a = Get(id);
            if (a is null)
                return;
            persons.Remove(a);
        }

        public List<Person> FilterByGender(string gender)
        {
            var result = persons.Where(x => x.Gender == gender).ToList();

            return result;
        }
        public List<Person> FilterByBirthPlace(string birthPlace)
        {
            var result = persons.Where(x => x.BirthPlace == birthPlace).ToList();

            return result;
        }
        public List<Person> FilterByName(string name)
        {
            var result = persons.Where(x => x.LastName.ToLower() == name.ToLower() || x.FirstName.ToLower() == name.ToLower()).ToList();
            return result;
            
          
        }



    }
}