using Autofac;
using AutoFac.ConsoleApp.AutoFac;
using System;

namespace AutoFac.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AutoFac Resolver
            Startup.BuildContainer().Resolve<Application>().Run();
            Console.ReadKey();
        }
    }
}
