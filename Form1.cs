using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab3DataSet.Фирма". При необходимости она может быть перемещена или удалена.
            this.фирмаTableAdapter.Fill(this.lab3DataSet.Фирма);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab3DataSet.Банк". При необходимости она может быть перемещена или удалена.
            this.банкTableAdapter.Fill(this.lab3DataSet.Банк);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();// Окончание редактирования
                                    // строки первой таблицы
            банкTableAdapter.Update(lab3DataSet.Банк);
            // Обновление первой таблицы в источнике данных
            dataGridView2.EndEdit();// Окончание редактирования
                                    // строки второй таблицы
            фирмаTableAdapter.Update(lab3DataSet.Фирма);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            банкTableAdapter.Connection.Close(); 
            фирмаTableAdapter.Connection.Close();
            Close();
        }
    }
}
