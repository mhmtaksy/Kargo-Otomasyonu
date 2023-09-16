using BL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoProjectNTIERArchitecture
{
    public partial class employes : Form
    {
        public employes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.NameSurname = textBox2.Text;
            emp.employeeDuty = textBox3.Text;
            emp.employeeTitle = textBox4.Text;
            emp.employeePhone = textBox5.Text;
            emp.employeeMail = textBox6.Text;
            emp.employeeWage = Convert.ToInt32(textBox7.Text);
            emp.shipmentID = Convert.ToInt32(textBox8.Text);
            EMPCRUD.Add1(emp);
            dataGridView1.DataSource = EMPCRUD.Listele1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.employeeID = Convert.ToInt32(textBox1.Text);
            emp.NameSurname = textBox2.Text;
            emp.employeeDuty = textBox3.Text;
            emp.employeeTitle = textBox4.Text;
            emp.employeePhone = textBox5.Text;
            emp.employeeMail = textBox6.Text;
            emp.employeeWage = Convert.ToInt32(textBox7.Text);
            emp.shipmentID = Convert.ToInt32(textBox8.Text);
            EMPCRUD.Update1(emp);
            dataGridView1.DataSource = EMPCRUD.Listele1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.employeeID= Convert.ToInt32(textBox1.Text);
            EMPCRUD.Delete1(emp);
            dataGridView1.DataSource = EMPCRUD.Listele1();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = EMPCRUD.Listele1();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow columns = dataGridView1.CurrentRow;
            textBox1.Text = columns.Cells["employeeID"].Value.ToString();
            textBox2.Text = columns.Cells["NameSurname"].Value.ToString();
            textBox3.Text = columns.Cells["employeeDuty"].Value.ToString();
            textBox4.Text = columns.Cells["employeeTitle"].Value.ToString();
            textBox5.Text = columns.Cells["employeePhone"].Value.ToString();
            textBox6.Text = columns.Cells["employeeMail"].Value.ToString();
            textBox7.Text = columns.Cells["employeeWage"].Value.ToString();
            textBox8.Text = columns.Cells["shipmentID"].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 go = new Form1();
            go.Show();
            this.Hide();
        }
    }
}
