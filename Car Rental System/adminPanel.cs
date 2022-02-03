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
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Car_Rental_System
{
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
        }

        StreamWriter sw;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label6.Enabled = true;
                label7.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox4.Text = "";
                textBox5.Text = "";
            }
            else
            {
                label6.Enabled = false;
                label7.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
            }
            else
            {
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sw = new StreamWriter("./data/users/admins/" + textBox1.Text.ToLower() + ".txt", true);
            FileStream fs = new FileStream(textBox1.Text + ".txt", FileMode.Create, FileAccess.Write, FileShare.None);
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new BinaryFormatter();
            List<Admins> arr = new List<Admins> { };
            binaryFormatter.Serialize(fs, arr);
            Admins admins;
            if (radioButton1.Checked == true)
            {
                admins = new Admins(textBox1.Text, textBox2.Text, "Full Control");
            }
            else
            {
                admins = new Admins(textBox1.Text, textBox2.Text, "Minimal Control");
            }
            arr.Add(admins);
            foreach (Admins data in arr)
            {
                sw.WriteLine(data);
            }
            sw.Close();
            MessageBox.Show("Admin added succefully");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            button1_Click(sender, e);
        }

        private void adminPanel_Load(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(@"./data/users/admins/");
            FileInfo[] Files = d.GetFiles("*.txt");
            foreach(FileInfo file in Files)
            {
                comboBox1.Items.Add(file.Name);
                comboBox2.Items.Add(file.Name);
            }
            //comboBox1.DataSource = Files;
            //comboBox2.DataSource = Files;
            //comboBox1.DisplayMember = "Admins";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + comboBox1.Text + "?", "Warninig", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                File.Delete("./data/users/admins/" + comboBox1.Text);
                button1_Click(sender, e);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                sw = new StreamWriter("./data/users/admins/" + comboBox2.Text, false);
                List<Admins> arr = new List<Admins> { };
                Admins admins;
                if (textBox4.Text == textBox5.Text)
                {
                    if (checkBox2.Checked == true)
                    {
                        if (radioButton4.Checked == true)
                        {
                            admins = new Admins(comboBox2.Text, textBox5.Text, "Full Control");
                            arr.Add(admins);
                        }
                        else if (radioButton3.Checked == true)
                        {
                            admins = new Admins(comboBox2.Text, textBox5.Text, "Minimal Control");
                            arr.Add(admins);
                        }
                    }
                    else
                    {
                        admins = new Admins(comboBox2.Text, textBox5.Text, label10.Text);
                        arr.Add(admins);
                    }
                    foreach (Admins data in arr)
                    {
                        sw.WriteLine(data);
                    }
                    sw.Close();
                    MessageBox.Show("Admin updated succefully");
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    comboBox2_SelectedIndexChanged(sender, e);
                }
                else
                {
                    MessageBox.Show("Password not same");
                }
            }
            else if (checkBox2.Checked == true)
            {
                sw = new StreamWriter("./data/users/admins/" + comboBox2.Text, false);
                List<Admins> arr = new List<Admins> { };
                Admins admins;
                if (radioButton4.Checked == true)
                {
                    admins = new Admins(comboBox2.Text, label9.Text, "Full Control");
                    arr.Add(admins);
                }
                else if (radioButton3.Checked == true)
                {
                    admins = new Admins(comboBox2.Text, label9.Text, "Minimal Control");
                    arr.Add(admins);
                }
                foreach (Admins data in arr)
                {
                    sw.WriteLine(data);
                }
                sw.Close();
                MessageBox.Show("Admin updated succefully");
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                comboBox2_SelectedIndexChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Please do any changes");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] lines = File.ReadAllLines("./data/users/admins/" + comboBox2.Text);
            string[][] parts = new String[lines.Length][];
            string[] array = new string[3];
            int counter = 0;
            foreach (string line in lines)
            {
                parts[counter++] = line.Split(',');
            }
            label8.Text = parts[0][0];
            label9.Text = parts[0][1];
            label10.Text = parts[0][2];
        }
    }
}
