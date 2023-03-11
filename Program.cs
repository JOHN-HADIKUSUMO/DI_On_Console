using System;
using Microsoft.Extensions.DependencyInjection;

namespace DI_On_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();
            services.AddScoped<IHelloWorld, HelloWorld>();

            IServiceProvider provider = services.BuildServiceProvider();
            IHelloWorld instance = provider.GetService<IHelloWorld>();
            string value = instance.GetString();
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
