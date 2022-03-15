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
                    "TextAlign Возвращает или задает способ выравнивания текста на кнопке.\n" +
                    "... \n" +
                    "Focus() Устанавливает фокус ввода на элемент управления. \n" +
                    "Show() Отображает элемент управления. \n" +
                    "Equals(Object) Определяет, равен ли указанный объект текущему объекту.";




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
                    "Name - имя элемента, по которому можно обращаться в коде \n" +
                    "Text Возвращает или задает текст, связанный с этим элементом управления." +
                    "Size Возвращает или задает высоту и ширину элемента управления. \n" +
                    "Items	 Возвращает объект, представляющий коллекцию элементов, содержащихся в данном поле со списком ComboBox. \n" +
                    "Font Возвращает или задает шрифт текста, отображаемого элементом управления. \n" +
                    "... \n" +
                    "Select() Активирует элемент управления. \n" +
                    "Show() Отображает элемент управления. \n" +
                    "OnMouseClick(MouseEventArgs) Вызывает событие MouseClick. \n" +
                    "FindForm()	Возвращает форму, в которой находится элемент управления. \n";

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            label5.Text = "Свойства и методы элемента управления TabControl:\n" +
                "1. Name-имя элемента по которому можно обращаться в коде\n" +
                "2. Anchor-определяет грани контейнера, к которому привязан определённый элемент управления\n" +
                "3. Margin-определяет отступы между полями элементов\n" +
                "4. HotTrack-указывает, изменяется ли вид вкладок при наведении на них\n" +
                "5. TabPages-число страниц в TabControl\n" +
                "События элемента управления TabControl:\n" +
                "1. Click-происходит при щелчке элемента управления\n" +
                "2. Selected-происходит после выбора вкладки\n" +
                "3. DrowItem-происходит при необходимости прорисовать элемент/область\n" +
                "4. StyleChanged-событие возникает когда в Control изменяют стиль окна\n" +
                "5. Deselceted-просиходит при отмене выбора вкладки в качестве главной\n";
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
                    "Name - имя элемента, по которому можно обращаться в коде \n" +
                    "Text Возвращает или задает текст, связанный с этим элементом управления." +
                    "Size Возвращает или задает высоту и ширину элемента управления. \n" +
                    "BorderStyle Возвращает или задает стиль границы для элемента управления. \n" +
                    "Font Возвращает или задает шрифт текста, отображаемого элементом управления. \n" +
                    "... \n" +
                    "Hide() Скрывает элемент управления от пользователя. \n" +
                    "Select() Активирует элемент управления. \n" +
                    "ToString()	Возвращает строку, которая представляет текущий объект Label. \n";

                   
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "TextBox")
            {
                label5.Text = "Свойства и методы элементы TextBox \n" +
                    "Name - имя элемента, по которому можно обращаться в коде \n" +
                    "Text Возвращает или задает текст, связанный с этим элементом управления." +
                    "Size Возвращает или задает высоту и ширину элемента управления. \n" +
                    "BorderStyle Возвращает или задает стиль границы для элемента управления. \n" +
                    "Font Возвращает или задает шрифт текста, отображаемого элементом управления. \n" +
                    "BackColor Возвращает или задает цвет фона элемента управления. \n" +
                    "... \n" +
                    "Clear() Удаляет весь текст из элемента управления 'Текстовое поле'. \n" +
                    "Copy()	Копирует текущий выбор из текстового поля в буфер обмена. \n" +
                    "Cut() Перемещает текущий выбор из текстового поля в буфер обмена. \n" +
                    "Paste() Заменяет текущее выделение в текстовом поле содержимым буфера обмена. \n";

            }
        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "Свойства и методы элемента управления CheckBox:\n" +
                "1. Name-имя элемента по которому можно обращаться в коде\n" +
                "2. Text-текст на элементе\n" +
                "3. CheckState-определяет состояние компонента\n" +
                "4. ThreeState-определяет возможность CheckBox использовать 3 состояния вместо 2ух\n" +
                "5. AutoChack-вызывает автоматическое изменение состояния флажка при его выборе\n" +
                "События элемента управления CheckBox:\n" +
                "1. Click-происходит при щелчке элемента управления\n" +
                "2. CheckedChanged-воникает при изменении свойств Check\n" +
                "3. Paint-происходит при перерисовки элемента\n" +
                "4. KeyPress-возникает, когда элемент находится в фокусе и пользоваетль нажимает и отпускает клавишу\n" +
                "5.CheckStateChanged-возникает при изменении свойства CheckState";
         
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                label7.Text = "Свойства и методы элемента управления NumericUpDown:\n" +
                    "1. Name-имя элемента по которому можно обращаться в коде\n" +
                    "2. Hexadecimal-указывает должно ли значение числового поля быть в шестнадцатиричном формате\n" +
                    "3. UpDownAlign-прижатие поля со стрелками по X\n" +
                    "4. Maximum-максимальное число\n" +
                    "5. Minimum-минимальное число\n" +
                    "События элемента управления NumericUpDown:\n" +
                    "1. Click-происходит при щелчке элемента управления\n" +
                    "2. Scroll-возникает при перемещении ползунка полосы\n" +
                    "3. ValueChanged-происходит при изменении значения данного элемента\n" +
                    "4. KeyUp-возникает в момент отпускания клавиши\n" +
                    "5. Enter-происходит, когда элемент управления становится активным"; 
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
            label8.Text = "Свойства и методы элемента управления PictureBox:\n" +
                "1. Name-имя элемента по которому можно обращаться в коде\n" +
                "2. ErrorImage-изображение отображаемое при невозможности загрузки другого\n" +
                "3. InitialImage-изображение отображаемое при загрузке другого\n" +
                "4. Image-изображение в PictureBox\n" +
                "5. Visible-определяет отображается или скрыт элемент\n" +
                "События элемента управления PictureBox:\n" +
                "1. Click-происходит при щелчке элемента управления\n" +
                "2. LoadCompleted-возникает при окончании загрузки в PictureBox\n" +
                "3. LoadProgressChanged-возникает при изменении хода процесса загрузки в PictureBox\n" +
                "4. Move-происходит при перемещении элмента\n" +
                "5. Resize-просиходит при изменении размера элемента";
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "MaskedTextBox")
            {
                label5.Text = "Свойства и методы элемента управления MaskedTextBox:\n" +
                    "1. Name-имя элемента по которому можно обращаться в коде\n" +
                    "2. Text-текст на элементе\n" +
                    "3. PromptChar-указывает символ, использующийся как местозаполнитель\n" +
                    "4. BackColor-фоновый цвет\n" +
                    "5. TextAlign-задаёт выравнивание текста в элементе\n" +
                    "События элемента управления MaskedTextBox:\n" +
                    "1. Click-происходит при щелчке элемента управления\n" +
                    "2. MaskInputRejected-происходит, если символ не удовлетворяет условиям маски\n" +
                    "3. TypeValidationComplete- происходит когда ValidatingType завершил разбор текста\n" +
                    "4. CollectionChanged-происходит при изменении принадлежности коллекции\n" +
                    "5. Resize-происиходит при изменении размера элемента"; 
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "Свойства и методы RadioButton \n" +
                " \n" +
                "Checked Возвращает или задает значение, указывающее, выбран ли данный элемент управления. \n" +
                "Font Возвращает или задает шрифт текста, отображаемого элементом управления. \n" +
                "Name Возвращает или задает имя элемента управления. \n" +
                "Size Возвращает или задает высоту и ширину элемента управления. \n" +
                "Text Возвращает или задает текст, связанный с этим элементом управления. \n" +
                "... \n" +
                "Hide() Скрывает элемент управления от пользователя. \n" +
                "Select() Активирует элемент управления. \n";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "Нажмите ДА";
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            label5.Text = "Свойства и методы элемента управления MenuStrip:\n" +
                "Name-имя элемента по которому можно обращаться в коде\n" +
                "BackColor-цвет фона элемента\n" +
                "Font-выбор шрифта\n" +
                "ForeColor-цвет для текста\n" +
                "Text-текст на элементе\n" +
                "События элемента управления MenuStrip:\n" +
                "Click-происходит при щелчке элемента управления\n" +
                "DragDrop-вызывается при завершении операции перетаскивания\n" +
                "Enter-происходит при входе в элемент управления\n" +
                "FontChanged-происходит при изменении значения свойства Font\n" +
                "GiveFeedback-вызывается при выполнении операции перетаскивания\n";
        }
    }
}