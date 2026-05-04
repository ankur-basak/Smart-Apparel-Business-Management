# 👗 Smart Apparel Business Management System

A comprehensive desktop-based business management application developed 
using **C# Windows Forms** and **Microsoft SQL Server**, designed to 
automate and streamline the daily operations of an apparel business.

---

## 📌 Project Info

## 🧩 System Roles

| Role | Responsibility |
|------|---------------|
| Admin | Full System Control |
| HR | Employee Management |
| Inventory Manager | Stock Management |
| Sales Executive | Sales Management |

---

## ✅ Common Features

- User Registration
- Login / Logout
- Password Recovery
- Profile View and Update
- Change Password
- Role-Based Dashboard Access

---

## 🔧 Module Features

### 🔴 Admin
- Manage All Users
- Add / Update / Delete Employees
- Assign Roles & Permissions
- Supplier Management
- Monitor Sales & Inventory Reports
- Backup & Restore Database

### 🟡 HR
- Onboard New Employees
- Renew Contracts & Terminations
- Salary Management
- Employee Performance Records
- Generate HR Reports

### 🟢 Inventory Manager
- Add / Update / Remove Products
- Manage Stock by Size and Color
- Low Stock Alerts
- Damage / Return Stock Entry
- View Inventory Reports

### 🔵 Sales Executive
- Create / Update / Cancel Orders
- Process Sales & Payment Collection
- Print Invoice / Receipt
- Daily Sales Report
- Customer Record Management

---

## 🗄️ Database Entities

- User (Parent Class)
- Admin
- HR
- Inventory Manager
- Sales Executive
- Vendor / Supplier
- Product Inventory
- Order Transaction

---

## 🛠️ Technologies Used

| Technology | Purpose |
|------------|---------|
| C# Windows Forms | Frontend UI |
| Microsoft SQL Server | Database |
| ADO.NET | Database Connectivity |
| Object-Oriented Programming | System Architecture |

---

## ⚙️ How to Run

1. Clone the repository
   git clone https://github.com/yourusername/Smart-Apparel-Business-Management-System.git

2. Open the solution in Visual Studio

3. Setup the database
   - Open SQL Server Management Studio (SSMS)
   - Run the SQL script from the /Database folder

4. Update the connection string in the project
   Data Source=YOUR_SERVER;Initial Catalog=LOGIN_DB;Integrated Security=True

5. Build and run the project

## 📄 License
This project is for academic purposes only.
