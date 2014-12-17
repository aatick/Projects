namespace AddressBookApp
{
    partial class AddressBookUI
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PersonalContactTextBox = new System.Windows.Forms.TextBox();
            this.homeContactTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.homeaddressTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.infoListView = new System.Windows.Forms.ListView();
            this.searchItemComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.catagoryNameLabel = new System.Windows.Forms.Label();
            this.catagoryNameTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(194, 10);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(300, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 41);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(194, 38);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(300, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Personal Contact Number";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Home Contact Number";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PersonalContactTextBox
            // 
            this.PersonalContactTextBox.Location = new System.Drawing.Point(194, 64);
            this.PersonalContactTextBox.Name = "PersonalContactTextBox";
            this.PersonalContactTextBox.Size = new System.Drawing.Size(300, 20);
            this.PersonalContactTextBox.TabIndex = 1;
            // 
            // homeContactTextBox
            // 
            this.homeContactTextBox.Location = new System.Drawing.Point(194, 90);
            this.homeContactTextBox.Name = "homeContactTextBox";
            this.homeContactTextBox.Size = new System.Drawing.Size(300, 20);
            this.homeContactTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Home Address";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // homeaddressTextBox
            // 
            this.homeaddressTextBox.Location = new System.Drawing.Point(194, 116);
            this.homeaddressTextBox.Multiline = true;
            this.homeaddressTextBox.Name = "homeaddressTextBox";
            this.homeaddressTextBox.Size = new System.Drawing.Size(300, 58);
            this.homeaddressTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(419, 180);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(483, 551);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // infoListView
            // 
            this.infoListView.AllowColumnReorder = true;
            this.infoListView.GridLines = true;
            this.infoListView.LabelEdit = true;
            this.infoListView.Location = new System.Drawing.Point(258, 242);
            this.infoListView.Name = "infoListView";
            this.infoListView.Size = new System.Drawing.Size(300, 294);
            this.infoListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.infoListView.TabIndex = 3;
            this.infoListView.UseCompatibleStateImageBehavior = false;
            this.infoListView.View = System.Windows.Forms.View.Details;
            // 
            // searchItemComboBox
            // 
            this.searchItemComboBox.FormattingEnabled = true;
            this.searchItemComboBox.Items.AddRange(new object[] {
            "Name",
            "Email",
            "Personal Contact"});
            this.searchItemComboBox.Location = new System.Drawing.Point(124, 245);
            this.searchItemComboBox.Name = "searchItemComboBox";
            this.searchItemComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchItemComboBox.TabIndex = 4;
            this.searchItemComboBox.SelectedIndexChanged += new System.EventHandler(this.searchItemComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Search By";
            // 
            // catagoryNameLabel
            // 
            this.catagoryNameLabel.AutoSize = true;
            this.catagoryNameLabel.Location = new System.Drawing.Point(33, 307);
            this.catagoryNameLabel.Name = "catagoryNameLabel";
            this.catagoryNameLabel.Size = new System.Drawing.Size(35, 13);
            this.catagoryNameLabel.TabIndex = 6;
            this.catagoryNameLabel.Text = "label7";
            // 
            // catagoryNameTextBox
            // 
            this.catagoryNameTextBox.Location = new System.Drawing.Point(124, 304);
            this.catagoryNameTextBox.Name = "catagoryNameTextBox";
            this.catagoryNameTextBox.Size = new System.Drawing.Size(96, 20);
            this.catagoryNameTextBox.TabIndex = 7;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(108, 342);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // AddressBookUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 577);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.catagoryNameTextBox);
            this.Controls.Add(this.catagoryNameLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.searchItemComboBox);
            this.Controls.Add(this.infoListView);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.homeaddressTextBox);
            this.Controls.Add(this.homeContactTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.PersonalContactTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddressBookUI";
            this.Text = "AddressBookUI";
            this.Load += new System.EventHandler(this.AddressBookUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PersonalContactTextBox;
        private System.Windows.Forms.TextBox homeContactTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox homeaddressTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ListView infoListView;
        private System.Windows.Forms.ComboBox searchItemComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label catagoryNameLabel;
        private System.Windows.Forms.TextBox catagoryNameTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}

