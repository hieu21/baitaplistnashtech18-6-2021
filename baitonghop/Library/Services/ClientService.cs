using System;
using System.Collections.Generic;
using Library.Models;
using System.Linq;

namespace Library.Services
{
    public class ClientService : IClientService
    {
        LibraryContext db;
        public ClientService(LibraryContext _db)
        {
            db = _db;
        }
        public int Add(Client client)
        {
            if (db != null)
            {
                db.Clients.Add(client);
                db.SaveChanges();
                return client.ClientId;

            }

            return 0;
        }

        public int Delete(int id)
        {
            int result = 0;

            if (db != null)
            {

                var exitsingClient = db.Clients.Find(id);

                if (exitsingClient != null)
                {

                    db.Clients.Remove(exitsingClient);


                    result = db.SaveChanges();
                }
                return result;
            }

            return result;
        }

        public void Edit(Client client)
        {
             if (db != null)
            {
                //Delete that post
                db.Clients.Update(client);

                //Commit the transaction
                db.SaveChanges();
            }
        }

        public List<Client> GetClients()
        {
            if (db != null)
            {
                return db.Clients.ToList();
            }
            return null;
        }
    }
}