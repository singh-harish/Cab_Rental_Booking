using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();*/
            List<string> username = new List<string> { };
            DirectoryInfo d = new DirectoryInfo(@"./data/users/admins/");
            FileInfo[] Files = d.GetFiles("*.txt");
            if (textBox1.Text != "" || textBox2.Text != "")
            {
                foreach (FileInfo file in Files)
                {
                    username.Add(file.Name);
                    if (file.Name.Contains(textBox1.Text.ToLower()))
                    {
                        String[] lines = File.ReadAllLines("./data/users/admins/" + textBox1.Text + ".txt");
                        string[][] parts = new String[lines.Length][];
                        string[] array = new string[3];
                        int counter = 0;
                        foreach (string line in lines)
                        {
                            parts[counter++] = line.Split(',');
                        }
                        string userName = parts[0][0];
                        string password = parts[0][1];
                        string authLevel = parts[0][2];
                        LoggedInUsers loggedInUsers = new LoggedInUsers(userName, authLevel);
                        ///////////////////////////////
                        if (textBox1.Text.ToLower() == userName.ToLower() && textBox2.Text == password)
                        {
                            this.Hide();
                            Dashboard dashboard = new Dashboard();
                            dashboard.Show();
                        }
                        else
                        {
                            MessageBox.Show("wrong Password");
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Enter Credentials");
            }
        }

    }
}
