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
using System.Data.SqlClient;

namespace CargoProject
{
    public partial class xmlReport : Form
    {
        public xmlReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement root = xmlDocument.CreateElement("Cars");

            SqlConnection con = new SqlConnection("Server=.;Database=Kargo;Integrated Security=true;");
            SqlCommand command = new SqlCommand("select*from Cars", con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                XmlElement cars = xmlDocument.CreateElement("Cars");
                XmlAttribute cardriver = xmlDocument.CreateAttribute("carDriver");
                cardriver.Value = reader["carDriver"].ToString();

                XmlAttribute carexpense = xmlDocument.CreateAttribute("carExpense");
                carexpense.Value = reader["carExpense"].ToString();

                XmlAttribute carmodelname = xmlDocument.CreateAttribute("carModelname");
                carmodelname.Value = reader["carModelname"].ToString();

                cars.Attributes.Append(cardriver);
                cars.Attributes.Append(carexpense);
                cars.Attributes.Append(carmodelname);
                root.AppendChild(cars);
            }

            con.Close();
            xmlDocument.AppendChild(root);
            xmlDocument.Save("veri.xml");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement root = xmlDocument.CreateElement("Customers");

            SqlConnection con = new SqlConnection("Server=.;Database=Kargo;Integrated Security=true;");
            SqlCommand command = new SqlCommand("select*from Customers", con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                XmlElement customers = xmlDocument.CreateElement("Customers");
                XmlAttribute namesurname = xmlDocument.CreateAttribute("nameSurname");
                namesurname.Value = reader["nameSurname"].ToString();

                XmlAttribute address = xmlDocument.CreateAttribute("address");
                address.Value = reader["address"].ToString();

                XmlAttribute phonenumber = xmlDocument.CreateAttribute("phoneNumber");
                phonenumber.Value = reader["phoneNumber"].ToString();

                customers.Attributes.Append(namesurname);
                customers.Attributes.Append(address);
                customers.Attributes.Append(phonenumber);
                root.AppendChild(customers);
            }

            con.Close();
            xmlDocument.AppendChild(root);
            xmlDocument.Save("vericustomer.xml");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement root = xmlDocument.CreateElement("Employees");

            SqlConnection con = new SqlConnection("Server=.;Database=Kargo;Integrated Security=true;");
            SqlCommand command = new SqlCommand("select*from Employees", con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                XmlElement employees = xmlDocument.CreateElement("Employees");
                XmlAttribute namesurname = xmlDocument.CreateAttribute("nameSurname");
                namesurname.Value = reader["nameSurname"].ToString();

                XmlAttribute task = xmlDocument.CreateAttribute("task");
                task.Value = reader["task"].ToString();

                XmlAttribute title = xmlDocument.CreateAttribute("title");
                title.Value = reader["title"].ToString();

                employees.Attributes.Append(namesurname);
                employees.Attributes.Append(task);
                employees.Attributes.Append(title);
                root.AppendChild(employees);
            }

            con.Close();
            xmlDocument.AppendChild(root);
            xmlDocument.Save("veriemployee.xml");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement root = xmlDocument.CreateElement("Shipment");

            SqlConnection con = new SqlConnection("Server=.;Database=Kargo;Integrated Security=true;");
            SqlCommand command = new SqlCommand("select*from Shipment", con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                XmlElement shipment = xmlDocument.CreateElement("Shipment");
                XmlAttribute shipmentname = xmlDocument.CreateAttribute("shipmentName");
                shipmentname.Value = reader["shipmentName"].ToString();

                XmlAttribute distance = xmlDocument.CreateAttribute("distance");
                distance.Value = reader["distance"].ToString();

                XmlAttribute price = xmlDocument.CreateAttribute("price");
                price.Value = reader["price"].ToString();

                shipment.Attributes.Append(shipmentname);
                shipment.Attributes.Append(distance);
                shipment.Attributes.Append(price);
                root.AppendChild(shipment);
            }

            con.Close();
            xmlDocument.AppendChild(root);
            xmlDocument.Save("verishipment.xml");

        }
    }
}
