namespace SmartClothingHR.Models;

public class LeaveRequest
{
    public LeaveRequest(
        int leaveId,
        int employeeId,
        LeaveType leaveType,
        DateTime startDate,
        DateTime endDate,
        string reason)
    {
        if (endDate.Date < startDate.Date) throw new InvalidOperationException("End date cannot be before start date.");
        if (string.IsNullOrWhiteSpace(reason)) throw new ArgumentException("Leave reason is required.");

        LeaveId = leaveId;
        EmployeeId = employeeId;
        LeaveType = leaveType;
        StartDate = startDate.Date;
        EndDate = endDate.Date;
        Reason = reason;
        ApprovalStatus = ApprovalStatus.Pending;
    }

    public int LeaveId { get; }
    public int EmployeeId { get; }
    public LeaveType LeaveType { get; }
    public DateTime StartDate { get; }
    public DateTime EndDate { get; }
    public string Reason { get; }
    public ApprovalStatus ApprovalStatus { get; private set; }
    public int? ReviewedByHrId { get; private set; }
    public string? ReviewNote { get; private set; }

    public int GetTotalDays()
    {
        return (EndDate - StartDate).Days + 1;
    }

    public void Approve(int hrId)
    {
        EnsurePending();
        ApprovalStatus = ApprovalStatus.Approved;
        ReviewedByHrId = hrId;
        ReviewNote = "Approved";
    }

    public void Reject(int hrId, string rejectionReason)
    {
        EnsurePending();
        if (string.IsNullOrWhiteSpace(rejectionReason)) throw new ArgumentException("Rejection reason is required.");

        ApprovalStatus = ApprovalStatus.Rejected;
        ReviewedByHrId = hrId;
        ReviewNote = rejectionReason;
    }

    private void EnsurePending()
    {
        if (ApprovalStatus != ApprovalStatus.Pending)
        {
            throw new InvalidOperationException("Only pending leave requests can be reviewed.");
        }
    }
}
