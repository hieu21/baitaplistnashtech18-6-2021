using System;
using System.Collections.Generic;
using System.Text;
using bai13.Model;
namespace bai13.Services{
    public interface IService{
        List<Person> GetAll();
        Person Get(int id);
        void Add(Person person);
        void Update(Person person);
        void Delete(int id);
        // List<Person> GetGender(string gender);
        //Person GetBirthPlace(string birthPlace);
        List<Person> FilterByGender(string gender);
        List<Person> FilterByBirthPlace(string birthPlace);
         List<Person> FilterByName(string name);
        
    }
}