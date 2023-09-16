using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace CargoProjectNTIERArchitecture
{
    public partial class xmlrapor : Form
    {
        public xmlrapor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlElement root = xmldoc.CreateElement("Customers");

            SqlConnection con = new SqlConnection("Server=MEHMETAKSOY\\SQLMHMT;Database=Kargo;Integrated Security=true;");
            SqlCommand command = new SqlCommand("select * from Customer", con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                XmlElement cust = xmldoc.CreateElement("Customer");
                XmlAttribute ad = xmldoc.CreateAttribute("NameSurname");
                ad.Value = reader["NameSurname"].ToString();

                XmlAttribute adres = xmldoc.CreateAttribute("Adress");
                adres.Value = reader["Adress"].ToString();

                XmlAttribute tel = xmldoc.CreateAttribute("Phone");
                tel.Value = reader["Phone"].ToString();

                cust.Attributes.Append(ad);
                cust.Attributes.Append(adres);
                cust.Attributes.Append(tel);
                root.AppendChild(cust);
            }
            con.Close();
            xmldoc.AppendChild(root);
            xmldoc.Save("veri1.xml");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlElement root = xmldoc.CreateElement("employes");

            SqlConnection con = new SqlConnection("Server=MEHMETAKSOY\\SQLMHMT;Database=Kargo;Integrated Security=true;");
            SqlCommand command = new SqlCommand("select * from Employee", con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                XmlElement emp = xmldoc.CreateElement("Employee");
                XmlAttribute ad = xmldoc.CreateAttribute("NameSurname");
                ad.Value = reader["NameSurname"].ToString();

                XmlAttribute duty = xmldoc.CreateAttribute("employeeDuty");
                duty.Value = reader["employeeDuty"].ToString();

                XmlAttribute title = xmldoc.CreateAttribute("employeeTitle");
                title.Value = reader["employeeTitle"].ToString();

                emp.Attributes.Append(ad);
                emp.Attributes.Append(duty);
                emp.Attributes.Append(title);
                root.AppendChild(emp);
            }
            con.Close();
            xmldoc.AppendChild(root);
            xmldoc.Save("veri2.xml");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlElement root = xmldoc.CreateElement("shipments");
            SqlConnection con = new SqlConnection("Server=MEHMETAKSOY\\SQLMHMT;Database=Kargo;Integrated Security=true;");
            SqlCommand command = new SqlCommand("select * from Shipment", con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                XmlElement ship = xmldoc.CreateElement("Shipment");
                XmlAttribute ad = xmldoc.CreateAttribute("shipmentName");
                ad.Value = reader["shipmentName"].ToString();

                XmlAttribute dispatch = xmldoc.CreateAttribute("shipmentDispatch");
                dispatch.Value = reader["shipmentDispatch"].ToString();

                XmlAttribute transp = xmldoc.CreateAttribute("shipmentTransportation");
                transp.Value = reader["shipmentTransportation"].ToString();

                ship.Attributes.Append(ad);
                ship.Attributes.Append(dispatch);
                ship.Attributes.Append(transp);
                root.AppendChild(ship);
            }
            con.Close();
            xmldoc.AppendChild(root);
            xmldoc.Save("veri3.xml");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlElement root = xmldoc.CreateElement("vehicle");
            SqlConnection con = new SqlConnection("Server=MEHMETAKSOY\\SQLMHMT;Database=Kargo;Integrated Security=true;");
            SqlCommand command = new SqlCommand("select * from Vehicles", con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                XmlElement veh = xmldoc.CreateElement("Vehicles");
                XmlAttribute ad = xmldoc.CreateAttribute("vehicleName");
                ad.Value = reader["vehicleName"].ToString();

                XmlAttribute cap = xmldoc.CreateAttribute("vehicleCapacity");
                cap.Value = reader["vehicleCapacity"].ToString();

                XmlAttribute driv = xmldoc.CreateAttribute("vehicleDriver");
                driv.Value = reader["vehicleDriver"].ToString();
                
                XmlAttribute exp = xmldoc.CreateAttribute("vehicleExpense");
                exp.Value = reader["vehicleExpense"].ToString();

                veh.Attributes.Append(ad);
                veh.Attributes.Append(cap);
                veh.Attributes.Append(driv);
                veh.Attributes.Append(exp);
                root.AppendChild(veh);
            }
            con.Close();
            xmldoc.AppendChild(root);
            xmldoc.Save("veri4.xml");
        }
    }
}
