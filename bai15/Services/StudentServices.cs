using System;
using bai15.Models;
using System.Collections.Generic;
using System.Linq;
namespace bai15.Services
{
    public class StudentServices : IStudentServices
    {
        StudentContext db;
        public StudentServices(StudentContext _db)
        {
            db = _db;
        }
        public int Delete(int id)
        {
            int result = 0;

            if (db != null)
            {

                var exitsingStudent = db.Students.Find(id);

                if (exitsingStudent != null)
                {

                    db.Students.Remove(exitsingStudent);


                    result = db.SaveChanges();
                }
                return result;
            }

            return result;
        }


        public List<Student> GetStudent()
        {
            if (db != null)
            {
                return db.Students.ToList();
            }
            return null;
        }
        public int Add(Student student)
        {
             if (db != null)
            {
                 db.Students.Add(student);
                 db.SaveChanges();
                return student.Id;
                
            }

            return 0;
        }
        public void Edit(Student student)
        {
            if (db != null)
            {
                //Delete that post
                db.Students.Update(student);

                //Commit the transaction
                db.SaveChanges();
            }
        }
        
    }
}
