namespace WinFormsApp1
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_pub = new System.Windows.Forms.Button();
            this.delete_pub = new System.Windows.Forms.Button();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.местаРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.домаПубликацийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типПубликацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ученыеСтепениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(884, 392);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Текст ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Дата публикации";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Количество страниц";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Код doi";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "УДК";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Издание";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Тип работы";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // create_pub
            // 
            this.create_pub.Location = new System.Drawing.Point(12, 487);
            this.create_pub.Name = "create_pub";
            this.create_pub.Size = new System.Drawing.Size(134, 55);
            this.create_pub.TabIndex = 1;
            this.create_pub.Text = "Добавить публикацию";
            this.create_pub.UseVisualStyleBackColor = true;
            this.create_pub.Click += new System.EventHandler(this.create_pub_Click);
            // 
            // delete_pub
            // 
            this.delete_pub.Location = new System.Drawing.Point(292, 487);
            this.delete_pub.Name = "delete_pub";
            this.delete_pub.Size = new System.Drawing.Size(134, 55);
            this.delete_pub.TabIndex = 2;
            this.delete_pub.Text = "Удалить публикацию";
            this.delete_pub.UseVisualStyleBackColor = true;
            this.delete_pub.Click += new System.EventHandler(this.delete_pub_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователиToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(908, 28);
            this.menuStrip3.TabIndex = 5;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователиToolStripMenuItem1,
            this.местаРаботыToolStripMenuItem,
            this.домаПубликацийToolStripMenuItem,
            this.типПубликацииToolStripMenuItem,
            this.ученыеСтепениToolStripMenuItem});
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.пользователиToolStripMenuItem.Text = "Другие данные";
            // 
            // пользователиToolStripMenuItem1
            // 
            this.пользователиToolStripMenuItem1.Name = "пользователиToolStripMenuItem1";
            this.пользователиToolStripMenuItem1.Size = new System.Drawing.Size(218, 26);
            this.пользователиToolStripMenuItem1.Text = "Авторы";
            this.пользователиToolStripMenuItem1.Click += new System.EventHandler(this.пользователиToolStripMenuItem1_Click);
            // 
            // местаРаботыToolStripMenuItem
            // 
            this.местаРаботыToolStripMenuItem.Name = "местаРаботыToolStripMenuItem";
            this.местаРаботыToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.местаРаботыToolStripMenuItem.Text = "Места работы";
            this.местаРаботыToolStripMenuItem.Click += new System.EventHandler(this.местаРаботыToolStripMenuItem_Click);
            // 
            // домаПубликацийToolStripMenuItem
            // 
            this.домаПубликацийToolStripMenuItem.Name = "домаПубликацийToolStripMenuItem";
            this.домаПубликацийToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.домаПубликацийToolStripMenuItem.Text = "Дома публикаций";
            this.домаПубликацийToolStripMenuItem.Click += new System.EventHandler(this.домаПубликацийToolStripMenuItem_Click);
            // 
            // типПубликацииToolStripMenuItem
            // 
            this.типПубликацииToolStripMenuItem.Name = "типПубликацииToolStripMenuItem";
            this.типПубликацииToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.типПубликацииToolStripMenuItem.Text = "Тип публикации";
            this.типПубликацииToolStripMenuItem.Click += new System.EventHandler(this.типПубликацииToolStripMenuItem_Click);
            // 
            // ученыеСтепениToolStripMenuItem
            // 
            this.ученыеСтепениToolStripMenuItem.Name = "ученыеСтепениToolStripMenuItem";
            this.ученыеСтепениToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.ученыеСтепениToolStripMenuItem.Text = "Ученые степени";
            this.ученыеСтепениToolStripMenuItem.Click += new System.EventHandler(this.ученыеСтепениToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Редактировать публикацию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(143, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 29);
            this.button3.TabIndex = 8;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "1 из ..";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete_pub);
            this.Controls.Add(this.create_pub);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip3);
            this.Name = "Home";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button create_pub;
        private Button delete_pub;
        private MenuStrip menuStrip3;
        private ToolStripMenuItem пользователиToolStripMenuItem;
        private ToolStripMenuItem пользователиToolStripMenuItem1;
        private ToolStripMenuItem местаРаботыToolStripMenuItem;
        private ToolStripMenuItem домаПубликацийToolStripMenuItem;
        private ToolStripMenuItem типПубликацииToolStripMenuItem;
        private ToolStripMenuItem ученыеСтепениToolStripMenuItem;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Button button2;
        private Button button3;
        private Label label1;
    }
}