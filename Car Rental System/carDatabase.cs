using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Car_Rental_System
{
    public partial class carDatabse : Form
    {
        public carDatabse()
        {
            InitializeComponent();
        }

        StreamWriter sw;

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string meter = textBox19.Text + textBox20.Text + textBox21.Text + textBox22.Text + textBox23.Text
                + textBox24.Text + textBox25.Text;
            if (textBox6.Text != ""
                && textBox8.Text != ""
                && textBox9.Text != ""
                && textBox1.Text != ""
                && textBox2.Text != ""
                && textBox3.Text != ""
                && textBox4.Text != ""
                && textBox5.Text != ""
                && comboBox1.Text != ""
                && textBox7.Text != ""
                && comboBox2.Text != ""
                && dateTimePicker1.Text != ""
                && comboBox3.Text != ""
                && comboBox4.Text != ""
                && textBox11.Text != ""
                && textBox12.Text != ""
                && textBox13.Text != ""
                && pictureBox1.Image != null
                && textBox14.Text != ""
                && textBox15.Text != ""
                && textBox16.Text != ""
                && textBox17.Text != ""
                && textBox18.Text != ""
                && comboBox5.Text != ""
                && meter.ToString() != ""
                && trackBar1.Value.ToString() != ""
                && richTextBox1.Text != "")
            {
                sw = new StreamWriter("./data/cars/" + textBox8.Text + ".txt", false);
                List<DatabaseCar> arr = new List<DatabaseCar> { };
                DatabaseCar databaseCar = new DatabaseCar(textBox6.Text
                    , textBox8.Text
                    , textBox9.Text
                    , textBox1.Text
                    , textBox2.Text
                    , textBox3.Text
                    , textBox4.Text
                    , textBox5.Text
                    , comboBox1.SelectedIndex.ToString()
                    , textBox7.Text
                    , comboBox2.SelectedIndex.ToString()
                    , dateTimePicker1.Text
                    , comboBox3.SelectedIndex.ToString()
                    , comboBox4.SelectedIndex.ToString()
                    , textBox10.Text
                    , textBox11.Text
                    , textBox12.Text
                    , textBox13.Text
                    , "./data/images/" + textBox8.Text + ".jpg"
                    , textBox14.Text
                    , textBox15.Text
                    , textBox16.Text
                    , textBox17.Text
                    , textBox18.Text
                    , comboBox5.SelectedIndex.ToString()
                    , meter.ToString()
                    , trackBar1.Value.ToString()
                    , richTextBox1.Text);
                arr.Add(databaseCar);
                foreach (DatabaseCar data in arr)
                {
                    sw.WriteLine(data);
                }
                sw.Close();
                MessageBox.Show("Car Added/Updated into Database");
                if (dlg.FileName != "")
                {
                    File.Copy(dlg.FileName, "./data/images/" + textBox8.Text + ".jpg", true);
                }
                clearAll();
                carDatabse_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please complete all the information");
            }
        }

        private void clearAll()
        {
            textBox6.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.SelectedIndex = -1;
            textBox7.Text = "";
            comboBox2.SelectedIndex = -1;
            dateTimePicker1.Text = "";
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            pictureBox1.Image = null;
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            comboBox5.SelectedIndex = -1;
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            textBox24.Text = "";
            textBox25.Text = "";
            trackBar1.Value = 0;
            richTextBox1.Text = "";
            dlg.FileName = "";
        }

        OpenFileDialog dlg = new OpenFileDialog();

        private void button1_Click(object sender, EventArgs e)
        {
            using (dlg)
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(dlg.FileName);
                    dlg.Dispose();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            File.Delete("./data/images/" + textBox8.Text + ".jpg");
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void carDatabse_Load(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(@"./data/cars");
            FileInfo[] Files = d.GetFiles("*.txt");
            foreach (FileInfo file in Files)
            {
                comboBox6.Items.Add(file.Name);
            }

            string userName, authLevel;
            userName = Users.userName;
            authLevel = Users.authLevel;
            if (authLevel == "Full Control")
            {
                groupBox5.Enabled = true;
            }
            else
            {
                groupBox5.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String[] lines = File.ReadAllLines("./data/cars/" + comboBox6.Text);
            string[][] parts = new String[lines.Length][];
            string[] array = new string[27];
            int counter = 0;
            foreach (string line in lines)
            {
                parts[counter++] = line.Split(',');
            }

            textBox6.Text = parts[0][0];
            textBox8.Text = parts[0][1];
            textBox9.Text = parts[0][2];
            textBox1.Text = parts[0][3];
            textBox2.Text = parts[0][4];
            textBox3.Text = parts[0][5];
            textBox4.Text = parts[0][6];
            textBox5.Text = parts[0][7];
            comboBox1.SelectedIndex = int.Parse(parts[0][8]);
            textBox7.Text = parts[0][9];
            comboBox2.SelectedIndex = int.Parse(parts[0][10]);
            dateTimePicker1.Text = parts[0][11];
            comboBox3.SelectedIndex = int.Parse(parts[0][12]);
            comboBox4.SelectedIndex = int.Parse(parts[0][13]);
            textBox10.Text = parts[0][14];
            textBox11.Text = parts[0][15];
            textBox12.Text = parts[0][16];
            textBox13.Text = parts[0][17];
            string imageLocation = parts[0][18];
            try
            {
                string test = Directory.GetCurrentDirectory() + imageLocation;
                pictureBox1.Image = new Bitmap(test);
                label25.Text = "";
            }
            catch
            {
                pictureBox1.Image = null;
                label25.Text = "Image not available";
            }
            textBox14.Text = parts[0][19];
            textBox15.Text = parts[0][20];
            textBox16.Text = parts[0][21];
            textBox17.Text = parts[0][22];
            textBox18.Text = parts[0][23];
            comboBox5.SelectedIndex = int.Parse(parts[0][24]);
            char[] meter = parts[0][25].ToCharArray();
            textBox19.Text = meter[0].ToString();
            textBox20.Text = meter[1].ToString();
            textBox21.Text = meter[2].ToString();
            textBox22.Text = meter[3].ToString();
            textBox23.Text = meter[4].ToString();
            textBox24.Text = meter[5].ToString();
            textBox25.Text = meter[6].ToString();
            trackBar1.Value = int.Parse(parts[0][26]);
            richTextBox1.Text = parts[0][27];
            textBox8.ReadOnly = true;
            textBox1.ReadOnly = true;
        }

        private void comboBox4_DropDown(object sender, EventArgs e)
        {
        }

        private void noText(object sender, KeyPressEventArgs e)
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

        private void noTextAndDot(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            noText(sender, e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            noText(sender, e);
        }
    }
}
