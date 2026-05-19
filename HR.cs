using SmartClothingHR.Services;

namespace SmartClothingHR.Models;

public class HR : User
{
    public HR(
        int userId,
        int hrId,
        string name,
        string email,
        string phone,
        string address,
        Gender gender,
        string username,
        string password,
        string designation,
        DateTime joiningDate,
        decimal salary)
        : base(userId, name, email, phone, address, gender, username, password, UserRole.HR)
    {
        if (salary < 0) throw new ArgumentOutOfRangeException(nameof(salary), "Salary cannot be negative.");

        HrId = hrId;
        Designation = designation;
        JoiningDate = joiningDate;
        Salary = salary;
    }

    public int HrId { get; }
    public string Designation { get; private set; }
    public DateTime JoiningDate { get; }
    public decimal Salary { get; private set; }

    public override string GetDashboardTitle()
    {
        return "HR Dashboard";
    }

    public Employee HireEmployee(EmployeeService employeeService, Employee employee)
    {
        return employeeService.Hire(employee);
    }

    public void RenewEmployee(EmployeeService employeeService, int employeeId)
    {
        employeeService.Renew(employeeId);
    }

    public void TerminateEmployee(EmployeeService employeeService, int employeeId)
    {
        employeeService.Terminate(employeeId);
    }

    public IReadOnlyList<Employee> SearchEmployees(EmployeeService employeeService, string keyword)
    {
        return employeeService.Search(keyword);
    }

    public Attendance RecordAttendance(AttendanceService attendanceService, int employeeId, DateTime checkInTime)
    {
        return attendanceService.CheckIn(employeeId, checkInTime);
    }

    public void ApproveLeave(LeaveService leaveService, int leaveId)
    {
        leaveService.ApproveLeave(leaveId, HrId);
    }

    public void RejectLeave(LeaveService leaveService, int leaveId, string rejectionReason)
    {
        leaveService.RejectLeave(leaveId, HrId, rejectionReason);
    }
}
