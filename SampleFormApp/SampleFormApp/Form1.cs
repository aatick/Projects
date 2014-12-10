using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (aNumberTextBox.Text == string.Empty)
            {
                MessageBox.Show(@"Please Enter a Number.");
                aNumberTextBox.BackColor = Color.Yellow;
            }
            else
            {
                try
                {
                    double aNumber = double.Parse(aNumberTextBox.Text);
                    twoTimesTextBox.BackColor = Color.White;
                    twoTimesTextBox.Text = GetTwoTimes(aNumber).ToString();
                }
                catch
                {
                    MessageBox.Show(@"The Input Number is not valid. Please Enter only numbers.");
                    aNumberTextBox.BackColor = Color.Yellow;
                }

            }
        }

        private double GetTwoTimes(double aValue)
        {
            return aValue*2;
        }
        private void aNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void aNumberTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            aNumberTextBox.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            twoTimesTextBox.BackColor = Color.White;
        }

        
    }
}
