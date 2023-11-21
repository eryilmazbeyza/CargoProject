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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CargoProject
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CUCRUD.Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerClass CustomerClass = new CustomerClass();
            CustomerClass.nameSurname = textBox2.Text;
            CustomerClass.address = textBox3.Text;
            CustomerClass.phoneNumber = Convert.ToInt32(textBox4.Text); 
            CustomerClass.mail = textBox5.Text;
            CustomerClass.paymentStatus = textBox6.Text;
            CUCRUD.Add(CustomerClass);
            dataGridView1.DataSource = CUCRUD.Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerClass CustomerClass = new CustomerClass();
            CustomerClass.customerNo = Convert.ToInt32(textBox1.Text);
            CustomerClass.nameSurname = textBox2.Text;
            CustomerClass.address = textBox3.Text;
            CustomerClass.phoneNumber = Convert.ToInt32(textBox4.Text);
            CustomerClass.mail = textBox5.Text;
            CustomerClass.paymentStatus = textBox6.Text;
            if (!CUCRUD.Update(CustomerClass))
                MessageBox.Show("Veri güncellenmesi başarız!");
            dataGridView1.DataSource = CUCRUD.Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomerClass CustomerClass = new CustomerClass();
            CustomerClass.customerNo = Convert.ToInt32(textBox1.Text);
            if (!CUCRUD.Delete(CustomerClass))
                MessageBox.Show("Veri silme başarısız!");
            dataGridView1.DataSource = CUCRUD.Listele();
        }
    }
}
