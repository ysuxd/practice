using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ConstructionCompanyDataSet1TableAdapters;
using WindowsFormsApp1.ConstructionCompanyDataSetTableAdapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "constructionCompanyDataSet2.Materials". При необходимости она может быть перемещена или удалена.
            this.materialsTableAdapter.Fill(this.constructionCompanyDataSet2.Materials);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 cfrm = new Form2();
            cfrm.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
            MessageBox.Show("Данные удалены");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConstructionCompanyDataSet2.MaterialsRow nrow = (ConstructionCompanyDataSet2.MaterialsRow)constructionCompanyDataSet2.Materials.NewRow();
            nrow.id_material = Convert.ToInt32(textBox1.Text);
            nrow.Type = Convert.ToString(textBox2.Text);
            nrow.Quantity = Convert.ToDecimal(textBox3.Text);
            nrow.Price = Convert.ToDecimal(textBox4.Text);
            nrow.Total = Convert.ToDecimal(textBox5.Text);
            constructionCompanyDataSet2.Materials.AddMaterialsRow(nrow);
            MessageBox.Show("Данные добавлены");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            materialsTableAdapter.Update(constructionCompanyDataSet2);
        }
    }
}
