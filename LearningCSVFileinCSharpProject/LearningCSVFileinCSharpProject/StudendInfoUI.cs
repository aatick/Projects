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

namespace LearningCSVFileinCSharpProject
{
    public partial class StudendInfoUI : Form
    {
        public StudendInfoUI()
        {
            InitializeComponent();
        }
        string pathName = @"D:\StudentRecord.csv";
        private void StudendInfoUI_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (regTextBox.Text == string.Empty)
            {
                regTextBox.BackColor = Color.Red;
                MessageBox.Show("Please Enter Reg. No.");
            }
            else if (nameTextBox.Text == string.Empty)
            {
                nameTextBox.BackColor = Color.Red;
                MessageBox.Show("Please Enter Student's Name");
            }
            else
            {
                try
                {
                    int regNo = int.Parse(regTextBox.Text);
                    if (File.Exists(pathName))
                    {
                        if (!checkUniqueReg(regNo))
                        {
                            regTextBox.BackColor = Color.Red;
                            MessageBox.Show("Duplicate Reg. No. Try with another Reg. No.");
                        }
                        else
                            writeInCsvFile(regNo, nameTextBox.Text);
                    }
                    else
                        writeInCsvFile(regNo, nameTextBox.Text);
                }
                catch
                {
                    regTextBox.BackColor = Color.Red;
                    MessageBox.Show("Reg. No. must not have any character.");
                }
            }

        }

        public bool checkUniqueReg(int reg)
        {
            FileStream aFileStream = new FileStream(pathName, FileMode.Open);
            CsvFileReader aCsvReader = new CsvFileReader(aFileStream);
            List<string> myList = new List<string>();
            while (aCsvReader.ReadRow(myList))
            {
                if (int.Parse(myList[0]) == reg)
                {
                    return false;
                }
            }
            aFileStream.Close();
            return true;
        }
        public void writeInCsvFile(int reg,string name)
        {
            FileStream aFileStream = new FileStream(pathName, FileMode.Append);
            CsvFileWriter aCsvWriter = new CsvFileWriter(aFileStream);
            List<string> studentList = new List<string>();
            studentList.Add(reg.ToString());
            studentList.Add(name);
            aCsvWriter.WriteRow(studentList);
            aFileStream.Close();
            regTextBox.Clear();
            nameTextBox.Clear();
            MessageBox.Show("Entry has been successfully saved.");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            infoViewListBox.Items.Clear();
            if (File.Exists(pathName))
            {
                List<string> studentList = new List<string>();
                FileStream aFileStream = new FileStream(pathName, FileMode.Open);
                CsvFileReader aCsvReader = new CsvFileReader(aFileStream);
                while (aCsvReader.ReadRow(studentList))
                {
                    infoViewListBox.Items.Add(studentList[0] + "," + studentList[1]);
                }
                aFileStream.Close();
            }
            else
            {
                MessageBox.Show("The requested file is not exist at all.");
            }
        }

        private void regTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            regTextBox.BackColor = Color.White;
        }

        private void nameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            nameTextBox.BackColor = Color.White;
        }
    }
}
