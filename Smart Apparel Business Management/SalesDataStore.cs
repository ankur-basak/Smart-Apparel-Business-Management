using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Smart_Apparel_Business_Management
{
    public class ProductItem
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }

    public class CustomerItem
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

    public class OrderItem
    {
        public int OrderID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string CustomerName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
    }

    public static class SalesDataStore
    {
        public static SqlConnection GetConnection()
        {
            string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            return new SqlConnection(cs);
        }

        public static DataTable GetProductsTable()
        {
            using (SqlConnection con = GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT ProductID, ProductName, Price, Stock FROM Products ORDER BY ProductID", con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable GetOrdersTable()
        {
            string query = @"SELECT o.OrderID, p.ProductName, o.Quantity, c.Name AS CustomerName,
                            o.UnitPrice, o.TotalAmount, o.OrderDate
                            FROM Orders o
                            INNER JOIN Products p ON o.ProductID = p.ProductID
                            INNER JOIN Customers c ON o.CustomerID = c.CustomerID
                            ORDER BY o.OrderID DESC";
            using (SqlConnection con = GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter(query, con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static List<ProductItem> GetProductsList()
        {
            List<ProductItem> list = new List<ProductItem>();
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand("SELECT ProductID, ProductName, Price, Stock FROM Products ORDER BY ProductName", con))
            {
                con.Open();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new ProductItem
                        {
                            ProductID = Convert.ToInt32(r["ProductID"]),
                            ProductName = r["ProductName"].ToString(),
                            Price = Convert.ToDecimal(r["Price"]),
                            Stock = Convert.ToInt32(r["Stock"])
                        });
                    }
                }
            }
            return list;
        }

        public static List<CustomerItem> GetCustomersList()
        {
            List<CustomerItem> list = new List<CustomerItem>();
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand("SELECT CustomerID, Name, Phone, Email FROM Customers ORDER BY Name", con))
            {
                con.Open();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new CustomerItem
                        {
                            CustomerID = Convert.ToInt32(r["CustomerID"]),
                            Name = r["Name"].ToString(),
                            Phone = r["Phone"].ToString(),
                            Email = r["Email"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public static void AddCustomer(string name, string phone, string email)
        {
            string query = "INSERT INTO Customers (Name, Phone, Email) VALUES (@name, @phone, @email)";
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void AddOrder(int productId, int customerId, int quantity)
        {
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();
                try
                {
                    decimal price;
                    int stock;
                    using (SqlCommand cmd = new SqlCommand("SELECT Price, Stock FROM Products WHERE ProductID=@pid", con, tran))
                    {
                        cmd.Parameters.AddWithValue("@pid", productId);
                        using (SqlDataReader r = cmd.ExecuteReader())
                        {
                            if (!r.Read()) throw new Exception("Product not found.");
                            price = Convert.ToDecimal(r["Price"]);
                            stock = Convert.ToInt32(r["Stock"]);
                        }
                    }
                    if (stock < quantity) throw new Exception("Not enough stock available.");
                    decimal total = price * quantity;
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Orders(ProductID, CustomerID, Quantity, UnitPrice, TotalAmount, OrderDate)
                                                           VALUES(@pid, @cid, @qty, @price, @total, GETDATE())", con, tran))
                    {
                        cmd.Parameters.AddWithValue("@pid", productId);
                        cmd.Parameters.AddWithValue("@cid", customerId);
                        cmd.Parameters.AddWithValue("@qty", quantity);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@total", total);
                        cmd.ExecuteNonQuery();
                    }
                    using (SqlCommand cmd = new SqlCommand("UPDATE Products SET Stock = Stock - @qty WHERE ProductID=@pid", con, tran))
                    {
                        cmd.Parameters.AddWithValue("@qty", quantity);
                        cmd.Parameters.AddWithValue("@pid", productId);
                        cmd.ExecuteNonQuery();
                    }
                    tran.Commit();
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
        }

        public static void UpdateOrder(int orderId, int newProductId, int newCustomerId, int newQuantity)
        {
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();
                try
                {
                    int oldProductId, oldQty;
                    using (SqlCommand cmd = new SqlCommand("SELECT ProductID, Quantity FROM Orders WHERE OrderID=@oid", con, tran))
                    {
                        cmd.Parameters.AddWithValue("@oid", orderId);
                        using (SqlDataReader r = cmd.ExecuteReader())
                        {
                            if (!r.Read()) throw new Exception("Order not found.");
                            oldProductId = Convert.ToInt32(r["ProductID"]);
                            oldQty = Convert.ToInt32(r["Quantity"]);
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("UPDATE Products SET Stock = Stock + @qty WHERE ProductID=@pid", con, tran))
                    {
                        cmd.Parameters.AddWithValue("@qty", oldQty);
                        cmd.Parameters.AddWithValue("@pid", oldProductId);
                        cmd.ExecuteNonQuery();
                    }
                    decimal price;
                    int stock;
                    using (SqlCommand cmd = new SqlCommand("SELECT Price, Stock FROM Products WHERE ProductID=@pid", con, tran))
                    {
                        cmd.Parameters.AddWithValue("@pid", newProductId);
                        using (SqlDataReader r = cmd.ExecuteReader())
                        {
                            if (!r.Read()) throw new Exception("Product not found.");
                            price = Convert.ToDecimal(r["Price"]);
                            stock = Convert.ToInt32(r["Stock"]);
                        }
                    }
                    if (stock < newQuantity) throw new Exception("Not enough stock available for update.");
                    decimal total = price * newQuantity;
                    using (SqlCommand cmd = new SqlCommand(@"UPDATE Orders SET ProductID=@pid, CustomerID=@cid, Quantity=@qty,
                                                           UnitPrice=@price, TotalAmount=@total, OrderDate=GETDATE()
                                                           WHERE OrderID=@oid", con, tran))
                    {
                        cmd.Parameters.AddWithValue("@pid", newProductId);
                        cmd.Parameters.AddWithValue("@cid", newCustomerId);
                        cmd.Parameters.AddWithValue("@qty", newQuantity);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@total", total);
                        cmd.Parameters.AddWithValue("@oid", orderId);
                        cmd.ExecuteNonQuery();
                    }
                    using (SqlCommand cmd = new SqlCommand("UPDATE Products SET Stock = Stock - @qty WHERE ProductID=@pid", con, tran))
                    {
                        cmd.Parameters.AddWithValue("@qty", newQuantity);
                        cmd.Parameters.AddWithValue("@pid", newProductId);
                        cmd.ExecuteNonQuery();
                    }
                    tran.Commit();
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
        }

        public static void DeleteOrder(int orderId)
        {
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();
                try
                {
                    int productId, qty;
                    using (SqlCommand cmd = new SqlCommand("SELECT ProductID, Quantity FROM Orders WHERE OrderID=@oid", con, tran))
                    {
                        cmd.Parameters.AddWithValue("@oid", orderId);
                        using (SqlDataReader r = cmd.ExecuteReader())
                        {
                            if (!r.Read()) throw new Exception("Order not found.");
                            productId = Convert.ToInt32(r["ProductID"]);
                            qty = Convert.ToInt32(r["Quantity"]);
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Orders WHERE OrderID=@oid", con, tran))
                    {
                        cmd.Parameters.AddWithValue("@oid", orderId);
                        cmd.ExecuteNonQuery();
                    }
                    using (SqlCommand cmd = new SqlCommand("UPDATE Products SET Stock = Stock + @qty WHERE ProductID=@pid", con, tran))
                    {
                        cmd.Parameters.AddWithValue("@qty", qty);
                        cmd.Parameters.AddWithValue("@pid", productId);
                        cmd.ExecuteNonQuery();
                    }
                    tran.Commit();
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
        }

        public static int CountProducts()
        {
            return Convert.ToInt32(ExecuteScalar("SELECT COUNT(*) FROM Products"));
        }

        public static int CountCustomers()
        {
            return Convert.ToInt32(ExecuteScalar("SELECT COUNT(*) FROM Customers"));
        }

        public static decimal TotalSales()
        {
            return Convert.ToDecimal(ExecuteScalar("SELECT ISNULL(SUM(TotalAmount), 0) FROM Orders"));
        }

        private static object ExecuteScalar(string query)
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                return cmd.ExecuteScalar();
            }
        }
    }
}
