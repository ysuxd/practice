using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "constructionCompanyDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.constructionCompanyDataSet.Client);

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
            ConstructionCompanyDataSet.ClientRow nrow =(ConstructionCompanyDataSet.ClientRow)constructionCompanyDataSet.Client.NewRow();
            nrow.id_client = Convert.ToInt32(textBox7.Text);
            nrow.FirstName = Convert.ToString(textBox1.Text);
            nrow.LastName = Convert.ToString(textBox2.Text);
            nrow.MidName = Convert.ToString(textBox3.Text);
            nrow.PhoneNumber = Convert.ToDecimal(textBox4.Text);
            nrow.Addres = Convert.ToString(textBox5.Text);
            nrow.Email = Convert.ToString(textBox6.Text);
            constructionCompanyDataSet.Client.AddClientRow(nrow);
            MessageBox.Show("Данные добавлены");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int a=dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
            MessageBox.Show("Данные удалены");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clientTableAdapter.Update(constructionCompanyDataSet);
        }
    }
}
