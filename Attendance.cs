namespace SmartClothingHR.Models;

public class Attendance
{
    public Attendance(int attendanceId, int employeeId, DateTime checkInTime, TimeSpan officeStartTime)
    {
        AttendanceId = attendanceId;
        EmployeeId = employeeId;
        Date = checkInTime.Date;
        CheckInTime = checkInTime;
        AttendanceStatus = checkInTime.TimeOfDay > officeStartTime ? AttendanceStatus.Late : AttendanceStatus.Present;
    }

    public int AttendanceId { get; }
    public int EmployeeId { get; }
    public DateTime Date { get; }
    public DateTime CheckInTime { get; }
    public DateTime? CheckOutTime { get; private set; }
    public AttendanceStatus AttendanceStatus { get; private set; }

    public void CheckOut(DateTime checkOutTime)
    {
        if (checkOutTime < CheckInTime) throw new InvalidOperationException("Check-out time cannot be before check-in time.");

        CheckOutTime = checkOutTime;

        if (GetWorkedHours() < 4)
        {
            AttendanceStatus = AttendanceStatus.HalfDay;
        }
    }

    public void MarkAsLeave()
    {
        AttendanceStatus = AttendanceStatus.OnLeave;
    }

    public double GetWorkedHours()
    {
        if (CheckOutTime is null) return 0;

        return (CheckOutTime.Value - CheckInTime).TotalHours;
    }
}
