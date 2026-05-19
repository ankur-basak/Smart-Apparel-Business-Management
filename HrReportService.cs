using SmartClothingHR.Models;

namespace SmartClothingHR.Services;

public class HrReportService
{
    private readonly EmployeeService _employeeService;
    private readonly AttendanceService _attendanceService;
    private readonly LeaveService _leaveService;

    public HrReportService(EmployeeService employeeService, AttendanceService attendanceService, LeaveService leaveService)
    {
        _employeeService = employeeService;
        _attendanceService = attendanceService;
        _leaveService = leaveService;
    }

    public string GenerateEmployeeSummary()
    {
        IReadOnlyList<Employee> employees = _employeeService.GetEmployeeList();
        int activeEmployees = employees.Count(employee => employee.IsActive());
        int terminatedEmployees = employees.Count(employee => employee.Status == EmployeeStatus.Terminated);

        return $"Employees: {employees.Count}, Active: {activeEmployees}, Terminated: {terminatedEmployees}";
    }

    public string GenerateDailyAttendanceSummary(DateTime date)
    {
        IReadOnlyList<Attendance> attendanceList = _attendanceService.GetDailyAttendance(date);
        int present = attendanceList.Count(attendance => attendance.AttendanceStatus == AttendanceStatus.Present);
        int late = attendanceList.Count(attendance => attendance.AttendanceStatus == AttendanceStatus.Late);
        int halfDay = attendanceList.Count(attendance => attendance.AttendanceStatus == AttendanceStatus.HalfDay);

        return $"{date:yyyy-MM-dd} Attendance - Present: {present}, Late: {late}, Half Day: {halfDay}";
    }

    public string GenerateLeaveSummary(int employeeId)
    {
        IReadOnlyList<LeaveRequest> requests = _leaveService.GetLeaveRequestsByEmployee(employeeId);
        int approvedDays = requests
            .Where(request => request.ApprovalStatus == ApprovalStatus.Approved)
            .Sum(request => request.GetTotalDays());

        return $"Employee {employeeId} leave requests: {requests.Count}, Approved leave days: {approvedDays}";
    }
}
