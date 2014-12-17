namespace DailyExpenseStoreApp
{
    partial class DailyExpenseUI
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
        private void InitializeComponent()
        {
            this.dailyExpenseEntryGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.particularTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.catagoryComboBox = new System.Windows.Forms.ComboBox();
            this.particularLabel = new System.Windows.Forms.Label();
            this.catagoryLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.viewSummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.showButton = new System.Windows.Forms.Button();
            this.maxExpenseTextBox = new System.Windows.Forms.TextBox();
            this.totalExpenseTextBox = new System.Windows.Forms.TextBox();
            this.maxExpenseLabel = new System.Windows.Forms.Label();
            this.totalExpenseLabel = new System.Windows.Forms.Label();
            this.viewCatagorywiseExpense = new System.Windows.Forms.GroupBox();
            this.searchResultListBox = new System.Windows.Forms.ListBox();
            this.searchShowButton = new System.Windows.Forms.Button();
            this.searchTotalTextBox = new System.Windows.Forms.TextBox();
            this.searchCatagoryComboBox = new System.Windows.Forms.ComboBox();
            this.searchCatagoryLabel = new System.Windows.Forms.Label();
            this.searchTotalLabel = new System.Windows.Forms.Label();
            this.dailyExpenseEntryGroupBox.SuspendLayout();
            this.viewSummaryGroupBox.SuspendLayout();
            this.viewCatagorywiseExpense.SuspendLayout();
            this.SuspendLayout();
            // 
            // dailyExpenseEntryGroupBox
            // 
            this.dailyExpenseEntryGroupBox.Controls.Add(this.saveButton);
            this.dailyExpenseEntryGroupBox.Controls.Add(this.particularTextBox);
            this.dailyExpenseEntryGroupBox.Controls.Add(this.amountTextBox);
            this.dailyExpenseEntryGroupBox.Controls.Add(this.catagoryComboBox);
            this.dailyExpenseEntryGroupBox.Controls.Add(this.particularLabel);
            this.dailyExpenseEntryGroupBox.Controls.Add(this.catagoryLabel);
            this.dailyExpenseEntryGroupBox.Controls.Add(this.amountLabel);
            this.dailyExpenseEntryGroupBox.Location = new System.Drawing.Point(30, 12);
            this.dailyExpenseEntryGroupBox.Name = "dailyExpenseEntryGroupBox";
            this.dailyExpenseEntryGroupBox.Size = new System.Drawing.Size(327, 188);
            this.dailyExpenseEntryGroupBox.TabIndex = 0;
            this.dailyExpenseEntryGroupBox.TabStop = false;
            this.dailyExpenseEntryGroupBox.Text = "Daily Expense Entry";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(246, 152);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // particularTextBox
            // 
            this.particularTextBox.Location = new System.Drawing.Point(112, 80);
            this.particularTextBox.Multiline = true;
            this.particularTextBox.Name = "particularTextBox";
            this.particularTextBox.Size = new System.Drawing.Size(209, 45);
            this.particularTextBox.TabIndex = 1;
            this.particularTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.particularTextBox_MouseClick);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(112, 27);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(209, 20);
            this.amountTextBox.TabIndex = 1;
            this.amountTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.amountTextBox_MouseClick);
            // 
            // catagoryComboBox
            // 
            this.catagoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catagoryComboBox.FormattingEnabled = true;
            this.catagoryComboBox.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.catagoryComboBox.Location = new System.Drawing.Point(112, 53);
            this.catagoryComboBox.Name = "catagoryComboBox";
            this.catagoryComboBox.Size = new System.Drawing.Size(209, 21);
            this.catagoryComboBox.TabIndex = 3;
            // 
            // particularLabel
            // 
            this.particularLabel.AutoSize = true;
            this.particularLabel.Location = new System.Drawing.Point(51, 83);
            this.particularLabel.Name = "particularLabel";
            this.particularLabel.Size = new System.Drawing.Size(51, 13);
            this.particularLabel.TabIndex = 0;
            this.particularLabel.Text = "Particular";
            // 
            // catagoryLabel
            // 
            this.catagoryLabel.AutoSize = true;
            this.catagoryLabel.Location = new System.Drawing.Point(51, 56);
            this.catagoryLabel.Name = "catagoryLabel";
            this.catagoryLabel.Size = new System.Drawing.Size(49, 13);
            this.catagoryLabel.TabIndex = 0;
            this.catagoryLabel.Text = "Catagory";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(57, 30);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 0;
            this.amountLabel.Text = "Amount";
            // 
            // viewSummaryGroupBox
            // 
            this.viewSummaryGroupBox.Controls.Add(this.showButton);
            this.viewSummaryGroupBox.Controls.Add(this.maxExpenseTextBox);
            this.viewSummaryGroupBox.Controls.Add(this.totalExpenseTextBox);
            this.viewSummaryGroupBox.Controls.Add(this.maxExpenseLabel);
            this.viewSummaryGroupBox.Controls.Add(this.totalExpenseLabel);
            this.viewSummaryGroupBox.Location = new System.Drawing.Point(30, 231);
            this.viewSummaryGroupBox.Name = "viewSummaryGroupBox";
            this.viewSummaryGroupBox.Size = new System.Drawing.Size(327, 138);
            this.viewSummaryGroupBox.TabIndex = 0;
            this.viewSummaryGroupBox.TabStop = false;
            this.viewSummaryGroupBox.Text = "View Summary";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(246, 25);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // maxExpenseTextBox
            // 
            this.maxExpenseTextBox.BackColor = System.Drawing.Color.White;
            this.maxExpenseTextBox.Location = new System.Drawing.Point(112, 90);
            this.maxExpenseTextBox.Name = "maxExpenseTextBox";
            this.maxExpenseTextBox.ReadOnly = true;
            this.maxExpenseTextBox.Size = new System.Drawing.Size(209, 20);
            this.maxExpenseTextBox.TabIndex = 1;
            // 
            // totalExpenseTextBox
            // 
            this.totalExpenseTextBox.BackColor = System.Drawing.Color.White;
            this.totalExpenseTextBox.Location = new System.Drawing.Point(112, 64);
            this.totalExpenseTextBox.Name = "totalExpenseTextBox";
            this.totalExpenseTextBox.ReadOnly = true;
            this.totalExpenseTextBox.Size = new System.Drawing.Size(209, 20);
            this.totalExpenseTextBox.TabIndex = 1;
            // 
            // maxExpenseLabel
            // 
            this.maxExpenseLabel.AutoSize = true;
            this.maxExpenseLabel.Location = new System.Drawing.Point(6, 93);
            this.maxExpenseLabel.Name = "maxExpenseLabel";
            this.maxExpenseLabel.Size = new System.Drawing.Size(95, 13);
            this.maxExpenseLabel.TabIndex = 0;
            this.maxExpenseLabel.Text = "Maximum Expense";
            // 
            // totalExpenseLabel
            // 
            this.totalExpenseLabel.AutoSize = true;
            this.totalExpenseLabel.Location = new System.Drawing.Point(25, 67);
            this.totalExpenseLabel.Name = "totalExpenseLabel";
            this.totalExpenseLabel.Size = new System.Drawing.Size(75, 13);
            this.totalExpenseLabel.TabIndex = 0;
            this.totalExpenseLabel.Text = "Total Expense";
            // 
            // viewCatagorywiseExpense
            // 
            this.viewCatagorywiseExpense.Controls.Add(this.searchResultListBox);
            this.viewCatagorywiseExpense.Controls.Add(this.searchShowButton);
            this.viewCatagorywiseExpense.Controls.Add(this.searchTotalTextBox);
            this.viewCatagorywiseExpense.Controls.Add(this.searchCatagoryComboBox);
            this.viewCatagorywiseExpense.Controls.Add(this.searchCatagoryLabel);
            this.viewCatagorywiseExpense.Controls.Add(this.searchTotalLabel);
            this.viewCatagorywiseExpense.Location = new System.Drawing.Point(439, 12);
            this.viewCatagorywiseExpense.Name = "viewCatagorywiseExpense";
            this.viewCatagorywiseExpense.Size = new System.Drawing.Size(347, 357);
            this.viewCatagorywiseExpense.TabIndex = 1;
            this.viewCatagorywiseExpense.TabStop = false;
            this.viewCatagorywiseExpense.Text = "View Catagorywise Expense";
            // 
            // searchResultListBox
            // 
            this.searchResultListBox.FormattingEnabled = true;
            this.searchResultListBox.Location = new System.Drawing.Point(74, 113);
            this.searchResultListBox.Name = "searchResultListBox";
            this.searchResultListBox.Size = new System.Drawing.Size(261, 199);
            this.searchResultListBox.TabIndex = 4;
            // 
            // searchShowButton
            // 
            this.searchShowButton.Location = new System.Drawing.Point(260, 73);
            this.searchShowButton.Name = "searchShowButton";
            this.searchShowButton.Size = new System.Drawing.Size(75, 23);
            this.searchShowButton.TabIndex = 2;
            this.searchShowButton.Text = "Show";
            this.searchShowButton.UseVisualStyleBackColor = true;
            this.searchShowButton.Click += new System.EventHandler(this.searchShowButton_Click);
            // 
            // searchTotalTextBox
            // 
            this.searchTotalTextBox.BackColor = System.Drawing.Color.White;
            this.searchTotalTextBox.Location = new System.Drawing.Point(181, 327);
            this.searchTotalTextBox.Name = "searchTotalTextBox";
            this.searchTotalTextBox.ReadOnly = true;
            this.searchTotalTextBox.Size = new System.Drawing.Size(154, 20);
            this.searchTotalTextBox.TabIndex = 1;
            // 
            // searchCatagoryComboBox
            // 
            this.searchCatagoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchCatagoryComboBox.FormattingEnabled = true;
            this.searchCatagoryComboBox.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.searchCatagoryComboBox.Location = new System.Drawing.Point(126, 27);
            this.searchCatagoryComboBox.Name = "searchCatagoryComboBox";
            this.searchCatagoryComboBox.Size = new System.Drawing.Size(209, 21);
            this.searchCatagoryComboBox.TabIndex = 3;
            // 
            // searchCatagoryLabel
            // 
            this.searchCatagoryLabel.AutoSize = true;
            this.searchCatagoryLabel.Location = new System.Drawing.Point(71, 30);
            this.searchCatagoryLabel.Name = "searchCatagoryLabel";
            this.searchCatagoryLabel.Size = new System.Drawing.Size(49, 13);
            this.searchCatagoryLabel.TabIndex = 0;
            this.searchCatagoryLabel.Text = "Catagory";
            // 
            // searchTotalLabel
            // 
            this.searchTotalLabel.AutoSize = true;
            this.searchTotalLabel.Location = new System.Drawing.Point(144, 330);
            this.searchTotalLabel.Name = "searchTotalLabel";
            this.searchTotalLabel.Size = new System.Drawing.Size(31, 13);
            this.searchTotalLabel.TabIndex = 0;
            this.searchTotalLabel.Text = "Total";
            // 
            // DailyExpenseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 376);
            this.Controls.Add(this.viewCatagorywiseExpense);
            this.Controls.Add(this.viewSummaryGroupBox);
            this.Controls.Add(this.dailyExpenseEntryGroupBox);
            this.Name = "DailyExpenseUI";
            this.Text = "Daily Expense";
            this.Load += new System.EventHandler(this.DailyExpenseUI_Load);
            this.dailyExpenseEntryGroupBox.ResumeLayout(false);
            this.dailyExpenseEntryGroupBox.PerformLayout();
            this.viewSummaryGroupBox.ResumeLayout(false);
            this.viewSummaryGroupBox.PerformLayout();
            this.viewCatagorywiseExpense.ResumeLayout(false);
            this.viewCatagorywiseExpense.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dailyExpenseEntryGroupBox;
        private System.Windows.Forms.TextBox particularTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label particularLabel;
        private System.Windows.Forms.Label catagoryLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox viewSummaryGroupBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox maxExpenseTextBox;
        private System.Windows.Forms.TextBox totalExpenseTextBox;
        private System.Windows.Forms.Label maxExpenseLabel;
        private System.Windows.Forms.Label totalExpenseLabel;
        private System.Windows.Forms.GroupBox viewCatagorywiseExpense;
        private System.Windows.Forms.Label searchCatagoryLabel;
        private System.Windows.Forms.ListBox searchResultListBox;
        private System.Windows.Forms.Button searchShowButton;
        private System.Windows.Forms.ComboBox searchCatagoryComboBox;
        private System.Windows.Forms.TextBox searchTotalTextBox;
        private System.Windows.Forms.Label searchTotalLabel;
        private System.Windows.Forms.ComboBox catagoryComboBox;
    }
}

