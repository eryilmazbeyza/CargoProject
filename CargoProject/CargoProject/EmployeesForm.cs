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
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmployeeClass EmployeeClass = new EmployeeClass();
            EmployeeClass.employeeNo = Convert.ToInt32(textBox1.Text);
            if (!ECRUD.Delete(EmployeeClass))
                MessageBox.Show("Veri silme başarısız!");
            dataGridView1.DataSource = ECRUD.Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeClass EmployeeClass = new EmployeeClass();
            EmployeeClass.employeeNo = Convert.ToInt32(textBox1.Text);
            EmployeeClass.nameSurname = textBox2.Text;
            EmployeeClass.task = textBox3.Text;
            EmployeeClass.title = textBox4.Text;
            EmployeeClass.phoneNumber = Convert.ToInt32(textBox5.Text);
            EmployeeClass.mail = textBox6.Text;
            EmployeeClass.salary = Convert.ToDecimal(textBox7.Text);
            if (!ECRUD.Update(EmployeeClass))
                MessageBox.Show("Veri güncellenmesi başarız!");
            dataGridView1.DataSource = ECRUD.Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeClass EmployeeClass = new EmployeeClass();
            EmployeeClass.nameSurname = textBox2.Text;
            EmployeeClass.task = textBox3.Text;
            EmployeeClass.title = textBox4.Text;
            EmployeeClass.phoneNumber = Convert.ToInt32(textBox5.Text);
            EmployeeClass.mail = textBox6.Text;
            EmployeeClass.salary = Convert.ToInt32(textBox7.Text);
            ECRUD.Add(EmployeeClass);
            dataGridView1.DataSource = ECRUD.Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ECRUD.Listele();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
