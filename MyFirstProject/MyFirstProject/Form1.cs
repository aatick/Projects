using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (BankName.Text == string.Empty)
            {
                MessageBox.Show("Please Select Bank.");
                BankName.BackColor = Color.Yellow;
            }
            else if (TimeText.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Time(in year).");
                TimeText.BackColor = Color.Yellow;
            }
            else if (PrincipalText.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Principal Amount.");
                PrincipalText.BackColor = Color.Yellow;
            }
            else
            {
                if (BankName.Text == "BRAC")
                {
                    label5.Text = (double.Parse(TimeText.Text) * double.Parse(PrincipalText.Text) * .06).ToString();
                }
                else if (BankName.Text == "DBBL")
                {
                    label5.Text = (double.Parse(TimeText.Text) * double.Parse(PrincipalText.Text) * .07).ToString();
                }
                else if (BankName.Text == "HSBC")
                {
                    label5.Text = (double.Parse(TimeText.Text) * double.Parse(PrincipalText.Text) * .08).ToString();
                }
                else
                {
                    MessageBox.Show("Please Select Bank.");
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            TimeText.Text = PrincipalText.Text = label5.Text = string.Empty;
        }

        private void BankName_MouseClick(object sender, MouseEventArgs e)
        {
            BankName.BackColor = Color.White;
        }

        private void TimeText_MouseClick(object sender, MouseEventArgs e)
        {
            TimeText.BackColor = Color.White;
        }

        private void PrincipalText_MouseClick(object sender, MouseEventArgs e)
        {
            PrincipalText.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BankName.Text = BankName.Items[0].ToString();
        }
    }
}
