namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            label5.Text = "�������� � ������ ��������� ����������";
            label7.Text = "�������� � ������ ��������� ����������";
            comboBox1.Items.Add("ComboBox");
            CheckBox chbox1 = new CheckBox();
            CheckBox chbox2 = new CheckBox();   
            CheckBox chbox3 = new CheckBox();
            chbox1.Text = "���";
            chbox2.Text = "��";
            chbox1.Location = new Point(30, 30);
            chbox2.Location = new Point(30, 60);
            pictureBox1.Image = Image.FromFile("C:\\Users\\artem\\Desktop\\�����\\Yep\\Labs\\Lab1\\image.jpg");
            
            
            


            
        }
        

        private void button1_Click(object? sender, EventArgs e)
        {
            label5.Text = "�������� � ������ �������� Button \n" +
                    "Name - ��� ��������, �� �������� ����� ���������� � ���� \n" +
                    "Text - ����� �� ������ \n" +
                    "Width - ������ \n" +
                    "Margin ���������� ��� ������ ���������� ����� ���������� ����������. \n" +
                    "TextAlign ���������� ��� ������ ������ ������������ ������ �� ������.\n" +
                    "... \n" +
                    "Focus() ������������� ����� ����� �� ������� ����������. \n" +
                    "Show() ���������� ������� ����������. \n" +
                    "Equals(Object) ����������, ����� �� ��������� ������ �������� �������.";




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
            label5.Text = "�������� � ������ �������� ComboBox \n" +
                    "Name - ��� ��������, �� �������� ����� ���������� � ���� \n" +
                    "Text ���������� ��� ������ �����, ��������� � ���� ��������� ����������." +
                    "Size ���������� ��� ������ ������ � ������ �������� ����������. \n" +
                    "Items	 ���������� ������, �������������� ��������� ���������, ������������ � ������ ���� �� ������� ComboBox. \n" +
                    "Font ���������� ��� ������ ����� ������, ������������� ��������� ����������. \n" +
                    "... \n" +
                    "Select() ���������� ������� ����������. \n" +
                    "Show() ���������� ������� ����������. \n" +
                    "OnMouseClick(MouseEventArgs) �������� ������� MouseClick. \n" +
                    "FindForm()	���������� �����, � ������� ��������� ������� ����������. \n";

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            label5.Text = "�������� � ������ �������� ���������� TabControl:\n" +
                "1. Name-��� �������� �� �������� ����� ���������� � ����\n" +
                "2. Anchor-���������� ����� ����������, � �������� �������� ����������� ������� ����������\n" +
                "3. Margin-���������� ������� ����� ������ ���������\n" +
                "4. HotTrack-���������, ���������� �� ��� ������� ��� ��������� �� ���\n" +
                "5. TabPages-����� ������� � TabControl\n" +
                "������� �������� ���������� TabControl:\n" +
                "1. Click-���������� ��� ������ �������� ����������\n" +
                "2. Selected-���������� ����� ������ �������\n" +
                "3. DrowItem-���������� ��� ������������� ����������� �������/�������\n" +
                "4. StyleChanged-������� ��������� ����� � Control �������� ����� ����\n" +
                "5. Deselceted-���������� ��� ������ ������ ������� � �������� �������\n";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = "�������� � ������ �������� Label \n" +
                    "Name - ��� ��������, �� �������� ����� ���������� � ���� \n" +
                    "Text ���������� ��� ������ �����, ��������� � ���� ��������� ����������." +
                    "Size ���������� ��� ������ ������ � ������ �������� ����������. \n" +
                    "BorderStyle ���������� ��� ������ ����� ������� ��� �������� ����������. \n" +
                    "Font ���������� ��� ������ ����� ������, ������������� ��������� ����������. \n" +
                    "... \n" +
                    "Hide() �������� ������� ���������� �� ������������. \n" +
                    "Select() ���������� ������� ����������. \n" +
                    "ToString()	���������� ������, ������� ������������ ������� ������ Label. \n";

                   
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "TextBox")
            {
                label5.Text = "�������� � ������ �������� TextBox \n" +
                    "Name - ��� ��������, �� �������� ����� ���������� � ���� \n" +
                    "Text ���������� ��� ������ �����, ��������� � ���� ��������� ����������." +
                    "Size ���������� ��� ������ ������ � ������ �������� ����������. \n" +
                    "BorderStyle ���������� ��� ������ ����� ������� ��� �������� ����������. \n" +
                    "Font ���������� ��� ������ ����� ������, ������������� ��������� ����������. \n" +
                    "BackColor ���������� ��� ������ ���� ���� �������� ����������. \n" +
                    "... \n" +
                    "Clear() ������� ���� ����� �� �������� ���������� '��������� ����'. \n" +
                    "Copy()	�������� ������� ����� �� ���������� ���� � ����� ������. \n" +
                    "Cut() ���������� ������� ����� �� ���������� ���� � ����� ������. \n" +
                    "Paste() �������� ������� ��������� � ��������� ���� ���������� ������ ������. \n";

            }
        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "�������� � ������ �������� ���������� CheckBox:\n" +
                "1. Name-��� �������� �� �������� ����� ���������� � ����\n" +
                "2. Text-����� �� ��������\n" +
                "3. CheckState-���������� ��������� ����������\n" +
                "4. ThreeState-���������� ����������� CheckBox ������������ 3 ��������� ������ 2��\n" +
                "5. AutoChack-�������� �������������� ��������� ��������� ������ ��� ��� ������\n" +
                "������� �������� ���������� CheckBox:\n" +
                "1. Click-���������� ��� ������ �������� ����������\n" +
                "2. CheckedChanged-�������� ��� ��������� ������� Check\n" +
                "3. Paint-���������� ��� ����������� ��������\n" +
                "4. KeyPress-���������, ����� ������� ��������� � ������ � ������������ �������� � ��������� �������\n" +
                "5.CheckStateChanged-��������� ��� ��������� �������� CheckState";
         
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                label7.Text = "�������� � ������ �������� ���������� NumericUpDown:\n" +
                    "1. Name-��� �������� �� �������� ����� ���������� � ����\n" +
                    "2. Hexadecimal-��������� ������ �� �������� ��������� ���� ���� � ����������������� �������\n" +
                    "3. UpDownAlign-�������� ���� �� ��������� �� X\n" +
                    "4. Maximum-������������ �����\n" +
                    "5. Minimum-����������� �����\n" +
                    "������� �������� ���������� NumericUpDown:\n" +
                    "1. Click-���������� ��� ������ �������� ����������\n" +
                    "2. Scroll-��������� ��� ����������� �������� ������\n" +
                    "3. ValueChanged-���������� ��� ��������� �������� ������� ��������\n" +
                    "4. KeyUp-��������� � ������ ���������� �������\n" +
                    "5. Enter-����������, ����� ������� ���������� ���������� ��������"; 
            }
            else { label7.Text = "�������� � ������ ��������� ����������"; }
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
            label8.Text = "�������� � ������ �������� ���������� PictureBox:\n" +
                "1. Name-��� �������� �� �������� ����� ���������� � ����\n" +
                "2. ErrorImage-����������� ������������ ��� ������������� �������� �������\n" +
                "3. InitialImage-����������� ������������ ��� �������� �������\n" +
                "4. Image-����������� � PictureBox\n" +
                "5. Visible-���������� ������������ ��� ����� �������\n" +
                "������� �������� ���������� PictureBox:\n" +
                "1. Click-���������� ��� ������ �������� ����������\n" +
                "2. LoadCompleted-��������� ��� ��������� �������� � PictureBox\n" +
                "3. LoadProgressChanged-��������� ��� ��������� ���� �������� �������� � PictureBox\n" +
                "4. Move-���������� ��� ����������� �������\n" +
                "5. Resize-���������� ��� ��������� ������� ��������";
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "MaskedTextBox")
            {
                label5.Text = "�������� � ������ �������� ���������� MaskedTextBox:\n" +
                    "1. Name-��� �������� �� �������� ����� ���������� � ����\n" +
                    "2. Text-����� �� ��������\n" +
                    "3. PromptChar-��������� ������, �������������� ��� ����������������\n" +
                    "4. BackColor-������� ����\n" +
                    "5. TextAlign-����� ������������ ������ � ��������\n" +
                    "������� �������� ���������� MaskedTextBox:\n" +
                    "1. Click-���������� ��� ������ �������� ����������\n" +
                    "2. MaskInputRejected-����������, ���� ������ �� ������������� �������� �����\n" +
                    "3. TypeValidationComplete- ���������� ����� ValidatingType �������� ������ ������\n" +
                    "4. CollectionChanged-���������� ��� ��������� �������������� ���������\n" +
                    "5. Resize-����������� ��� ��������� ������� ��������"; 
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "�������� � ������ RadioButton \n" +
                " \n" +
                "Checked ���������� ��� ������ ��������, �����������, ������ �� ������ ������� ����������. \n" +
                "Font ���������� ��� ������ ����� ������, ������������� ��������� ����������. \n" +
                "Name ���������� ��� ������ ��� �������� ����������. \n" +
                "Size ���������� ��� ������ ������ � ������ �������� ����������. \n" +
                "Text ���������� ��� ������ �����, ��������� � ���� ��������� ����������. \n" +
                "... \n" +
                "Hide() �������� ������� ���������� �� ������������. \n" +
                "Select() ���������� ������� ����������. \n";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "������� ��";
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            label5.Text = "�������� � ������ �������� ���������� MenuStrip:\n" +
                "Name-��� �������� �� �������� ����� ���������� � ����\n" +
                "BackColor-���� ���� ��������\n" +
                "Font-����� ������\n" +
                "ForeColor-���� ��� ������\n" +
                "Text-����� �� ��������\n" +
                "������� �������� ���������� MenuStrip:\n" +
                "Click-���������� ��� ������ �������� ����������\n" +
                "DragDrop-���������� ��� ���������� �������� ��������������\n" +
                "Enter-���������� ��� ����� � ������� ����������\n" +
                "FontChanged-���������� ��� ��������� �������� �������� Font\n" +
                "GiveFeedback-���������� ��� ���������� �������� ��������������\n";
        }
    }
}