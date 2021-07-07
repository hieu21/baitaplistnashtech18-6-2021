using System;
namespace DI2.Services
{
    public class Service2 : IServices
    {
        public string Get()
        {
            string service = " hello service2";
            return service;
        }
    }
}