using SmartClothingHR.Models;
using SmartClothingHR.Repositories;

namespace SmartClothingHR.Services;

public class EmployeeService
{
    private readonly IRepository<Employee> _employeeRepository;

    public EmployeeService(IRepository<Employee> employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public Employee Hire(Employee employee)
    {
        _employeeRepository.Add(employee);
        return employee;
    }

    public void UpdateEmployee(int employeeId, string name, string phone, string email, string address, string designation, decimal salary)
    {
        Employee employee = GetRequiredEmployee(employeeId);
        employee.UpdateInformation(name, phone, email, address, designation, salary);
        _employeeRepository.Update(employee);
    }

    public void Renew(int employeeId)
    {
        Employee employee = GetRequiredEmployee(employeeId);
        employee.Renew();
        _employeeRepository.Update(employee);
    }

    public void Terminate(int employeeId)
    {
        Employee employee = GetRequiredEmployee(employeeId);
        employee.Terminate();
        _employeeRepository.Update(employee);
    }

    public IReadOnlyList<Employee> Search(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword)) return GetEmployeeList();

        return _employeeRepository.GetAll()
            .Where(employee =>
                employee.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                employee.Designation.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                employee.Phone.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                employee.Email.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            .ToList()
            .AsReadOnly();
    }

    public IReadOnlyList<Employee> GetEmployeeList()
    {
        return _employeeRepository.GetAll();
    }

    public Employee GetRequiredEmployee(int employeeId)
    {
        return _employeeRepository.GetById(employeeId)
            ?? throw new KeyNotFoundException($"Employee id {employeeId} was not found.");
    }
}
