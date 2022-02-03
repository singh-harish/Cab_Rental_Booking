using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class carRent : Form
    {
        public carRent()
        {
            InitializeComponent();
        }

        StreamWriter sw;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "Available")
            {
                if (textBox1.Text != "" &&
                     textBox2.Text != "" &&
                     textBox3.Text != "" &&
                     comboBox2.Text != "" &&
                     textBox5.Text != "" &&
                     textBox6.Text != "" &&
                     dateTimePicker1.Text != "" &&
                     textBox9.Text != "" &&
                     textBox8.Text != "" &&
                     textBox10.Text != "" &&
                     comboBox1.Text != "" &&
                     dateTimePicker2.Text != "" &&
                     dateTimePicker3.Text != "" &&
                     textBox7.Text != "" &&
                     textBox11.Text != "" &&
                     label16.Text != "" &&
                     label18.Text != "" &&
                     label20.Text != "")
                {
                    string fullName = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
                    sw = new StreamWriter("./data/users/" + fullName + ".txt", true);
                    List<RentCar> arr = new List<RentCar> { };
                    RentCar rentCar = new RentCar(
                          textBox1.Text
                        , textBox2.Text
                        , textBox3.Text
                        , comboBox2.Text
                        , textBox5.Text
                        , textBox6.Text
                        , dateTimePicker1.Text
                        , textBox9.Text
                        , textBox8.Text
                        , textBox10.Text
                        , comboBox1.Text
                        , dateTimePicker2.Text
                        , dateTimePicker3.Text
                        , textBox7.Text
                        , textBox11.Text
                        , label16.Text
                        , label18.Text
                        , label20.Text);

                    arr.Add(rentCar);
                    foreach (RentCar data in arr)
                    {
                        sw.WriteLine(data);
                    }
                    sw.Close();
                    MessageBox.Show("Car Rented");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    comboBox2.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    dateTimePicker1.Text = "";
                    textBox9.Text = "";
                    textBox8.Text = "";
                    textBox10.Text = "";
                    comboBox1.SelectedIndex = -1;
                    dateTimePicker2.Text = "";
                    dateTimePicker3.Text = "";
                    textBox7.Text = "";
                    textBox11.Text = "";
                    label16.Text = "";
                    label18.Text = "";
                    label20.Text = "";
                    pictureBox1.Image = null;
                }
                else
                {
                    MessageBox.Show("Please Complete all information");
                }
            }
            else
            {
                MessageBox.Show("Car is not available for renting");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void carRent_Load(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(@"./data/cars");
            FileInfo[] Files = d.GetFiles("*.txt");
            comboBox1.DataSource = Files;
            comboBox1.DisplayMember = "Vehicles";
            button3_Click(sender, e);
            textBox11.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String[] lines = File.ReadAllLines("./data/cars/" + comboBox1.Text);
                string[][] parts = new String[lines.Length][];
                string[] array = new string[27];
                int counter = 0;
                foreach (string line in lines)
                {
                    parts[counter++] = line.Split(',');
                }
                textBox11.SelectedIndex = int.Parse(parts[0][13]);
                label18.Text = parts[0][15];
                string imageLocation = parts[0][18];
                try
                {
                    string test = Directory.GetCurrentDirectory() + imageLocation;
                    pictureBox1.Image = new Bitmap(test);
                    label22.Text = "";
                }
                catch
                {
                    pictureBox1.Image = null;
                    label22.Text = "Image not available";
                }
                button3_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime startdate = dateTimePicker2.Value;
            DateTime enddate = dateTimePicker3.Value;
            label16.Text = System.Math.Abs(cal(startdate, enddate)).ToString();
            if (label16.Text == "0")
                label16.Text = "1";

            float total = float.Parse(label16.Text) * float.Parse(label18.Text);

            label20.Text = total.ToString();
        }

        public long cal(System.DateTime StartDate, System.DateTime EndDate)
        {
            long dayes = 0;
            System.TimeSpan ts = new TimeSpan(EndDate.Ticks - StartDate.Ticks);
            dayes = ts.Days;
            return dayes;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void noText(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as MaskedTextBox).Text.IndexOf('.') >= -1))
            {
                e.Handled = true;
            }
        }
        private void noTextTextBox(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') >= -1))
            {
                e.Handled = true;
            }
        }
    }
}
