using System;
using System.Collections.Generic;
using bai15.Models;
namespace bai15.Services{
    public interface IStudentServices{
        List<Student> GetStudent();
        
        
        int Add(Student student);
        void Edit(Student student);
        

        int Delete(int id);
    }
}