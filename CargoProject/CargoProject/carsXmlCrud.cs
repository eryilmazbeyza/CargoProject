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
    public partial class carsXmlCrud : Form
    {
        public carsXmlCrud()
        {
            InitializeComponent();
        }

        void CarsList()
        {
            XmlDocument xmlDocument = new XmlDocument();
            DataSet dataSet = new DataSet();
            XmlReader xmlfile;
            xmlfile = XmlReader.Create(@"vericarscrud.xml", new XmlReaderSettings());
            dataSet.ReadXml(xmlfile);
            dataGridView1.DataSource = dataSet.Tables[0];
            xmlfile.Close();
        }


        private void carsXmlCrud_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarsList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XDocument xmlDocument = XDocument.Load(@"vericarscrud.xml");
            xmlDocument.Element("cars").Add(new XElement("car",
                new XElement("carno", textBox1.Text),
                new XElement("carmodelname", textBox2.Text),
                new XElement("carcapacity", textBox3.Text),
                new XElement("cardriver", textBox4.Text),
                new XElement("carexpense",textBox5.Text)
                ));
            xmlDocument.Save(@"vericarscrud.xml");
            CarsList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XDocument xDocument = XDocument.Load(@"vericarscrud.xml");
            XElement node = xDocument.Element("cars").Elements("car").FirstOrDefault(a =>
            a.Element("carno").Value == textBox1.Text);
            if (node != null)
            {
                node.SetElementValue("carmodelname", textBox2.Text);
                node.SetElementValue("carcapacity", textBox3.Text);
                node.SetElementValue("cardriver", textBox4.Text);
                node.SetElementValue("carexpense", textBox5.Text);
                xDocument.Save(@"vericarscrud.xml");
                CarsList();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XDocument document = XDocument.Load(@"vericarscrud.xml");
            document.Root.Elements().Where(a => a.Element("carno").Value == textBox1.Text).Remove();
            document.Save(@"vericarscrud.xml");
            CarsList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Text = satir.Cells["carno"].Value.ToString();
            textBox2.Text = satir.Cells["carmodelname"].Value.ToString();
            textBox3.Text = satir.Cells["carcapacity"].Value.ToString();
            textBox4.Text = satir.Cells["cardriver"].Value.ToString();
            textBox5.Text = satir.Cells["carexpense"].Value.ToString();
        }


    }
}
