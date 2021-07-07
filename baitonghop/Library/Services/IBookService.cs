using System;
using Library.Models;
using System.Collections.Generic;

namespace Library.Services{
    public interface IBookService{
        List<Book> GetBooks(); 
        int Add(Book book);
        void Edit(Book book);  
        int Delete(int id);
    }
}