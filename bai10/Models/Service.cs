
using System.Collections.Generic;
using System.Linq;

namespace bai10.Models
{
    public static class Service
    {
        static List<ServerModel> servers { get; }
        static int nextId = 3;
        static Service()
        {
            servers = new List<ServerModel>
            {
                new ServerModel { Id = 1, Title = "Window", IsActive = false },
                new ServerModel { Id = 2, Title = "Linux", IsActive = true }
            };
        }

        public static List<ServerModel> GetAll() => servers;

        public static ServerModel Get(int id) => servers.FirstOrDefault(p => p.Id == id);

        public static void Add(ServerModel server)
        {
            server.Id = nextId++;
            servers.Add(server);
        }

        public static void Delete(int id)
        {
            var server = Get(id);
            if(server is null)
                return;

            servers.Remove(server);
        }

        public static void Update(ServerModel server)
        {
            var index = servers.FindIndex(p => p.Id == server.Id);
            if(index == -1)
                return;

            servers[index] = server;
        }
    }
}