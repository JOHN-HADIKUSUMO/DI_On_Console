using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_On_Console
{
    class HelloWorld : IHelloWorld
    {
        public string GetString()
        {
            return "Hello World!";
        }
    }
}
