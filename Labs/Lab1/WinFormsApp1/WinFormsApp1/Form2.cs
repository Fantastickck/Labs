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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label1.Text = "Свойства: \n" +
                "Text: определяет заголовок формы \n" +
                "Name: устанавливает имя формы - точнее имя класса, который наследуется от класса Form \n" +
                "BackColor: указывает на фоновый цвет формы. Щелкнув на это свойство, мы сможем выбрать тот цвет, который нам подходит из списка предложенных цветов или цветовой палитры \n" +
                "Font: задает шрифт для всей формы и всех помещенных на нее элементов управления. Однако, задав у элементов формы свой шрифт, мы можем тем самым переопределить его \n" +
                "Size: определяет начальный размер формы \n" +
                "Методы: \n" +
                "Activate()	Активирует форму и перемещает на нее фокус. \n" +
                "CenterToScreen() Выравнивает форму по центру текущего экрана. \n" +
                "Close() Закрывает форму. \n";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
