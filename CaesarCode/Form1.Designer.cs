namespace CaesarCode
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opentextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opencrtextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savetextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savecrtextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.криптоанализToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.частотаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freqTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freqsFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикЧастотБуквРусскогоЯзыкаИШифртекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.криптоанализToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opentextToolStripMenuItem,
            this.opencrtextToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Загрузить";
            // 
            // opentextToolStripMenuItem
            // 
            this.opentextToolStripMenuItem.Name = "opentextToolStripMenuItem";
            this.opentextToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.opentextToolStripMenuItem.Text = "&Исходный текст";
            this.opentextToolStripMenuItem.Click += new System.EventHandler(this.opentextToolStripMenuItem_Click);
            // 
            // opencrtextToolStripMenuItem
            // 
            this.opencrtextToolStripMenuItem.Name = "opencrtextToolStripMenuItem";
            this.opencrtextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opencrtextToolStripMenuItem.Text = "&Шифртекст";
            this.opencrtextToolStripMenuItem.Click += new System.EventHandler(this.opencrtextToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savetextToolStripMenuItem,
            this.savecrtextToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Сохранить";
            // 
            // savetextToolStripMenuItem
            // 
            this.savetextToolStripMenuItem.Name = "savetextToolStripMenuItem";
            this.savetextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.savetextToolStripMenuItem.Text = "Исходный текст";
            this.savetextToolStripMenuItem.Click += new System.EventHandler(this.savetextToolStripMenuItem_Click);
            // 
            // savecrtextToolStripMenuItem
            // 
            this.savecrtextToolStripMenuItem.Name = "savecrtextToolStripMenuItem";
            this.savecrtextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.savecrtextToolStripMenuItem.Text = "Шифртекст";
            this.savecrtextToolStripMenuItem.Click += new System.EventHandler(this.savecrtextToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "&Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // криптоанализToolStripMenuItem
            // 
            this.криптоанализToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.частотаToolStripMenuItem,
            this.графикЧастотБуквРусскогоЯзыкаИШифртекстаToolStripMenuItem});
            this.криптоанализToolStripMenuItem.Name = "криптоанализToolStripMenuItem";
            this.криптоанализToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.криптоанализToolStripMenuItem.Text = "&Криптоанализ";
            // 
            // частотаToolStripMenuItem
            // 
            this.частотаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.freqTextToolStripMenuItem,
            this.freqsFromFileToolStripMenuItem});
            this.частотаToolStripMenuItem.Name = "частотаToolStripMenuItem";
            this.частотаToolStripMenuItem.Size = new System.Drawing.Size(351, 22);
            this.частотаToolStripMenuItem.Text = "Частоты букв";
            // 
            // freqTextToolStripMenuItem
            // 
            this.freqTextToolStripMenuItem.Name = "freqTextToolStripMenuItem";
            this.freqTextToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.freqTextToolStripMenuItem.Text = "Сохранить частоты из открытого текста в файл";
            this.freqTextToolStripMenuItem.Click += new System.EventHandler(this.freqTextToolStripMenuItem_Click);
            // 
            // freqsFromFileToolStripMenuItem
            // 
            this.freqsFromFileToolStripMenuItem.Name = "freqsFromFileToolStripMenuItem";
            this.freqsFromFileToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.freqsFromFileToolStripMenuItem.Text = "Загрузить частоты из файла";
            this.freqsFromFileToolStripMenuItem.Click += new System.EventHandler(this.freqsFromFileToolStripMenuItem_Click);
            // 
            // графикЧастотБуквРусскогоЯзыкаИШифртекстаToolStripMenuItem
            // 
            this.графикЧастотБуквРусскогоЯзыкаИШифртекстаToolStripMenuItem.Enabled = false;
            this.графикЧастотБуквРусскогоЯзыкаИШифртекстаToolStripMenuItem.Name = "графикЧастотБуквРусскогоЯзыкаИШифртекстаToolStripMenuItem";
            this.графикЧастотБуквРусскогоЯзыкаИШифртекстаToolStripMenuItem.Size = new System.Drawing.Size(351, 22);
            this.графикЧастотБуквРусскогоЯзыкаИШифртекстаToolStripMenuItem.Text = "График частот букв русского языка и шифртекста";
            this.графикЧастотБуквРусскогоЯзыкаИШифртекстаToolStripMenuItem.Click += new System.EventHandler(this.графикЧастотБуквРусскогоЯзыкаИШифртекстаToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(334, 270);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(350, 53);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(334, 269);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Исходный текст:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Шифртекст:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 360);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(699, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 328);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ключ:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 20);
            this.button1.TabIndex = 8;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(334, 20);
            this.button2.TabIndex = 9;
            this.button2.Text = "Расшифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Текстовый файл|*.txt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Текстовый файл|*.txt";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(87, 17);
            this.toolStripStatusLabel2.Text = "| Частоты букв";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusLabel3.Text = "не загружены";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(220, 17);
            this.toolStripStatusLabel4.Text = "| Кол-во символов открытого текста: 0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabel5.Text = "; шифртекста: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 382);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Шифр Цезаря, Михайлов Юрий Юрьевич, ИБ186";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem криптоанализToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opentextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opencrtextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savetextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savecrtextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem частотаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freqTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freqsFromFileToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem графикЧастотБуквРусскогоЯзыкаИШифртекстаToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
    }
}

