using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    public class Expense
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Category { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
    }
}
