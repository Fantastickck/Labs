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
    public partial class Degree : Form
    {
        public Degree()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDegree newForm = new AddDegree();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateDegree newForm = new UpdateDegree();
            newForm.Show();
        }
    }
}
