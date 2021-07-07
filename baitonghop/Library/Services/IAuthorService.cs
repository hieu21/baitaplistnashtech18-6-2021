using System;
using Library.Models;
using System.Collections.Generic;

namespace Library.Services{
    public interface IAuthorService{
        List<Author> GetAuthors(); 
        int Add(Author author);
        void Edit(Author author);  
        int Delete(int id);
    }
}