using Greet;
using Grpc.Core;
using System;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Press any key to start the program...");
            Console.ReadKey();

            var channel = new Channel("localhost:50051", ChannelCredentials.Insecure);
            var client = new Greeter.GreeterClient(channel);

            while (true)
            {
                var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });
                Console.WriteLine("Greeting: " + reply.Message);
                Console.WriteLine("Press any key to start the program...");
                Console.ReadKey();
            }
        }
    }
}
