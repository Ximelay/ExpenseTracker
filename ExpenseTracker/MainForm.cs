using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{

    public partial class MainForm : Form
    {
        private Settings _settings;
        private bool _isInitialized = false;

        public MainForm()
        {
            InitializeComponent();

            _settings = new Settings
            {
                MonthlyBudget = 2000 // Установите нужный бюджет
            };

            _settings.BudgetExceeded += OnBudgetExceeded;

            labelBudget.Text = $"Budget: {_settings.MonthlyBudget:C}";

            LoadExpenses();

            // Приложение завершило инициализацию
            _isInitialized = true;
        }

        private void OnBudgetExceeded(string message)
        {
            MessageBox.Show(message, "Budget Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void AddExpenseButton_Click(object sender, EventArgs e)
        {
            string category = textBoxCategory.Text;
            double amount = double.Parse(textBoxAmount.Text);
            string description = textBoxDescription.Text;

            DatabaseManager.Instance.AddExpense(category, amount, description);
            LoadExpenses();
        }

        private void DataGridViewExpenses_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewExpenses.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewExpenses.SelectedRows[0];
                textBoxCategory.Text = selectedRow.Cells["Category"].Value?.ToString();
                textBoxAmount.Text = selectedRow.Cells["Amount"].Value?.ToString();
                textBoxDescription.Text = selectedRow.Cells["Description"].Value?.ToString();
            }
        }

        private void UpdateExpenseButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewExpenses.SelectedRows.Count > 0)
            {
                // Получаем данные из выделенной строки
                int id = (int)dataGridViewExpenses.SelectedRows[0].Cells["Id"].Value;
                string category = textBoxCategory.Text;
                double amount;
                if (!double.TryParse(textBoxAmount.Text, out amount))
                {
                    MessageBox.Show("Invalid amount. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string description = textBoxDescription.Text;

                // Обновляем запись в базе данных
                DatabaseManager.Instance.UpdateExpense(id, category, amount, description);
                LoadExpenses();
            }
            else
            {
                MessageBox.Show("Please select a record to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteExpenseButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewExpenses.SelectedRows.Count > 0)
            {
                // Получаем Id выделенной строки
                int id = (int)dataGridViewExpenses.SelectedRows[0].Cells["Id"].Value;

                // Удаляем запись из базы данных
                DatabaseManager.Instance.DeleteExpense(id);
                LoadExpenses();
            }
            else
            {
                MessageBox.Show("Please select a record to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadExpenses()
        {
            var expenses = DatabaseManager.Instance.GetExpenses();
            dataGridViewExpenses.DataSource = expenses;

            double totalExpenses = expenses.Sum(e => e.Amount);

            // Проверяем бюджет только после полной инициализации
            if (_isInitialized)
            {
                _settings.CheckBudget(totalExpenses);
            }
        }
    }
}
