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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CargoProject
{
    public partial class CarsForm : Form
    {
        public CarsForm()
        {
            InitializeComponent();
        }

        private void CarsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CCRUD.Listele();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarClass CarClass = new CarClass();
            CarClass.carModelname = textBox2.Text;
            CarClass.carCapacity = Convert.ToInt32(textBox3.Text);
            CarClass.carDriver = textBox4.Text;
            CarClass.carExpense = Convert.ToDecimal(textBox5.Text);
            CCRUD.Add(CarClass);
            dataGridView1.DataSource = CCRUD.Listele();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CarClass CarClass = new CarClass();
            CarClass.carNo = Convert.ToInt32(textBox1.Text);
            CarClass.carModelname = textBox2.Text;
            CarClass.carCapacity = Convert.ToInt32(textBox3.Text);
            CarClass.carDriver = textBox4.Text;
            CarClass.carExpense = Convert.ToDecimal(textBox5.Text);
            if (!CCRUD.Update(CarClass))
                MessageBox.Show("Veri güncellenmesi başarız!");
            dataGridView1.DataSource = CCRUD.Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CarClass CarClass = new CarClass();
            CarClass.carNo = Convert.ToInt32(textBox1.Text);
            if (!CCRUD.Delete(CarClass))
                MessageBox.Show("Veri silme başarısız!");
            dataGridView1.DataSource = CCRUD.Listele();
        }
    }
}
