﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    public class Settings
    {
        public double MonthlyBudget { get; set; }

        public event Action<string> BudgetExceeded;

        public void CheckBudget(double totalExpenses)
        {
            if (totalExpenses > MonthlyBudget)
            {
                BudgetExceeded?.Invoke($"Warning: You have exceeded your budget of {MonthlyBudget:C}!");
            }
        }
    }
}