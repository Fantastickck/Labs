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
    public partial class PlacesOfWork : Form
    {
        public PlacesOfWork()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            AddPlaceOfWork newForm = new AddPlaceOfWork();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdatePlaceOfWork newForm = new UpdatePlaceOfWork();
            newForm.Show();
        }
    }
}
