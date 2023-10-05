using AutoFac.ConsoleApp.Model;
using AutoFac.ConsoleApp.Response;

namespace AutoFac.ConsoleApp.Service.Abstract
{
    public interface IEmployeeService
    {
        BaseResponse<Employee> FindById(int employeeId);
    }
}
