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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(884, 392);
            this.dataGridView1.TabIndex = 0;
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
            this.пользователиToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.пользователиToolStripMenuItem1.Text = "Авторы";
            this.пользователиToolStripMenuItem1.Click += new System.EventHandler(this.пользователиToolStripMenuItem1_Click);
            // 
            // местаРаботыToolStripMenuItem
            // 
            this.местаРаботыToolStripMenuItem.Name = "местаРаботыToolStripMenuItem";
            this.местаРаботыToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.местаРаботыToolStripMenuItem.Text = "Места работы";
            this.местаРаботыToolStripMenuItem.Click += new System.EventHandler(this.местаРаботыToolStripMenuItem_Click);
            // 
            // домаПубликацийToolStripMenuItem
            // 
            this.домаПубликацийToolStripMenuItem.Name = "домаПубликацийToolStripMenuItem";
            this.домаПубликацийToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.домаПубликацийToolStripMenuItem.Text = "Дома публикаций";
            this.домаПубликацийToolStripMenuItem.Click += new System.EventHandler(this.домаПубликацийToolStripMenuItem_Click);
            // 
            // типПубликацииToolStripMenuItem
            // 
            this.типПубликацииToolStripMenuItem.Name = "типПубликацииToolStripMenuItem";
            this.типПубликацииToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.типПубликацииToolStripMenuItem.Text = "Тип публикации";
            this.типПубликацииToolStripMenuItem.Click += new System.EventHandler(this.типПубликацииToolStripMenuItem_Click);
            // 
            // ученыеСтепениToolStripMenuItem
            // 
            this.ученыеСтепениToolStripMenuItem.Name = "ученыеСтепениToolStripMenuItem";
            this.ученыеСтепениToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 554);
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
    }
}