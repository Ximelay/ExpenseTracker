namespace ExpenseTracker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private System.Windows.Forms.DataGridView dataGridViewExpenses;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonAddExpense;
        private System.Windows.Forms.Button buttonUpdateExpense;
        private System.Windows.Forms.Button buttonDeleteExpense;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelBudget; // Добавлена метка для бюджета

        private void InitializeComponent()
        {
            this.dataGridViewExpenses = new System.Windows.Forms.DataGridView();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonAddExpense = new System.Windows.Forms.Button();
            this.buttonUpdateExpense = new System.Windows.Forms.Button();
            this.buttonDeleteExpense = new System.Windows.Forms.Button();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelBudget = new System.Windows.Forms.Label(); // Метка для бюджета

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenses)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridViewExpenses
            // 
            this.dataGridViewExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExpenses.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewExpenses.Name = "dataGridViewExpenses";
            this.dataGridViewExpenses.Size = new System.Drawing.Size(700, 150);
            this.dataGridViewExpenses.TabIndex = 0;

            // Привязываем обработчик события SelectionChanged
            this.dataGridViewExpenses.SelectionChanged += new System.EventHandler(this.DataGridViewExpenses_SelectionChanged);

            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(100, 180);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(150, 20);
            this.textBoxCategory.TabIndex = 1;

            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(100, 210);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(150, 20);
            this.textBoxAmount.TabIndex = 2;

            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(100, 240);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(150, 20);
            this.textBoxDescription.TabIndex = 3;

            // 
            // buttonAddExpense
            // 
            this.buttonAddExpense.Location = new System.Drawing.Point(280, 210);
            this.buttonAddExpense.Name = "buttonAddExpense";
            this.buttonAddExpense.Size = new System.Drawing.Size(75, 23);
            this.buttonAddExpense.TabIndex = 4;
            this.buttonAddExpense.Text = "Add Expense";
            this.buttonAddExpense.UseVisualStyleBackColor = true;
            this.buttonAddExpense.Click += new System.EventHandler(this.AddExpenseButton_Click);

            // 
            // buttonUpdateExpense
            // 
            this.buttonUpdateExpense.Location = new System.Drawing.Point(280, 240);
            this.buttonUpdateExpense.Name = "buttonUpdateExpense";
            this.buttonUpdateExpense.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateExpense.TabIndex = 5;
            this.buttonUpdateExpense.Text = "Update";
            this.buttonUpdateExpense.UseVisualStyleBackColor = true;
            this.buttonUpdateExpense.Click += new System.EventHandler(this.UpdateExpenseButton_Click);

            // 
            // buttonDeleteExpense
            // 
            this.buttonDeleteExpense.Location = new System.Drawing.Point(370, 240);
            this.buttonDeleteExpense.Name = "buttonDeleteExpense";
            this.buttonDeleteExpense.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteExpense.TabIndex = 6;
            this.buttonDeleteExpense.Text = "Delete";
            this.buttonDeleteExpense.UseVisualStyleBackColor = true;
            this.buttonDeleteExpense.Click += new System.EventHandler(this.DeleteExpenseButton_Click);

            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(30, 183);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(52, 13);
            this.labelCategory.TabIndex = 7;
            this.labelCategory.Text = "Category:";

            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(30, 213);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(46, 13);
            this.labelAmount.TabIndex = 8;
            this.labelAmount.Text = "Amount:";

            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(30, 243);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 9;
            this.labelDescription.Text = "Description:";

            // 
            // labelBudget
            // 
            this.labelBudget.AutoSize = true;
            this.labelBudget.Location = new System.Drawing.Point(30, 270);
            this.labelBudget.Name = "labelBudget";
            this.labelBudget.Size = new System.Drawing.Size(46, 13);
            this.labelBudget.TabIndex = 10;
            this.labelBudget.Text = "Budget:";

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.labelBudget);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.buttonDeleteExpense);
            this.Controls.Add(this.buttonUpdateExpense);
            this.Controls.Add(this.buttonAddExpense);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.dataGridViewExpenses);
            this.Name = "MainForm";
            this.Text = "Expense Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

