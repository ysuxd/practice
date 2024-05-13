using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ConstructionCompanyDataSetTableAdapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "constructionCompanyDataSet1.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.constructionCompanyDataSet1.Employees);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 cfrm = new Form2();
            cfrm.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConstructionCompanyDataSet1.EmployeesRow nrow = (ConstructionCompanyDataSet1.EmployeesRow)constructionCompanyDataSet1.Employees.NewRow();
            nrow.id_employee = Convert.ToInt32(textBox1.Text);
            nrow.LastName = Convert.ToString(textBox2.Text);
            nrow.FirstName = Convert.ToString(textBox3.Text);
            nrow.MidName = Convert.ToString(textBox4.Text);
            nrow.JobTitle = Convert.ToString(textBox5.Text);
            nrow.PhoneNumber = Convert.ToDecimal(textBox6.Text);
            nrow.Address = Convert.ToString(textBox7.Text);
            nrow.Passport = Convert.ToInt32(textBox8.Text);
            constructionCompanyDataSet1.Employees.AddEmployeesRow(nrow);
            MessageBox.Show("Данные добавлены");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
            MessageBox.Show("Данные удалены");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            employeesTableAdapter.Update(constructionCompanyDataSet1);
        }
    }
}
