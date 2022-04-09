using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class PubHouses : Form
    {
        public PubHouses()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("Первый дом", "999-999-999", "Первый адрес");
            dataGridView1.Rows.Add("Второй дом", "888-888-888", "Второй адрес");
        }

        private void button_Click(object sender, EventArgs e)
        {
            AddPubHouse newForm = new AddPubHouse();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.SelectedCells[0].RowIndex;
            string name = dataGridView1.Rows[row].Cells[0].Value.ToString();
            string phoneNumber = dataGridView1.Rows[row].Cells[1].Value.ToString();
            string address = dataGridView1.Rows[row].Cells[2].Value.ToString();
            UpdatePubHouse newForm = new UpdatePubHouse(name, phoneNumber, address);
            newForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
