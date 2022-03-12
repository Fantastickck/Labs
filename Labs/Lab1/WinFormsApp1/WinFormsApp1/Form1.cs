namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            label5.Text = "Свойства и методы элементов управления";
            label7.Text = "Свойства и методы элементов управления";
            comboBox1.Items.Add("ComboBox");
            CheckBox chbox1 = new CheckBox();
            CheckBox chbox2 = new CheckBox();   
            CheckBox chbox3 = new CheckBox();
            chbox1.Text = "НЕТ";
            chbox2.Text = "ДА";
            chbox1.Location = new Point(30, 30);
            chbox2.Location = new Point(30, 60);
            pictureBox1.Image = Image.FromFile("C:\\Users\\artem\\Desktop\\ПАПКА\\Yep\\Labs\\Lab1\\image.jpg");
            
            
            


            
        }
        

        private void button1_Click(object? sender, EventArgs e)
        {
            label5.Text = "Свойства и методы элемента Button \n" +
                    "Name - имя элемента, по которому можно обращаться в коде \n" +
                    "Text - Текст на кнопке \n" +
                    "Width - ширина \n" +
                    "Margin Возвращает или задает расстояние между элементами управления. \n" +
                    "... \n" +
                    "Focus() Устанавливает фокус ввода на элемент управления. \n";
                    
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = "Свойства и методы элемента ComboBox \n" +
                    "1. Name - имя элемента, по которому можно обращаться в коде \n" +
                    "2. Text - Текст на кнопке";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            label5.Text = "Свойства и методы элемента TabControl \n" +
                "\n" +
                "\n";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = "Свойства и методы элемента Label \n" +
                    "1. Name - имя элемента, по которому можно обращаться в коде \n" +
                    "2. Text - Текст на кнопке \n";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "TextBox")
            {
                label5.Text = "Свойства и методы элементы TextBox";
            }
        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "Свойства и методы элемента CheckBox";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                label7.Text = "Свойства и методы NumericUpDown";
            }
            else { label7.Text = "Свойства и методы элементов управления"; }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            label8.Text = "PictureBox";
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "MaskedTextBox")
            {
                label5.Text = "Свойства и методы элемента MaskedTextBox";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "RadioButton";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "Нажмите ДА";
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            label5.Text = "MenuStrip";
        }
    }
}