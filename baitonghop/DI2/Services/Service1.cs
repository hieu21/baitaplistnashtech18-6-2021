using System;
namespace DI2.Services
{
    public class Service1 : IServices
    {
        public string Get()
        {
            string service = " hello service1";
            return service;
        }
    }
}