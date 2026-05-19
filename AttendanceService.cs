using SmartClothingHR.Models;
using SmartClothingHR.Repositories;

namespace SmartClothingHR.Services;

public class AttendanceService
{
    private readonly IRepository<Attendance> _attendanceRepository;
    private readonly EmployeeService _employeeService;
    private int _nextAttendanceId = 1;

    public AttendanceService(IRepository<Attendance> attendanceRepository, EmployeeService employeeService)
    {
        _attendanceRepository = attendanceRepository;
        _employeeService = employeeService;
        OfficeStartTime = new TimeSpan(9, 0, 0);
    }

    public TimeSpan OfficeStartTime { get; set; }

    public Attendance CheckIn(int employeeId, DateTime checkInTime)
    {
        Employee employee = _employeeService.GetRequiredEmployee(employeeId);
        if (!employee.IsActive()) throw new InvalidOperationException("Terminated employees cannot check in.");

        bool alreadyCheckedIn = _attendanceRepository.GetAll()
            .Any(attendance => attendance.EmployeeId == employeeId && attendance.Date == checkInTime.Date);

        if (alreadyCheckedIn)
        {
            throw new InvalidOperationException("Attendance already exists for this employee today.");
        }

        var attendance = new Attendance(_nextAttendanceId++, employeeId, checkInTime, OfficeStartTime);
        _attendanceRepository.Add(attendance);
        return attendance;
    }

    public void CheckOut(int attendanceId, DateTime checkOutTime)
    {
        Attendance attendance = GetRequiredAttendance(attendanceId);
        attendance.CheckOut(checkOutTime);
        _attendanceRepository.Update(attendance);
    }

    public IReadOnlyList<Attendance> GetAttendanceByEmployee(int employeeId)
    {
        return _attendanceRepository.GetAll()
            .Where(attendance => attendance.EmployeeId == employeeId)
            .OrderByDescending(attendance => attendance.Date)
            .ToList()
            .AsReadOnly();
    }

    public IReadOnlyList<Attendance> GetDailyAttendance(DateTime date)
    {
        return _attendanceRepository.GetAll()
            .Where(attendance => attendance.Date == date.Date)
            .OrderBy(attendance => attendance.EmployeeId)
            .ToList()
            .AsReadOnly();
    }

    private Attendance GetRequiredAttendance(int attendanceId)
    {
        return _attendanceRepository.GetById(attendanceId)
            ?? throw new KeyNotFoundException($"Attendance id {attendanceId} was not found.");
    }
}
