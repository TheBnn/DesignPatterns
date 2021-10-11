using SingletonNamespace;
using System;

namespace Patterns
{
    class Program
    {



        static void Main(string[] args)
        {

            SingletonExecute singletonExecute = new SingletonExecute();
            singletonExecute.Launch("dbConnectionString");
            

        }
    }
}
