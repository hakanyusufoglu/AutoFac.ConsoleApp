using AutoFac.ConsoleApp.Data.Abstract;
using AutoFac.ConsoleApp.Model;
using AutoFac.ConsoleApp.Response;
using AutoFac.ConsoleApp.Service.Abstract;

namespace AutoFac.ConsoleApp.Service.Concrete
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public BaseResponse<Employee> FindById(int employeeId)
        {
            BaseResponse<Employee> response = new BaseResponse<Employee>() { StatusCode = 400, Message = "Kullanıcı bulunamadı... (hata mesajları app.config'den okunabilir.)", Data = null };
            var result = _employeeRepository.FindById(employeeId);
            if (result != null)
            {
                response.Message = "Kullanıcı getirildi (uyarı mesajları app.config'den okunabilir.)";
                response.Data = result;
                return response;
            }
            return response;
        }
    }
}
