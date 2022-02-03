using System;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            label2.Text = Users.userName;
            label3.Text = Users.authLevel;
            if (label3.Text == "Full Control")
            {
                adminPanel.Enabled = true;
            }
            else
            {
                adminPanel.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rentACar_Click(object sender, EventArgs e)
        {
            carRent carRent = new carRent();
            carRent.Show();
        }

        private void carsDatabase_Click(object sender, EventArgs e)
        {
            carDatabse carDatabse = new carDatabse();
            carDatabse.Show();
        }

        private void adminPanel_Click(object sender, EventArgs e)
        {
            adminPanel adminPanel = new adminPanel();
            adminPanel.Show();
        }

        private void changeUser_Click(object sender, EventArgs e)
        {
            //logout();
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
