namespace MyFirstProject
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BankName = new System.Windows.Forms.ComboBox();
            this.TimeText = new System.Windows.Forms.TextBox();
            this.PrincipalText = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time(in Year)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Principal";
            // 
            // BankName
            // 
            this.BankName.FormattingEnabled = true;
            this.BankName.Items.AddRange(new object[] {
            "BRAC",
            "DBBL",
            "HSBC"});
            this.BankName.Location = new System.Drawing.Point(128, 38);
            this.BankName.Name = "BankName";
            this.BankName.Size = new System.Drawing.Size(121, 21);
            this.BankName.TabIndex = 3;
            this.BankName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.BankName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BankName_MouseClick);
            // 
            // TimeText
            // 
            this.TimeText.Location = new System.Drawing.Point(128, 68);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(100, 20);
            this.TimeText.TabIndex = 4;
            this.TimeText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TimeText_MouseClick);
            // 
            // PrincipalText
            // 
            this.PrincipalText.Location = new System.Drawing.Point(128, 98);
            this.PrincipalText.Name = "PrincipalText";
            this.PrincipalText.Size = new System.Drawing.Size(100, 20);
            this.PrincipalText.TabIndex = 5;
            this.PrincipalText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PrincipalText_MouseClick);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(106, 168);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(143, 23);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate Interest Amount";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Interest =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(258, 296);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 331);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.PrincipalText);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.BankName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BankName;
        private System.Windows.Forms.TextBox TimeText;
        private System.Windows.Forms.TextBox PrincipalText;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ResetButton;
    }
}

