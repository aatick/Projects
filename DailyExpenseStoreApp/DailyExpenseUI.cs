using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSVLib;

namespace DailyExpenseStoreApp
{
    public partial class DailyExpenseUI : Form
    {
        public DailyExpenseUI()
        {
            InitializeComponent();
        }


        string fileSavingPath = @"E:\DailyExpenseInfo.csv";
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (amountTextBox.Text == string.Empty)
            {
                amountTextBox.BackColor = Color.Red;
                MessageBox.Show("Please Enter Amount.");
            }
            else if (particularTextBox.Text == string.Empty)
            {
                particularTextBox.BackColor = Color.Red;
                MessageBox.Show("Please Enter Particular Message.");
            }
            else
            {
                try
                {
                    long savingAmount = long.Parse(amountTextBox.Text);

                    string particular = particularTextBox.Text;
                    FileStream fileStream = new FileStream(fileSavingPath, FileMode.Append);
                    CsvFileWriter csvFileWriter = new CsvFileWriter(fileStream);
                    List<string> infoList = new List<string>();
                    infoList.Add(savingAmount.ToString());
                    infoList.Add(catagoryComboBox.Text);
                    infoList.Add(particular);
                    csvFileWriter.WriteRow(infoList);
                    fileStream.Close();
                    MessageBox.Show("Entry has been successfully Saved.");
                    amountTextBox.Clear();
                    particularTextBox.Clear();
                }
                catch
                {
                    amountTextBox.BackColor = Color.Red;
                    MessageBox.Show(
                        "Invalid Amount. Please Enter a Valid Amount.\nAmount must not has any characters contains only numbers..(e.g.123.987 or 4532)");
                }
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(fileSavingPath))
            {
                long sum = 0;
                long max = 0;
                FileStream fileStream = new FileStream(fileSavingPath, FileMode.Open);
                CsvFileReader csvFileReader = new CsvFileReader(fileStream);
                List<string> infoList = new List<string>();
                while (csvFileReader.ReadRow(infoList))
                {
                    if (infoList.Count == 3)
                    {
                        long tempNumber = long.Parse(infoList[0]);
                        if (max < tempNumber)
                            max = tempNumber;
                        sum += long.Parse(infoList[0]);
                    }
                    else
                    {
                        MessageBox.Show("The stored information is not in a correct csv format.");
                    }
                }
                fileStream.Close();
                if (infoList.Count == 3)
                {
                    totalExpenseTextBox.Text = sum.ToString();
                    maxExpenseTextBox.Text = max.ToString();
                }
            }
            else
            {
                MessageBox.Show("There is no record.");
            }
        }

        private void searchShowButton_Click(object sender, EventArgs e)
        {
            searchTotalTextBox.Clear();
            long sum = 0;
            searchResultListBox.Items.Clear();
            string searchingCatagory = searchCatagoryComboBox.Text;
            if (File.Exists(fileSavingPath))
            {
                FileStream fileStream = new FileStream(fileSavingPath, FileMode.Open);
                CsvFileReader csvFileReader = new CsvFileReader(fileStream);
                List<string> infoList = new List<string>();
                while (csvFileReader.ReadRow(infoList))
                {
                    if (infoList.Count == 3)
                    {
                        if (infoList[1] == searchingCatagory)
                        {
                            searchResultListBox.Items.Add(infoList[0] + " , " + infoList[1] + " , " + infoList[2]);
                            sum += long.Parse(infoList[0]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The stored information is not in a correct csv format.");
                    }
                }
                fileStream.Close();
                
                if (searchResultListBox.Items.Count == 0)
                    searchResultListBox.Items.Add("There is no data records to display");

                    searchTotalTextBox.Text = searchingCatagory+": "+sum.ToString();
            }
            else
            {
                MessageBox.Show(
                    "There is no Record of Daily Expenses. Please Entry some Expense info and then try again.");
            }
        }

        private void DailyExpenseUI_Load(object sender, EventArgs e)
        {
            catagoryComboBox.Text = catagoryComboBox.Items[0].ToString();
            searchCatagoryComboBox.Text = searchCatagoryComboBox.Items[0].ToString();
        }

        private void amountTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            amountTextBox.BackColor = Color.White;
        }

        private void particularTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            particularTextBox.BackColor = Color.White;
        }
    }
}
