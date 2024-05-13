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

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "constructionCompanyDataSet4.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.constructionCompanyDataSet4.Order);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 cfrm = new Form2();
            cfrm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConstructionCompanyDataSet4.OrderRow nrow = (ConstructionCompanyDataSet4.OrderRow)constructionCompanyDataSet4.Order.NewRow();
            
            nrow.id_order = Convert.ToInt32(textBox1.Text);
            nrow.id_employee = Convert.ToInt32(textBox2.Text);
            nrow.id_client = Convert.ToInt32(textBox3.Text);
            nrow.id_material = Convert.ToInt32(textBox4.Text);
            nrow.id_project = Convert.ToInt32(textBox5.Text);
            nrow.OrderDate = Convert.ToDateTime(textBox6.Text);
            nrow.Status = Convert.ToString(textBox7.Text);
            nrow.ExpirationDate = Convert.ToDateTime(textBox8.Text);
            constructionCompanyDataSet4.Order.AddOrderRow(nrow);
            MessageBox.Show("Данные добавлены");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
            MessageBox.Show("Данные удалены");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            orderTableAdapter.Update(constructionCompanyDataSet4);
        }
    }
}
