using AutoFac.ConsoleApp.Model;

namespace AutoFac.ConsoleApp.Data.Abstract
{
    public interface IEmployeeRepository
    {
        Employee FindById(int id);
    }
}
