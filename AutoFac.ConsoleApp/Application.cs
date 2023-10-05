using System;
using AutoFac.ConsoleApp.Service.Abstract;

namespace AutoFac.ConsoleApp
{
    public class Application
    {
        protected readonly IEmployeeService _employeeService;

        public Application(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        //Main() Rolündedir
        public void Run()
        {
            var result = _employeeService.FindById(1);
            if (result?.Data == null)
            {
                Console.WriteLine(result.Message);
            }
            else
            Console.WriteLine($"Id: {result?.Data.Id}, Adı: {result?.Data.Name}");

        }
    }
}
