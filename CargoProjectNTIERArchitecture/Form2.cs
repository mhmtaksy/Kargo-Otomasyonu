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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehicle veh = new Vehicle();
            veh.vehicleName = textBox2.Text;
            veh.vehicleCapacity = textBox3.Text;
            veh.vehicleDriver = textBox4.Text;
            veh.vehicleExpense = Convert.ToInt32(textBox5.Text);    
            VEHCRUD.Add3(veh);
            dataGridView1.DataSource = VEHCRUD.Listele3();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                DataGridViewRow columns = dataGridView1.CurrentRow;
                textBox1.Text = columns.Cells["vehicleID"].Value.ToString();
                textBox2.Text = columns.Cells["vehicleName"].Value.ToString();
                textBox3.Text = columns.Cells["vehicleCapacity"].Value.ToString();
                textBox4.Text = columns.Cells["vehicleDriver"].Value.ToString();
                textBox5.Text = columns.Cells["vehicleExpense"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = VEHCRUD.Listele3();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vehicle veh = new Vehicle();
            veh.vehicleID = Convert.ToInt32(textBox1.Text);
            veh.vehicleName = textBox2.Text;
            veh.vehicleCapacity = textBox3.Text;
            veh.vehicleDriver = textBox4.Text;
            veh.vehicleExpense = Convert.ToInt32(textBox5.Text);
            VEHCRUD.Update3(veh);
            dataGridView1.DataSource = VEHCRUD.Listele3();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vehicle veh = new Vehicle();
            veh.vehicleID = Convert.ToInt32(textBox1.Text);
            VEHCRUD.Delete3(veh);
            dataGridView1.DataSource = VEHCRUD.Listele3();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            shipments go = new shipments();
            go.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
