using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace CargoProjectNTIERArchitecture
{
    public partial class XmlCrud : Form
    {
        public XmlCrud()
        {
            InitializeComponent();
        }

        void Yukle()
        {
            XmlDocument xmlDoc = new XmlDocument();
            DataSet dataSet = new DataSet();
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(@"veri.xml", new XmlReaderSettings());
            dataSet.ReadXml(xmlFile);
            dataGridView1.DataSource = dataSet.Tables[0];
            xmlFile.Close();
        }
        private void XmlCrudRapor_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"veri.xml");
            x.Element("Müsteri").Add(
                new XElement("müsteriler",
                new XElement("ID", textBox1.Text),
                new XElement("Ad_Soyad", textBox2.Text),
                new XElement("Adres", textBox3.Text),
                new XElement("Telefon", textBox4.Text),
                new XElement("email", textBox5.Text),
                new XElement("durum", textBox6.Text)));

            x.Save(@"veri.xml");
            Yukle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"veri.xml");
            XElement node=x.Element("Müsteri").Elements("müsteriler").FirstOrDefault(a=>a.Element("ID").Value.Trim()==textBox1.Text);
            if (node != null)
            {
                node.SetElementValue("Ad_Soyad", textBox2.Text);
                node.SetElementValue("Adres", textBox3.Text);                
                node.SetElementValue("Telefon", textBox4.Text);
                node.SetElementValue("email", textBox5.Text);
                node.SetElementValue("durum", textBox6.Text);
                x.Save(@"veri.xml");
                Yukle();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"veri.xml");
            x.Root.Elements().Where(a => a.Element("ID").Value == textBox1.Text).Remove();
            x.Save(@"veri.xml");
            Yukle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Text = satir.Cells["ID"].Value.ToString();
            textBox2.Text = satir.Cells["Ad_Soyad"].Value.ToString();
            textBox3.Text = satir.Cells["Adres"].Value.ToString();
            textBox4.Text = satir.Cells["Telefon"].Value.ToString();
            textBox5.Text = satir.Cells["email"].Value.ToString();
            textBox6.Text = satir.Cells["durum"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            xmlrapor go = new xmlrapor();
            go.Show();
            this.Hide();
        }
    }
}
