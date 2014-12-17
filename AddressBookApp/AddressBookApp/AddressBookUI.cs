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

namespace AddressBookApp
{
    public partial class AddressBookUI : Form
    {
        public AddressBookUI()
        {
            InitializeComponent();
        }

        string pathName = @"D:\AddressBookInfo.csv";
        private void AddressBookUI_Load(object sender, EventArgs e)
        {
            infoListView.Columns.Add(label1.Text);
            infoListView.Columns.Add(label2.Text);
            infoListView.Columns.Add(label3.Text);
            infoListView.Columns.Add(label4.Text);
            infoListView.Columns.Add(label5.Text);
            searchItemComboBox.Text = searchItemComboBox.Items[0].ToString();
            catagoryNameLabel.Text = searchItemComboBox.Text;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != string.Empty && emailTextBox.Text != string.Empty &&
                PersonalContactTextBox.Text != string.Empty && homeContactTextBox.Text != string.Empty &&
                homeaddressTextBox.Text != string.Empty)
            {
                if (File.Exists(pathName))
                {
                    if (checkAvailability(PersonalContactTextBox.Text))
                    {
                        csvWrite();
                        MessageBox.Show("Entry has been successfully saved.");
                    }
                    else
                    {
                        MessageBox.Show("Duplicate Personal Contact Number.");
                    }
                }
                else
                {
                    csvWrite();
                }
            }
            else
            {
                MessageBox.Show("Please make sure all the entry is filled.");
            }
        }

        public void csvWrite()
        {
            FileStream aStream = new FileStream(pathName, FileMode.Append);
            CsvFileWriter csvWriter = new CsvFileWriter(aStream);
            List<string> infoList = new List<string>();
            infoList.Add(nameTextBox.Text);
            infoList.Add(emailTextBox.Text);
            infoList.Add(PersonalContactTextBox.Text);
            infoList.Add(homeContactTextBox.Text);
            infoList.Add(homeaddressTextBox.Text);
            csvWriter.WriteRow(infoList);
            aStream.Close();
        }
        public bool checkAvailability(string personalContactNumber)
        {
            FileStream aStream = new FileStream(pathName, FileMode.Open);
            CsvFileReader csvReader = new CsvFileReader(aStream);
            List<string> infoList = new List<string>();
            while (csvReader.ReadRow(infoList))
            {
                if (infoList[2] == personalContactNumber)
                    return false;
            }
            aStream.Close();
            return true;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(pathName))
            {
                infoListView.Items.Clear();
                FileStream aStream = new FileStream(pathName, FileMode.Open);
                CsvFileReader csvReader = new CsvFileReader(aStream);
                List<string> infoList = new List<string>();
                while (csvReader.ReadRow(infoList))
                {
                    ListViewItem myView = new ListViewItem(infoList[0]);
                    for (int i = 1; i < 5; i++)
                        myView.SubItems.Add(infoList[i]);
                    infoListView.Items.Add(myView);
                }
                aStream.Close();
            }
            else
            {
                MessageBox.Show("The requested file does not exist.");
            }
        }

        private void searchItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            catagoryNameLabel.Text = searchItemComboBox.Text;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
           // if(catagoryNameTextBox.Text!=)
            infoListView.Items.Clear();
            
            FileStream aStream = new FileStream(pathName, FileMode.Open);
            CsvFileReader csvReader = new CsvFileReader(aStream);
            List<string> infoList = new List<string>();
            if (catagoryNameTextBox.Text != string.Empty)
            {
                if (searchItemComboBox.Text == "Name")
                {
                    while (csvReader.ReadRow(infoList))
                    {
                        bool check = false;
                        ListViewItem myView=new ListViewItem(infoList[0]);
                        foreach (char c in catagoryNameTextBox.Text)
                        {
                            if (infoList[0].ToLower().Contains(c.ToString().ToLower()))
                            {
                                check = true;
                                break;
                            }
                        }
                        if (check)
                        {
                            for (int i = 1; i < 5; i++)
                                myView.SubItems.Add(infoList[i]);
                            infoListView.Items.Add(myView);
                        }

                    }
                    aStream.Close();
                }
                else if (searchItemComboBox.Text == "Email")
                {
                    while (csvReader.ReadRow(infoList))
                    {
                        bool check = false;
                        ListViewItem myView = new ListViewItem(infoList[0]);
                        foreach (char c in catagoryNameTextBox.Text)
                        {
                            if (infoList[1].ToLower().Contains(c.ToString().ToLower()))
                            {
                                check = true;
                                break;
                            }
                        }
                        if (check)
                        {
                            for (int i = 1; i < 5; i++)
                                myView.SubItems.Add(infoList[i]);
                            infoListView.Items.Add(myView);
                        }

                    }
                    aStream.Close();
                }
                else
                {
                    while (csvReader.ReadRow(infoList))
                    {
                        bool check = false;
                        ListViewItem myView = new ListViewItem(infoList[0]);
                        
                            if (infoList[2]==catagoryNameTextBox.Text)
                            {
                                check = true;
                            }
                        if (check)
                        {
                            for (int i = 1; i < 5; i++)
                                myView.SubItems.Add(infoList[i]);
                            infoListView.Items.Add(myView);
                        }

                    }
                    aStream.Close();
                }
            }
        }
    }
}
