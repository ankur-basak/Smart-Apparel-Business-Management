namespace SmartClothingHR.Models;

public abstract class User
{
    private string _password;

    protected User(
        int userId,
        string name,
        string email,
        string phone,
        string address,
        Gender gender,
        string username,
        string password,
        UserRole role)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name is required.");
        if (string.IsNullOrWhiteSpace(username)) throw new ArgumentException("Username is required.");
        if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Password is required.");

        UserId = userId;
        Name = name;
        Email = email;
        Phone = phone;
        Address = address;
        Gender = gender;
        Username = username;
        _password = password;
        Role = role;
        Status = AccountStatus.Active;
    }

    public int UserId { get; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Phone { get; private set; }
    public string Address { get; private set; }
    public Gender Gender { get; private set; }
    public string Username { get; }
    public UserRole Role { get; }
    public AccountStatus Status { get; private set; }

    public bool Login(string username, string password)
    {
        return Status == AccountStatus.Active &&
               Username.Equals(username, StringComparison.OrdinalIgnoreCase) &&
               _password == password;
    }

    public virtual void Logout()
    {
        Console.WriteLine($"{Name} logged out successfully.");
    }

    public void ChangePassword(string oldPassword, string newPassword)
    {
        if (_password != oldPassword) throw new InvalidOperationException("Old password is incorrect.");
        if (string.IsNullOrWhiteSpace(newPassword)) throw new ArgumentException("New password is required.");

        _password = newPassword;
    }

    public void UpdateProfile(string name, string email, string phone, string address, Gender gender)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name is required.");

        Name = name;
        Email = email;
        Phone = phone;
        Address = address;
        Gender = gender;
    }

    public void DeactivateAccount()
    {
        Status = AccountStatus.Inactive;
    }

    public abstract string GetDashboardTitle();
}
