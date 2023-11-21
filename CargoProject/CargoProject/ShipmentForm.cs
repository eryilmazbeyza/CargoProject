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

namespace CargoProject
{
    public partial class ShipmentForm : Form
    {
        public ShipmentForm()
        {
            InitializeComponent();
        }

        private void ShipmentForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SCRUD.Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShipmentClass ShipmentClass = new ShipmentClass();
            ShipmentClass.shipmentName = textBox2.Text;
            ShipmentClass.dispatchPoint = textBox3.Text;
            ShipmentClass.transportationPoint = textBox4.Text;
            ShipmentClass.distance = Convert.ToInt32(textBox5.Text);
            ShipmentClass.price = Convert.ToDecimal(textBox6.Text);
            SCRUD.Add(ShipmentClass);
            dataGridView1.DataSource = SCRUD.Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShipmentClass ShipmentClass = new ShipmentClass();
            ShipmentClass.shipmentNo = Convert.ToInt32(textBox1.Text);
            ShipmentClass.shipmentName = textBox2.Text;
            ShipmentClass.dispatchPoint = textBox3.Text;
            ShipmentClass.transportationPoint = textBox4.Text;
            ShipmentClass.distance = Convert.ToInt32(textBox5.Text);
            ShipmentClass.price = Convert.ToDecimal(textBox6.Text);
            if (!SCRUD.Update(ShipmentClass))
                MessageBox.Show("Veri güncellenmesi başarız!");
            dataGridView1.DataSource = SCRUD.Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShipmentClass ShipmentClass = new ShipmentClass();
            ShipmentClass.shipmentNo = Convert.ToInt32(textBox1.Text);
            if (!SCRUD.Delete(ShipmentClass))
                MessageBox.Show("Veri silme başarısız!");
            dataGridView1.DataSource = SCRUD.Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
