using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Employee_Information_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeGenderComboBox();

        }
        private void InitializeGenderComboBox()
        {
            comboBox1.Text = "choose Gender";
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = "Choose Gender";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) ||
                    string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Value");
                    return;
                }
                if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) ||
                    !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text) && comboBox1.SelectedIndex == -1)
                {
                    int id;
                    double hourlySalary;
                    double noOfHoursPerWeek;

                    if (!int.TryParse(textBox1.Text, out id))
                    {
                        MessageBox.Show("Invalid value in ID.");
                        return;
                    }
                    if (!double.TryParse(textBox4.Text, out hourlySalary))
                    {
                        MessageBox.Show("Invalid value in Hourly Salary.");
                        return;
                    }

                    if (!double.TryParse(textBox5.Text, out noOfHoursPerWeek))
                    {
                        MessageBox.Show("Invalid value in No Of Hours Per Week.");
                        return;
                    }
                    emp.Id = textBox1.Text;
                    emp.FName = textBox2.Text;
                    emp.LName = textBox3.Text;
                    emp.Gender = comboBox1.SelectedItem.ToString();
                    emp.NoOfHoursPerWeek = noOfHoursPerWeek;
                    emp.HourlySalary = hourlySalary;

                    MessageBox.Show("Insertion done successfully.");
                    Program.employees.Add(emp);
                   
                }
              
            }
            catch (FormatException)
            {
                MessageBox.Show("Hourly Salary and Number of Hours Per Week must be numbers.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        }
}
