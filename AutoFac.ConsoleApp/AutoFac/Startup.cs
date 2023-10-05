using Autofac;
using AutoFac.ConsoleApp.Data.Abstract;
using AutoFac.ConsoleApp.Data.Concrete;
using AutoFac.ConsoleApp.Service.Abstract;
using AutoFac.ConsoleApp.Service.Concrete;

namespace AutoFac.ConsoleApp.AutoFac
{
    public static class Startup
    {
        //AutoFac IOC Control
      public static IContainer BuildContainer()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<Application>();
            builder.RegisterType<EmployeeRepository>().As<IEmployeeRepository>();
            builder.RegisterType<EmployeeService>().As<IEmployeeService>();
            return builder.Build();
        }
    }
}
