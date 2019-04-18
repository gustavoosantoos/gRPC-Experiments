using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Greet;
using Grpc.Core;

namespace WebApplication6
{
    public class GreeterService : Greeter.GreeterBase
    {
        public override async Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return new HelloReply
            {
                Message = "Hello " + request.Name + ", your age is: " + request.Age
            };
        }
    }
}
