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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "constructionCompanyDataSet3.Project". При необходимости она может быть перемещена или удалена.
            this.projectTableAdapter.Fill(this.constructionCompanyDataSet3.Project);

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
            ConstructionCompanyDataSet3.ProjectRow nrow = (ConstructionCompanyDataSet3.ProjectRow)constructionCompanyDataSet3.Project.NewRow();
            nrow.id_project = Convert.ToInt32(textBox1.Text);
            nrow.id_order = Convert.ToInt32(textBox2.Text);
            nrow.Compound = Convert.ToString(textBox3.Text);
            nrow.Price = Convert.ToDecimal(textBox4.Text);
            nrow.Dimensions = Convert.ToDecimal(textBox5.Text);
            constructionCompanyDataSet3.Project.AddProjectRow(nrow);
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
           projectTableAdapter.Update(constructionCompanyDataSet3);
        }
    }
}
