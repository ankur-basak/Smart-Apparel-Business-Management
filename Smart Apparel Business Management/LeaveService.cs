using SmartClothingHR.Models;
using SmartClothingHR.Repositories;

namespace SmartClothingHR.Services;

public class LeaveService
{
    private readonly IRepository<LeaveRequest> _leaveRepository;
    private readonly EmployeeService _employeeService;
    private int _nextLeaveId = 1;

    public LeaveService(IRepository<LeaveRequest> leaveRepository, EmployeeService employeeService)
    {
        _leaveRepository = leaveRepository;
        _employeeService = employeeService;
    }

    public LeaveRequest SubmitLeaveRequest(
        int employeeId,
        LeaveType leaveType,
        DateTime startDate,
        DateTime endDate,
        string reason)
    {
        Employee employee = _employeeService.GetRequiredEmployee(employeeId);
        if (!employee.IsActive()) throw new InvalidOperationException("Terminated employees cannot request leave.");

        bool hasOverlap = _leaveRepository.GetAll()
            .Any(request =>
                request.EmployeeId == employeeId &&
                request.ApprovalStatus != ApprovalStatus.Rejected &&
                startDate.Date <= request.EndDate &&
                endDate.Date >= request.StartDate);

        if (hasOverlap)
        {
            throw new InvalidOperationException("This leave request overlaps with another pending or approved request.");
        }

        var leaveRequest = new LeaveRequest(_nextLeaveId++, employeeId, leaveType, startDate, endDate, reason);
        _leaveRepository.Add(leaveRequest);
        return leaveRequest;
    }

    public void ApproveLeave(int leaveId, int hrId)
    {
        LeaveRequest request = GetRequiredLeaveRequest(leaveId);
        request.Approve(hrId);
        _leaveRepository.Update(request);
    }

    public void RejectLeave(int leaveId, int hrId, string rejectionReason)
    {
        LeaveRequest request = GetRequiredLeaveRequest(leaveId);
        request.Reject(hrId, rejectionReason);
        _leaveRepository.Update(request);
    }

    public IReadOnlyList<LeaveRequest> GetPendingLeaveRequests()
    {
        return _leaveRepository.GetAll()
            .Where(request => request.ApprovalStatus == ApprovalStatus.Pending)
            .OrderBy(request => request.StartDate)
            .ToList()
            .AsReadOnly();
    }

    public IReadOnlyList<LeaveRequest> GetLeaveRequestsByEmployee(int employeeId)
    {
        return _leaveRepository.GetAll()
            .Where(request => request.EmployeeId == employeeId)
            .OrderByDescending(request => request.StartDate)
            .ToList()
            .AsReadOnly();
    }

    private LeaveRequest GetRequiredLeaveRequest(int leaveId)
    {
        return _leaveRepository.GetById(leaveId)
            ?? throw new KeyNotFoundException($"Leave request id {leaveId} was not found.");
    }
}
