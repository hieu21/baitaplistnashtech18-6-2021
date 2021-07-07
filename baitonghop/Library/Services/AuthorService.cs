using System;
using System.Collections.Generic;
using Library.Models;
using System.Linq;

namespace Library.Services{
    public class AuthorService : IAuthorService
    {
        LibraryContext db;
        public AuthorService(LibraryContext _db)
        {
            db = _db;
        }
        public int Add(Author author)
        {
           if (db != null)
            {
                db.Authors.Add(author);
                db.SaveChanges();
                return author.AuthorId;

            }

            return 0;
        }

        public int Delete(int id)
        {
            int result = 0;

            if (db != null)
            {

                var exitsingAuthor = db.Authors.Find(id);

                if (exitsingAuthor != null)
                {

                    db.Authors.Remove(exitsingAuthor);


                    result = db.SaveChanges();
                }
                return result;
            }

            return result;
        }

        public void Edit(Author author)
        {
            if (db != null)
            {
                //Delete that post
                db.Authors.Update(author);

                //Commit the transaction
                db.SaveChanges();
            }
        }

        public List<Author> GetAuthors()
        {
            if (db != null)
            {
                return db.Authors.ToList();
            }
            return null;
        }
    }
}