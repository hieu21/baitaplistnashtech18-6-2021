using System.Collections.Generic;
using MVC_2.Models;

namespace MVC_2.Services
{
    public interface IService
    {
        List<PersonModel> GetAll();
        PersonModel Get(int id);
        void Add(PersonModel person);
        PersonModel Create();
        void Update(PersonModel person);
        bool Delete(int id);
        void SaveChanges();
    }
}