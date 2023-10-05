using AutoFac.ConsoleApp.Data.Abstract;
using AutoFac.ConsoleApp.Model;
using System.Collections.Generic;
using System.Linq;

namespace AutoFac.ConsoleApp.Data.Concrete
{
    public class EmployeeRepository : IEmployeeRepository
    {
        //Dummy Data
        private readonly List<Employee> _data = new List<Employee>()
        {
           new Employee() { Id = 1, Name="John"},
           new Employee() { Id = 2, Name="Trayce"}
        };

        public Employee FindById(int id)
        {
          return _data.FirstOrDefault(x => x.Id == id);
        }

    }
}
