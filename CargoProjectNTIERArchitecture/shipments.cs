using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using DAL;
using System.Data.SqlClient;

namespace CargoProjectNTIERArchitecture
{
    public partial class shipments : Form
    {
        public shipments()
        {
            InitializeComponent();
        }

        private void shipments_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shipment ship = new Shipment();
            ship.shipmentName = textBox2.Text;
            ship.shipmentDispatch = textBox3.Text;
            ship.shipmentTransportation = textBox4.Text;
            ship.shipmentDistance = textBox5.Text;
            ship.shipmentSum = Convert.ToDecimal(textBox6.Text);
            ship.vehicleID = Convert.ToInt32(textBox7.Text);
            ShipCRUD.Add2(ship);
            dataGridView1.DataSource = ShipCRUD.Listele2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ShipCRUD.Listele2();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow columns = dataGridView1.CurrentRow;
            textBox1.Text = columns.Cells["shipmentID"].Value.ToString();
            textBox2.Text = columns.Cells["shipmentName"].Value.ToString();
            textBox3.Text = columns.Cells["shipmentDispatch"].Value.ToString();
            textBox4.Text = columns.Cells["shipmentTransportation"].Value.ToString();
            textBox5.Text = columns.Cells["shipmentDistance"].Value.ToString();
            textBox5.Text = columns.Cells["shipmentSum"].Value.ToString();
            textBox5.Text = columns.Cells["vehicleID"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shipment ship = new Shipment();
            ship.shipmentID = Convert.ToInt32(textBox1.Text);
            ship.shipmentName = textBox2.Text;
            ship.shipmentDispatch = textBox3.Text;
            ship.shipmentTransportation = textBox4.Text;
            ship.shipmentDistance = textBox5.Text;
            ship.shipmentSum = Convert.ToDecimal(textBox6.Text);
            ship.vehicleID = Convert.ToInt32(textBox7.Text);
            ShipCRUD.Update2(ship);
            dataGridView1.DataSource = ShipCRUD.Listele2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Shipment ship = new Shipment();
            ship.shipmentID = Convert.ToInt32(textBox1.Text);     
            ShipCRUD.Delete2(ship);
            dataGridView1.DataSource = ShipCRUD.Listele2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            employes go = new employes();
            go.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
