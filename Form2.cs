using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Information_Form
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        public void LoadData()
        {
            if (Program.employees != null && Program.employees.Count > 0)
            {
                dataGridView1.DataSource = Program.employees.ToList();
            }
            else
            {
                MessageBox.Show("No employees found.");
                Application.Exit();
               
            }
           
        }

        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fname = from i in Program.employees
                        orderby i.FName ascending
                        select i;
            dataGridView1.DataSource = fname.ToList();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var femaleEmployees = Program.employees.Where(emp => emp.Gender == "Female").ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = femaleEmployees.ToList();
        }

        private void maximumWeeklySalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var maxSalaryEmployee = Program.employees.OrderByDescending
                (emp => emp.SalaryPerWeek).First();
            MessageBox.Show($"Employee with max weekly salary: {maxSalaryEmployee.FName}" +
                $" {maxSalaryEmployee.LName} {maxSalaryEmployee.SalaryPerWeek}, " +
                $"{maxSalaryEmployee.AnnualSalary}");
        }

        private void minimumAnnualSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var minSalaryEmployee = Program.employees.OrderBy(emp => emp.AnnualSalary).First();
            MessageBox.Show($"Employee with min annual salary: {minSalaryEmployee.FName} " +
                $"{minSalaryEmployee.LName} {minSalaryEmployee.SalaryPerWeek}," +
                $" {minSalaryEmployee.AnnualSalary}");
        }

        private void averageOfAnnualSalariesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var avgAnnualSalary = Program.employees.Average(emp => emp.AnnualSalary);
            MessageBox.Show($"Average annual salary: {avgAnnualSalary}");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void displayAllInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = Program.employees.ToList();
           // Console.WriteLine(Program.employees.ToList());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }

}
