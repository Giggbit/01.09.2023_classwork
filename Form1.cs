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
using static System.Net.Mime.MediaTypeNames;

namespace _01._09._2023_class_work
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();

        }

        private void save_Click(object sender, EventArgs e) {
            string name = textBox1.Text.ToString();
            string surname = textBox2.Text.ToString();
            string fathername = textBox3.Text.ToString();
            string gender = comboBox1.Text.ToString();
            string date = dateTimePicker1.Text.ToString();
            string family = comboBox2.Text.ToString();
            string other = textBox4.Text.ToString();

            FileInfo file = new FileInfo("file.txt");
            StreamWriter sw = new StreamWriter(file.Name);
            sw.Write(name);
            sw.Write('\n');
            sw.Write(surname);
            sw.Write('\n');
            sw.Write(fathername);
            sw.Write('\n');
            sw.Write(gender);
            sw.Write('\n');
            sw.Write(date);
            sw.Write('\n');
            sw.Write(family);
            sw.Write('\n');
            sw.Write(other);

            sw.Close();

            MessageBox.Show("Data saved...");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Text = "None";
            comboBox2.Text = "None";
        }

        private void load_Click(object sender, EventArgs e) {
            FileInfo file = new FileInfo("file.txt");
            StreamReader sr = new StreamReader(file.Name);

            textBox1.Text = sr.ReadLine();
            textBox2.Text = sr.ReadLine();
            textBox3.Text = sr.ReadLine();
            textBox4.Text = sr.ReadLine();
            comboBox1.Text = sr.ReadLine();
            comboBox2.Text = sr.ReadLine();
        }
    }
}
