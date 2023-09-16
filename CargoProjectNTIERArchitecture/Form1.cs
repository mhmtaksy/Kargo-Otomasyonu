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
using System.Data.SqlClient;

namespace CargoProjectNTIERArchitecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.NameSurname = textBox2.Text;
            customer.Adress = textBox3.Text;
            customer.Phone = textBox4.Text;
            customer.Mail = textBox5.Text;
            customer.PaymentSituation = textBox6.Text;
            customer.employeeID = Convert.ToInt32(textBox7.Text);
            CUSTCRUDS.Add(customer);
            dataGridView1.DataSource=CUSTCRUDS.Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CUSTCRUDS.Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.customerID = Convert.ToInt32(textBox1.Text);
            customer.NameSurname = textBox2.Text;
            customer.Adress = textBox3.Text;
            customer.Phone = textBox4.Text;
            customer.Mail = textBox5.Text;
            customer.PaymentSituation = textBox6.Text;
            customer.employeeID = Convert.ToInt32(textBox7.Text);
            CUSTCRUDS.Update(customer);
            dataGridView1.DataSource = CUSTCRUDS.Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.customerID = Convert.ToInt32(textBox1.Text);
            CUSTCRUDS.Delete(customer);
            dataGridView1.DataSource = CUSTCRUDS.Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow columns = dataGridView1.CurrentRow;
            textBox1.Text = columns.Cells["customerID"].Value.ToString();
            textBox2.Text = columns.Cells["NameSurname"].Value.ToString();
            textBox3.Text = columns.Cells["Adress"].Value.ToString();
            textBox4.Text = columns.Cells["Phone"].Value.ToString();
            textBox5.Text = columns.Cells["Mail"].Value.ToString();
            textBox6.Text = columns.Cells["PaymentSituation"].Value.ToString();
            textBox7.Text = columns.Cells["employeeID"].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            XmlCrud go = new XmlCrud();
            go.Show();
            this.Hide();
        }
    }
}
