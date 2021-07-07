using System;
namespace DI2.Services{
    public class Service3 : IServices
    {
        public string Get()
        {
            string service = " hello service3";
            return service;
        }
    }
}