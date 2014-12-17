using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreEmployeeInfoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string pathName = @"D:\EmployeeInfo.txt";
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == string.Empty)
            {
                nameTextBox.BackColor = Color.Red;
                MessageBox.Show("Name field can not be left blank.");
            }
            else if (idTextBox.Text == string.Empty)
            {
                idTextBox.BackColor = Color.Red;
                MessageBox.Show("ID field can not be left blank.");
            }
            else if (salaryTextBox.Text == string.Empty)
            {
                salaryTextBox.BackColor = Color.Red;
                MessageBox.Show("Salary Amount field can not be left blank.");
            }
            else
            {
                try
                {
                    int id = int.Parse(idTextBox.Text);
                    try
                    {
                        long salary = long.Parse(salaryTextBox.Text);
                        File.AppendAllText(pathName, id + "," + nameTextBox.Text + "," + salary+"\n");
                        MessageBox.Show("Employee information has been successfully saved.");
                    }
                    catch
                    {
                        salaryTextBox.BackColor = Color.Red;
                        MessageBox.Show("Salary Amount must have only numbers.");
                    }
                }
                catch
                {
                    idTextBox.BackColor = Color.Red;
                    MessageBox.Show("Id can not have any character. It should be only numbers.");
                }

            }
        }

        private void nameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            nameTextBox.BackColor = Color.White;
        }

        private void idTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            idTextBox.BackColor = Color.White;
        }

        private void salaryTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            salaryTextBox.BackColor = Color.White;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(pathName))
            {
                infoViewListBox.Items.Clear();
                long sum = 0;
                foreach (string line in File.ReadAllLines(pathName))
                {
                    infoViewListBox.Items.Add(line);
                    string[] str = line.Split(',');
                    sum += long.Parse(str[2]);
                }
                totalTextBox.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("The requested file does not exist.");
            }
        }
    }
}
