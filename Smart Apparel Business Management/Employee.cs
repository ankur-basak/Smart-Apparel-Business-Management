namespace SmartClothingHR.Models;

public class Employee
{
    public Employee(
        int employeeId,
        string name,
        string phone,
        string email,
        string address,
        string designation,
        DateTime joiningDate,
        decimal salary)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Employee name is required.");
        if (string.IsNullOrWhiteSpace(designation)) throw new ArgumentException("Designation is required.");
        if (salary < 0) throw new ArgumentOutOfRangeException(nameof(salary), "Salary cannot be negative.");

        EmployeeId = employeeId;
        Name = name;
        Phone = phone;
        Email = email;
        Address = address;
        Designation = designation;
        JoiningDate = joiningDate;
        Salary = salary;
        Status = EmployeeStatus.Active;
    }

    public int EmployeeId { get; }
    public string Name { get; private set; }
    public string Phone { get; private set; }
    public string Email { get; private set; }
    public string Address { get; private set; }
    public string Designation { get; private set; }
    public DateTime JoiningDate { get; }
    public decimal Salary { get; private set; }
    public EmployeeStatus Status { get; private set; }

    public void UpdateInformation(string name, string phone, string email, string address, string designation, decimal salary)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Employee name is required.");
        if (string.IsNullOrWhiteSpace(designation)) throw new ArgumentException("Designation is required.");
        if (salary < 0) throw new ArgumentOutOfRangeException(nameof(salary), "Salary cannot be negative.");

        Name = name;
        Phone = phone;
        Email = email;
        Address = address;
        Designation = designation;
        Salary = salary;
    }

    public void Renew()
    {
        Status = EmployeeStatus.Renewed;
    }

    public void Terminate()
    {
        Status = EmployeeStatus.Terminated;
    }

    public bool IsActive()
    {
        return Status is EmployeeStatus.Active or EmployeeStatus.Renewed;
    }
}
