using System;

namespace BDWeatherUpdateApp
{
    partial class WeatherUpdateUI
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
            this.cityNameLabel = new System.Windows.Forms.Label();
            this.cityNamesComboBox = new System.Windows.Forms.ComboBox();
            this.cityChoiceLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.tomorrowLabel = new System.Windows.Forms.Label();
            this.dayAfterTomorrowLabel = new System.Windows.Forms.Label();
            this.mornLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.eveLabel = new System.Windows.Forms.Label();
            this.nightLabel = new System.Windows.Forms.Label();
            this.todayMornLabel = new System.Windows.Forms.Label();
            this.todayDayLabel = new System.Windows.Forms.Label();
            this.todayEveLabel = new System.Windows.Forms.Label();
            this.todayNightLabel = new System.Windows.Forms.Label();
            this.tomorrowMornLabel = new System.Windows.Forms.Label();
            this.tomorrowDayLabel = new System.Windows.Forms.Label();
            this.tomorrowEveLabel = new System.Windows.Forms.Label();
            this.tomorrowNightLabel = new System.Windows.Forms.Label();
            this.dayAfterTomorrowMornLabel = new System.Windows.Forms.Label();
            this.dayAfterTomorrowDayLabel = new System.Windows.Forms.Label();
            this.dayAfterTomorrowEveLabel = new System.Windows.Forms.Label();
            this.dayAfterTomorrowNightLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.maxLabel = new System.Windows.Forms.Label();
            this.todayMaxLabel = new System.Windows.Forms.Label();
            this.tomorrowMaxLabel = new System.Windows.Forms.Label();
            this.dayAfterTomorrowMaxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.todayMinLabel = new System.Windows.Forms.Label();
            this.tomorrowMinLabel = new System.Windows.Forms.Label();
            this.dayAfterTomorrowMinLabel = new System.Windows.Forms.Label();
            this.digitalWatchLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityNameLabel
            // 
            this.cityNameLabel.AutoSize = true;
            this.cityNameLabel.Font = new System.Drawing.Font("SutonnyOMJ", 20.25F);
            this.cityNameLabel.Location = new System.Drawing.Point(196, -1);
            this.cityNameLabel.Name = "cityNameLabel";
            this.cityNameLabel.Size = new System.Drawing.Size(355, 32);
            this.cityNameLabel.TabIndex = 0;
            this.cityNameLabel.Text = " (বাংলাদেশ) শহরের আবহাওয়ার পূর্বাভাস";
            // 
            // cityNamesComboBox
            // 
            this.cityNamesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityNamesComboBox.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.cityNamesComboBox.FormattingEnabled = true;
            this.cityNamesComboBox.Items.AddRange(new object[] {
            "ঢাকা",
            "চট্টগ্রাম",
            "খুলনা",
            "রাজশাহী",
            "বরিশাল",
            "সিলেট",
            "রংপুর",
            "বগুড়া",
            "কুমিল্লা",
            "সাতক্ষীরা"});
            this.cityNamesComboBox.Location = new System.Drawing.Point(301, 216);
            this.cityNamesComboBox.Name = "cityNamesComboBox";
            this.cityNamesComboBox.Size = new System.Drawing.Size(121, 30);
            this.cityNamesComboBox.TabIndex = 21;
            this.cityNamesComboBox.SelectedIndexChanged += new System.EventHandler(this.cityNamesComboBox_SelectedIndexChanged);
            // 
            // cityChoiceLabel
            // 
            this.cityChoiceLabel.AutoSize = true;
            this.cityChoiceLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.cityChoiceLabel.Location = new System.Drawing.Point(193, 219);
            this.cityChoiceLabel.Name = "cityChoiceLabel";
            this.cityChoiceLabel.Size = new System.Drawing.Size(88, 22);
            this.cityChoiceLabel.TabIndex = 22;
            this.cityChoiceLabel.Text = "শহরের নাম :";
            // 
            // todayLabel
            // 
            this.todayLabel.AutoSize = true;
            this.todayLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.todayLabel.Location = new System.Drawing.Point(39, 58);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(36, 22);
            this.todayLabel.TabIndex = 1;
            this.todayLabel.Text = "আজ";
            // 
            // tomorrowLabel
            // 
            this.tomorrowLabel.AutoSize = true;
            this.tomorrowLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.tomorrowLabel.Location = new System.Drawing.Point(-1, 115);
            this.tomorrowLabel.Name = "tomorrowLabel";
            this.tomorrowLabel.Size = new System.Drawing.Size(76, 22);
            this.tomorrowLabel.TabIndex = 2;
            this.tomorrowLabel.Text = "আগামীকাল";
            // 
            // dayAfterTomorrowLabel
            // 
            this.dayAfterTomorrowLabel.AutoSize = true;
            this.dayAfterTomorrowLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.dayAfterTomorrowLabel.Location = new System.Drawing.Point(38, 175);
            this.dayAfterTomorrowLabel.Name = "dayAfterTomorrowLabel";
            this.dayAfterTomorrowLabel.Size = new System.Drawing.Size(37, 22);
            this.dayAfterTomorrowLabel.TabIndex = 3;
            this.dayAfterTomorrowLabel.Text = "পরশু";
            // 
            // mornLabel
            // 
            this.mornLabel.AutoSize = true;
            this.mornLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.mornLabel.Location = new System.Drawing.Point(229, 32);
            this.mornLabel.Name = "mornLabel";
            this.mornLabel.Size = new System.Drawing.Size(45, 22);
            this.mornLabel.TabIndex = 4;
            this.mornLabel.Text = "সকাল";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.dayLabel.Location = new System.Drawing.Point(359, 32);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(37, 22);
            this.dayLabel.TabIndex = 5;
            this.dayLabel.Text = "দুপুর";
            // 
            // eveLabel
            // 
            this.eveLabel.AutoSize = true;
            this.eveLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.eveLabel.Location = new System.Drawing.Point(458, 32);
            this.eveLabel.Name = "eveLabel";
            this.eveLabel.Size = new System.Drawing.Size(48, 22);
            this.eveLabel.TabIndex = 6;
            this.eveLabel.Text = "বিকাল";
            // 
            // nightLabel
            // 
            this.nightLabel.AutoSize = true;
            this.nightLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.nightLabel.Location = new System.Drawing.Point(557, 32);
            this.nightLabel.Name = "nightLabel";
            this.nightLabel.Size = new System.Drawing.Size(36, 22);
            this.nightLabel.TabIndex = 7;
            this.nightLabel.Text = "রাত্রী";
            // 
            // todayMornLabel
            // 
            this.todayMornLabel.AutoSize = true;
            this.todayMornLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.todayMornLabel.Location = new System.Drawing.Point(229, 59);
            this.todayMornLabel.Name = "todayMornLabel";
            this.todayMornLabel.Size = new System.Drawing.Size(46, 22);
            this.todayMornLabel.TabIndex = 8;
            this.todayMornLabel.Text = "------";
            // 
            // todayDayLabel
            // 
            this.todayDayLabel.AutoSize = true;
            this.todayDayLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.todayDayLabel.Location = new System.Drawing.Point(359, 59);
            this.todayDayLabel.Name = "todayDayLabel";
            this.todayDayLabel.Size = new System.Drawing.Size(46, 22);
            this.todayDayLabel.TabIndex = 9;
            this.todayDayLabel.Text = "------";
            // 
            // todayEveLabel
            // 
            this.todayEveLabel.AutoSize = true;
            this.todayEveLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.todayEveLabel.Location = new System.Drawing.Point(458, 59);
            this.todayEveLabel.Name = "todayEveLabel";
            this.todayEveLabel.Size = new System.Drawing.Size(46, 22);
            this.todayEveLabel.TabIndex = 10;
            this.todayEveLabel.Text = "------";
            // 
            // todayNightLabel
            // 
            this.todayNightLabel.AutoSize = true;
            this.todayNightLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.todayNightLabel.Location = new System.Drawing.Point(557, 59);
            this.todayNightLabel.Name = "todayNightLabel";
            this.todayNightLabel.Size = new System.Drawing.Size(46, 22);
            this.todayNightLabel.TabIndex = 11;
            this.todayNightLabel.Text = "------";
            // 
            // tomorrowMornLabel
            // 
            this.tomorrowMornLabel.AutoSize = true;
            this.tomorrowMornLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.tomorrowMornLabel.Location = new System.Drawing.Point(229, 116);
            this.tomorrowMornLabel.Name = "tomorrowMornLabel";
            this.tomorrowMornLabel.Size = new System.Drawing.Size(46, 22);
            this.tomorrowMornLabel.TabIndex = 12;
            this.tomorrowMornLabel.Text = "------";
            // 
            // tomorrowDayLabel
            // 
            this.tomorrowDayLabel.AutoSize = true;
            this.tomorrowDayLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.tomorrowDayLabel.Location = new System.Drawing.Point(359, 116);
            this.tomorrowDayLabel.Name = "tomorrowDayLabel";
            this.tomorrowDayLabel.Size = new System.Drawing.Size(46, 22);
            this.tomorrowDayLabel.TabIndex = 13;
            this.tomorrowDayLabel.Text = "------";
            // 
            // tomorrowEveLabel
            // 
            this.tomorrowEveLabel.AutoSize = true;
            this.tomorrowEveLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.tomorrowEveLabel.Location = new System.Drawing.Point(458, 116);
            this.tomorrowEveLabel.Name = "tomorrowEveLabel";
            this.tomorrowEveLabel.Size = new System.Drawing.Size(46, 22);
            this.tomorrowEveLabel.TabIndex = 14;
            this.tomorrowEveLabel.Text = "------";
            // 
            // tomorrowNightLabel
            // 
            this.tomorrowNightLabel.AutoSize = true;
            this.tomorrowNightLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.tomorrowNightLabel.Location = new System.Drawing.Point(557, 116);
            this.tomorrowNightLabel.Name = "tomorrowNightLabel";
            this.tomorrowNightLabel.Size = new System.Drawing.Size(46, 22);
            this.tomorrowNightLabel.TabIndex = 15;
            this.tomorrowNightLabel.Text = "------";
            // 
            // dayAfterTomorrowMornLabel
            // 
            this.dayAfterTomorrowMornLabel.AutoSize = true;
            this.dayAfterTomorrowMornLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.dayAfterTomorrowMornLabel.Location = new System.Drawing.Point(229, 175);
            this.dayAfterTomorrowMornLabel.Name = "dayAfterTomorrowMornLabel";
            this.dayAfterTomorrowMornLabel.Size = new System.Drawing.Size(46, 22);
            this.dayAfterTomorrowMornLabel.TabIndex = 16;
            this.dayAfterTomorrowMornLabel.Text = "------";
            // 
            // dayAfterTomorrowDayLabel
            // 
            this.dayAfterTomorrowDayLabel.AutoSize = true;
            this.dayAfterTomorrowDayLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.dayAfterTomorrowDayLabel.Location = new System.Drawing.Point(359, 175);
            this.dayAfterTomorrowDayLabel.Name = "dayAfterTomorrowDayLabel";
            this.dayAfterTomorrowDayLabel.Size = new System.Drawing.Size(46, 22);
            this.dayAfterTomorrowDayLabel.TabIndex = 17;
            this.dayAfterTomorrowDayLabel.Text = "------";
            // 
            // dayAfterTomorrowEveLabel
            // 
            this.dayAfterTomorrowEveLabel.AutoSize = true;
            this.dayAfterTomorrowEveLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.dayAfterTomorrowEveLabel.Location = new System.Drawing.Point(460, 175);
            this.dayAfterTomorrowEveLabel.Name = "dayAfterTomorrowEveLabel";
            this.dayAfterTomorrowEveLabel.Size = new System.Drawing.Size(46, 22);
            this.dayAfterTomorrowEveLabel.TabIndex = 18;
            this.dayAfterTomorrowEveLabel.Text = "------";
            // 
            // dayAfterTomorrowNightLabel
            // 
            this.dayAfterTomorrowNightLabel.AutoSize = true;
            this.dayAfterTomorrowNightLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.dayAfterTomorrowNightLabel.Location = new System.Drawing.Point(557, 175);
            this.dayAfterTomorrowNightLabel.Name = "dayAfterTomorrowNightLabel";
            this.dayAfterTomorrowNightLabel.Size = new System.Drawing.Size(46, 22);
            this.dayAfterTomorrowNightLabel.TabIndex = 19;
            this.dayAfterTomorrowNightLabel.Text = "------";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(684, 219);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 20;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.maxLabel.Location = new System.Drawing.Point(637, 32);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(51, 22);
            this.maxLabel.TabIndex = 23;
            this.maxLabel.Text = "সর্বোচ্চ";
            // 
            // todayMaxLabel
            // 
            this.todayMaxLabel.AutoSize = true;
            this.todayMaxLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.todayMaxLabel.Location = new System.Drawing.Point(637, 59);
            this.todayMaxLabel.Name = "todayMaxLabel";
            this.todayMaxLabel.Size = new System.Drawing.Size(46, 22);
            this.todayMaxLabel.TabIndex = 24;
            this.todayMaxLabel.Text = "------";
            // 
            // tomorrowMaxLabel
            // 
            this.tomorrowMaxLabel.AutoSize = true;
            this.tomorrowMaxLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.tomorrowMaxLabel.Location = new System.Drawing.Point(637, 116);
            this.tomorrowMaxLabel.Name = "tomorrowMaxLabel";
            this.tomorrowMaxLabel.Size = new System.Drawing.Size(46, 22);
            this.tomorrowMaxLabel.TabIndex = 24;
            this.tomorrowMaxLabel.Text = "------";
            // 
            // dayAfterTomorrowMaxLabel
            // 
            this.dayAfterTomorrowMaxLabel.AutoSize = true;
            this.dayAfterTomorrowMaxLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.dayAfterTomorrowMaxLabel.Location = new System.Drawing.Point(637, 175);
            this.dayAfterTomorrowMaxLabel.Name = "dayAfterTomorrowMaxLabel";
            this.dayAfterTomorrowMaxLabel.Size = new System.Drawing.Size(46, 22);
            this.dayAfterTomorrowMaxLabel.TabIndex = 24;
            this.dayAfterTomorrowMaxLabel.Text = "------";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.minLabel.Location = new System.Drawing.Point(709, 32);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(50, 22);
            this.minLabel.TabIndex = 23;
            this.minLabel.Text = "সর্বনিম্ন";
            // 
            // todayMinLabel
            // 
            this.todayMinLabel.AutoSize = true;
            this.todayMinLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.todayMinLabel.Location = new System.Drawing.Point(709, 59);
            this.todayMinLabel.Name = "todayMinLabel";
            this.todayMinLabel.Size = new System.Drawing.Size(46, 22);
            this.todayMinLabel.TabIndex = 24;
            this.todayMinLabel.Text = "------";
            // 
            // tomorrowMinLabel
            // 
            this.tomorrowMinLabel.AutoSize = true;
            this.tomorrowMinLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.tomorrowMinLabel.Location = new System.Drawing.Point(709, 116);
            this.tomorrowMinLabel.Name = "tomorrowMinLabel";
            this.tomorrowMinLabel.Size = new System.Drawing.Size(46, 22);
            this.tomorrowMinLabel.TabIndex = 24;
            this.tomorrowMinLabel.Text = "------";
            // 
            // dayAfterTomorrowMinLabel
            // 
            this.dayAfterTomorrowMinLabel.AutoSize = true;
            this.dayAfterTomorrowMinLabel.Font = new System.Drawing.Font("SutonnyOMJ", 14.25F);
            this.dayAfterTomorrowMinLabel.Location = new System.Drawing.Point(709, 175);
            this.dayAfterTomorrowMinLabel.Name = "dayAfterTomorrowMinLabel";
            this.dayAfterTomorrowMinLabel.Size = new System.Drawing.Size(46, 22);
            this.dayAfterTomorrowMinLabel.TabIndex = 24;
            this.dayAfterTomorrowMinLabel.Text = "------";
            // 
            // digitalWatchLabel
            // 
            this.digitalWatchLabel.AutoSize = true;
            this.digitalWatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.digitalWatchLabel.Location = new System.Drawing.Point(649, 4);
            this.digitalWatchLabel.Name = "digitalWatchLabel";
            this.digitalWatchLabel.Size = new System.Drawing.Size(53, 24);
            this.digitalWatchLabel.TabIndex = 25;
            this.digitalWatchLabel.Text = "Time";
            // 
            // WeatherUpdateUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(766, 254);
            this.Controls.Add(this.digitalWatchLabel);
            this.Controls.Add(this.dayAfterTomorrowMinLabel);
            this.Controls.Add(this.dayAfterTomorrowMaxLabel);
            this.Controls.Add(this.tomorrowMinLabel);
            this.Controls.Add(this.tomorrowMaxLabel);
            this.Controls.Add(this.todayMinLabel);
            this.Controls.Add(this.todayMaxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.cityChoiceLabel);
            this.Controls.Add(this.cityNamesComboBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.dayAfterTomorrowNightLabel);
            this.Controls.Add(this.dayAfterTomorrowEveLabel);
            this.Controls.Add(this.dayAfterTomorrowDayLabel);
            this.Controls.Add(this.dayAfterTomorrowMornLabel);
            this.Controls.Add(this.tomorrowNightLabel);
            this.Controls.Add(this.tomorrowEveLabel);
            this.Controls.Add(this.tomorrowDayLabel);
            this.Controls.Add(this.tomorrowMornLabel);
            this.Controls.Add(this.todayNightLabel);
            this.Controls.Add(this.todayEveLabel);
            this.Controls.Add(this.todayDayLabel);
            this.Controls.Add(this.todayMornLabel);
            this.Controls.Add(this.nightLabel);
            this.Controls.Add(this.eveLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.mornLabel);
            this.Controls.Add(this.dayAfterTomorrowLabel);
            this.Controls.Add(this.tomorrowLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.cityNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(782, 292);
            this.MinimumSize = new System.Drawing.Size(782, 292);
            this.Name = "WeatherUpdateUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "বাংলাদেশের আবহাওয়ার পূর্বাভাস";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.WeatherUpdateUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cityNameLabel;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label tomorrowLabel;
        private System.Windows.Forms.Label dayAfterTomorrowLabel;
        private System.Windows.Forms.Label mornLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label eveLabel;
        private System.Windows.Forms.Label nightLabel;
        private System.Windows.Forms.Label todayMornLabel;
        private System.Windows.Forms.Label todayDayLabel;
        private System.Windows.Forms.Label todayEveLabel;
        private System.Windows.Forms.Label todayNightLabel;
        private System.Windows.Forms.Label tomorrowMornLabel;
        private System.Windows.Forms.Label tomorrowDayLabel;
        private System.Windows.Forms.Label tomorrowEveLabel;
        private System.Windows.Forms.Label tomorrowNightLabel;
        private System.Windows.Forms.Label dayAfterTomorrowMornLabel;
        private System.Windows.Forms.Label dayAfterTomorrowDayLabel;
        private System.Windows.Forms.Label dayAfterTomorrowEveLabel;
        private System.Windows.Forms.Label dayAfterTomorrowNightLabel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ComboBox cityNamesComboBox;
        private System.Windows.Forms.Label cityChoiceLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label todayMaxLabel;
        private System.Windows.Forms.Label tomorrowMaxLabel;
        private System.Windows.Forms.Label dayAfterTomorrowMaxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label todayMinLabel;
        private System.Windows.Forms.Label tomorrowMinLabel;
        private System.Windows.Forms.Label dayAfterTomorrowMinLabel;
        private System.Windows.Forms.Label digitalWatchLabel;
    }
}

