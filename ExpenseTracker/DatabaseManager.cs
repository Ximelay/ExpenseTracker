using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    public class DatabaseManager
    {
        private static DatabaseManager _instance;
        private SQLiteConnection _connection;

        private DatabaseManager()
        {
            _connection = new SQLiteConnection(@"Data Source=C:\Users\Ximelay\Desktop\ExpenseTracker\ExpenseTracker\bin\Debug\expenses.db;Version=3;");
            _connection.Open();
        }

        public static DatabaseManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DatabaseManager();
                return _instance;
            }
        }

        public void AddExpense(string category, double amount, string description)
        {
            var command = new SQLiteCommand(
                "INSERT INTO Expenses (Date, Category, Amount, Description) VALUES (@Date, @Category, @Amount, @Description)",
                _connection);
            command.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@Category", category);
            command.Parameters.AddWithValue("@Amount", amount);
            command.Parameters.AddWithValue("@Description", description);
            command.ExecuteNonQuery();
        }

        public void UpdateExpense(int id, string category, double amount, string description)
        {
            var command = new SQLiteCommand(
                "UPDATE Expenses SET Category = @Category, Amount = @Amount, Description = @Description WHERE Id = @Id",
                _connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Category", category);
            command.Parameters.AddWithValue("@Amount", amount);
            command.Parameters.AddWithValue("@Description", description);
            command.ExecuteNonQuery();
        }

        public void DeleteExpense(int id)
        {
            var command = new SQLiteCommand("DELETE FROM Expenses WHERE Id = @Id", _connection);
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
        }

        public List<Expense> GetExpenses()
        {
            var expenses = new List<Expense>();
            var command = new SQLiteCommand("SELECT * FROM Expenses", _connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                expenses.Add(new Expense
                {
                    Id = reader.GetInt32(0),
                    Date = reader.GetString(1),
                    Category = reader.GetString(2),
                    Amount = reader.GetDouble(3),
                    Description = reader.GetString(4)
                });
            }

            return expenses;
        }
    }
}
