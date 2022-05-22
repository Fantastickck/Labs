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
    public partial class UpdatePubHouse : Form
    {
        public UpdatePubHouse()
        {
            InitializeComponent();
        }
        public UpdatePubHouse(string name, string phoneNumber, string address)
        {
            InitializeComponent();
            textBox1.Text = name;
            textBox2.Text = phoneNumber;
            textBox3.Text = address;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 43 && number != 45) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }
    }
}
