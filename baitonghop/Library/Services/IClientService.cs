using System;
using Library.Models;
using System.Collections.Generic;

namespace Library.Services{
    public interface IClientService{
        List<Client> GetClients(); 
        int Add(Client client);
        void Edit(Client client);  
        int Delete(int id);
    }
}