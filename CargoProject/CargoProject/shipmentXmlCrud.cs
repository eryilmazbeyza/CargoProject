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

namespace CargoProject
{
    public partial class shipmentXmlCrud : Form
    {
        public shipmentXmlCrud()
        {
            InitializeComponent();
        }

        void ShipmentList()
        {
            XmlDocument xmlDocument = new XmlDocument();
            DataSet dataSet = new DataSet();
            XmlReader xmlfile;
            xmlfile = XmlReader.Create(@"verishipmentcrud.xml", new XmlReaderSettings());
            dataSet.ReadXml(xmlfile);
            dataGridView1.DataSource = dataSet.Tables[0];
            xmlfile.Close();
        }
        private void shipmentXmlCrud_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShipmentList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XDocument xmlDocument = XDocument.Load(@"verishipmentcrud.xml");
            xmlDocument.Element("shipments").Add(new XElement("shipment",
                new XElement("shipmentno", textBox1.Text),
                new XElement("shipmentname", textBox2.Text),
                new XElement("dispatchpoint", textBox3.Text),
                new XElement("transportationpoint", textBox4.Text),
                new XElement("distance", textBox5.Text),
                new XElement("price", textBox6.Text)
                ));
            xmlDocument.Save(@"verishipmentcrud.xml");
            ShipmentList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XDocument xDocument = XDocument.Load(@"verishipmentcrud.xml");
            XElement node = xDocument.Element("shipments").Elements("shipment").FirstOrDefault(a =>
            a.Element("shipmentno").Value == textBox1.Text);
            if (node != null)
            {
                node.SetElementValue("shipmentname", textBox2.Text);
                node.SetElementValue("dispatchpoint", textBox3.Text);
                node.SetElementValue("transportationpoint", textBox4.Text);
                node.SetElementValue("distance", textBox5.Text);
                node.SetElementValue("price", textBox6.Text);
                xDocument.Save(@"verishipmentcrud.xml");
                ShipmentList();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XDocument document = XDocument.Load(@"verishipmentcrud.xml");
            document.Root.Elements().Where(a => a.Element("shipmentno").Value == textBox1.Text).Remove();
            document.Save(@"verishipmentcrud.xml");
            ShipmentList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Text = satir.Cells["shipmentno"].Value.ToString();
            textBox2.Text = satir.Cells["shipmentname"].Value.ToString();
            textBox3.Text = satir.Cells["dispatchpoint"].Value.ToString();
            textBox4.Text = satir.Cells["transportationpoint"].Value.ToString();
            textBox5.Text = satir.Cells["distance"].Value.ToString();
            textBox6.Text = satir.Cells["price"].Value.ToString();
        }
    }
}
