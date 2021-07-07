using System;
namespace DI1.Services{
    public class ServiceB : IServiceB{
        private readonly ServiceA _servicea;
        public ServiceB(ServiceA servicea){
            _servicea = servicea;
        }
        public String Test(){
            return"halo";
        }
    }
}