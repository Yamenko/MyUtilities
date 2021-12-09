namespace MyUtilities_project
{
    partial class MainForm
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
            this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.блокнотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Add_date = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Add_time = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Load = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Counter = new System.Windows.Forms.TabPage();
            this.label_Counter = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Minus = new System.Windows.Forms.Button();
            this.button_Plus = new System.Windows.Forms.Button();
            this.tabPage_Generator = new System.Windows.Forms.TabPage();
            this.checkBox_Random = new System.Windows.Forms.CheckBox();
            this.button_Random_copy = new System.Windows.Forms.Button();
            this.button_Random_clear = new System.Windows.Forms.Button();
            this.textBox_Random = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label_Random = new System.Windows.Forms.Label();
            this.button_Random = new System.Windows.Forms.Button();
            this.tabPage_Notepad = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage_Pass = new System.Windows.Forms.TabPage();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.button_Pass = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Spec_char = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.numeric_Lenght_pass = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_Counter.SuspendLayout();
            this.tabPage_Generator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage_Notepad.SuspendLayout();
            this.tabPage_Pass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Lenght_pass)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.блокнотToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Exit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(90, 36);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // ToolStripMenuItem_Exit
            // 
            this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(216, 44);
            this.ToolStripMenuItem_Exit.Text = "Выход";
            this.ToolStripMenuItem_Exit.Click += new System.EventHandler(this.ToolStripMenuItem_Exit_Click);
            // 
            // блокнотToolStripMenuItem
            // 
            this.блокнотToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Add_date,
            this.ToolStripMenuItem_Add_time,
            this.toolStripMenuItem1,
            this.ToolStripMenuItem_Save,
            this.ToolStripMenuItem_Load});
            this.блокнотToolStripMenuItem.Name = "блокнотToolStripMenuItem";
            this.блокнотToolStripMenuItem.Size = new System.Drawing.Size(125, 36);
            this.блокнотToolStripMenuItem.Text = "Блокнот";
            // 
            // ToolStripMenuItem_Add_date
            // 
            this.ToolStripMenuItem_Add_date.Name = "ToolStripMenuItem_Add_date";
            this.ToolStripMenuItem_Add_date.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.ToolStripMenuItem_Add_date.Size = new System.Drawing.Size(464, 44);
            this.ToolStripMenuItem_Add_date.Text = "Вставить дату";
            this.ToolStripMenuItem_Add_date.Click += new System.EventHandler(this.ToolStripMenuItem_Add_date_Click);
            // 
            // ToolStripMenuItem_Add_time
            // 
            this.ToolStripMenuItem_Add_time.Name = "ToolStripMenuItem_Add_time";
            this.ToolStripMenuItem_Add_time.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.ToolStripMenuItem_Add_time.Size = new System.Drawing.Size(464, 44);
            this.ToolStripMenuItem_Add_time.Text = "Вставить время";
            this.ToolStripMenuItem_Add_time.Click += new System.EventHandler(this.ToolStripMenuItem_Add_time_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(461, 6);
            // 
            // ToolStripMenuItem_Save
            // 
            this.ToolStripMenuItem_Save.Name = "ToolStripMenuItem_Save";
            this.ToolStripMenuItem_Save.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.ToolStripMenuItem_Save.Size = new System.Drawing.Size(464, 44);
            this.ToolStripMenuItem_Save.Text = "Сохранить";
            this.ToolStripMenuItem_Save.Click += new System.EventHandler(this.ToolStripMenuItem_Save_Click);
            // 
            // ToolStripMenuItem_Load
            // 
            this.ToolStripMenuItem_Load.Name = "ToolStripMenuItem_Load";
            this.ToolStripMenuItem_Load.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.ToolStripMenuItem_Load.Size = new System.Drawing.Size(464, 44);
            this.ToolStripMenuItem_Load.Text = "Загрузить";
            this.ToolStripMenuItem_Load.Click += new System.EventHandler(this.ToolStripMenuItem_Load_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_About});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(128, 36);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // ToolStripMenuItem_About
            // 
            this.ToolStripMenuItem_About.Name = "ToolStripMenuItem_About";
            this.ToolStripMenuItem_About.Size = new System.Drawing.Size(296, 44);
            this.ToolStripMenuItem_About.Text = "О программе";
            this.ToolStripMenuItem_About.Click += new System.EventHandler(this.ToolStripMenuItem_About_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Counter);
            this.tabControl1.Controls.Add(this.tabPage_Generator);
            this.tabControl1.Controls.Add(this.tabPage_Notepad);
            this.tabControl1.Controls.Add(this.tabPage_Pass);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 410);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            this.tabControl1.Deselected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Deselected);
            // 
            // tabPage_Counter
            // 
            this.tabPage_Counter.Controls.Add(this.label_Counter);
            this.tabPage_Counter.Controls.Add(this.button_Clear);
            this.tabPage_Counter.Controls.Add(this.button_Minus);
            this.tabPage_Counter.Controls.Add(this.button_Plus);
            this.tabPage_Counter.Location = new System.Drawing.Point(8, 39);
            this.tabPage_Counter.Name = "tabPage_Counter";
            this.tabPage_Counter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Counter.Size = new System.Drawing.Size(784, 363);
            this.tabPage_Counter.TabIndex = 0;
            this.tabPage_Counter.Text = "Счетчик";
            this.tabPage_Counter.UseVisualStyleBackColor = true;
            // 
            // label_Counter
            // 
            this.label_Counter.AutoSize = true;
            this.label_Counter.Location = new System.Drawing.Point(173, 145);
            this.label_Counter.Name = "label_Counter";
            this.label_Counter.Size = new System.Drawing.Size(24, 25);
            this.label_Counter.TabIndex = 3;
            this.label_Counter.Text = "0";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(314, 132);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(145, 51);
            this.button_Clear.TabIndex = 2;
            this.button_Clear.Text = "Сброс";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Minus
            // 
            this.button_Minus.Location = new System.Drawing.Point(107, 228);
            this.button_Minus.Name = "button_Minus";
            this.button_Minus.Size = new System.Drawing.Size(145, 51);
            this.button_Minus.TabIndex = 1;
            this.button_Minus.Text = "-";
            this.button_Minus.UseVisualStyleBackColor = true;
            this.button_Minus.Click += new System.EventHandler(this.button_Minus_Click);
            // 
            // button_Plus
            // 
            this.button_Plus.Location = new System.Drawing.Point(107, 41);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Size = new System.Drawing.Size(145, 51);
            this.button_Plus.TabIndex = 0;
            this.button_Plus.Text = "+";
            this.button_Plus.UseVisualStyleBackColor = true;
            this.button_Plus.Click += new System.EventHandler(this.button_Plus_Click);
            // 
            // tabPage_Generator
            // 
            this.tabPage_Generator.Controls.Add(this.checkBox_Random);
            this.tabPage_Generator.Controls.Add(this.button_Random_copy);
            this.tabPage_Generator.Controls.Add(this.button_Random_clear);
            this.tabPage_Generator.Controls.Add(this.textBox_Random);
            this.tabPage_Generator.Controls.Add(this.label4);
            this.tabPage_Generator.Controls.Add(this.label3);
            this.tabPage_Generator.Controls.Add(this.label2);
            this.tabPage_Generator.Controls.Add(this.numericUpDown2);
            this.tabPage_Generator.Controls.Add(this.numericUpDown1);
            this.tabPage_Generator.Controls.Add(this.label_Random);
            this.tabPage_Generator.Controls.Add(this.button_Random);
            this.tabPage_Generator.Location = new System.Drawing.Point(8, 39);
            this.tabPage_Generator.Name = "tabPage_Generator";
            this.tabPage_Generator.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Generator.Size = new System.Drawing.Size(784, 363);
            this.tabPage_Generator.TabIndex = 1;
            this.tabPage_Generator.Text = "Генератор";
            this.tabPage_Generator.UseVisualStyleBackColor = true;
            // 
            // checkBox_Random
            // 
            this.checkBox_Random.AutoSize = true;
            this.checkBox_Random.Location = new System.Drawing.Point(46, 161);
            this.checkBox_Random.Name = "checkBox_Random";
            this.checkBox_Random.Size = new System.Drawing.Size(179, 29);
            this.checkBox_Random.TabIndex = 10;
            this.checkBox_Random.Text = "Без повторов";
            this.checkBox_Random.UseVisualStyleBackColor = true;
            // 
            // button_Random_copy
            // 
            this.button_Random_copy.Location = new System.Drawing.Point(305, 215);
            this.button_Random_copy.Name = "button_Random_copy";
            this.button_Random_copy.Size = new System.Drawing.Size(195, 73);
            this.button_Random_copy.TabIndex = 9;
            this.button_Random_copy.Text = "Копировать";
            this.button_Random_copy.UseVisualStyleBackColor = true;
            this.button_Random_copy.Click += new System.EventHandler(this.button_Random_copy_Click);
            // 
            // button_Random_clear
            // 
            this.button_Random_clear.Location = new System.Drawing.Point(305, 136);
            this.button_Random_clear.Name = "button_Random_clear";
            this.button_Random_clear.Size = new System.Drawing.Size(195, 73);
            this.button_Random_clear.TabIndex = 8;
            this.button_Random_clear.Text = "Очистить";
            this.button_Random_clear.UseVisualStyleBackColor = true;
            this.button_Random_clear.Click += new System.EventHandler(this.button_Random_clear_Click);
            // 
            // textBox_Random
            // 
            this.textBox_Random.Location = new System.Drawing.Point(537, 136);
            this.textBox_Random.Multiline = true;
            this.textBox_Random.Name = "textBox_Random";
            this.textBox_Random.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Random.Size = new System.Drawing.Size(117, 152);
            this.textBox_Random.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Диапазон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "До";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "От";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(149, 99);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(149, 57);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown1.TabIndex = 2;
            // 
            // label_Random
            // 
            this.label_Random.AutoSize = true;
            this.label_Random.Location = new System.Drawing.Point(570, 81);
            this.label_Random.Name = "label_Random";
            this.label_Random.Size = new System.Drawing.Size(24, 25);
            this.label_Random.TabIndex = 1;
            this.label_Random.Text = "0";
            // 
            // button_Random
            // 
            this.button_Random.Location = new System.Drawing.Point(305, 57);
            this.button_Random.Name = "button_Random";
            this.button_Random.Size = new System.Drawing.Size(195, 73);
            this.button_Random.TabIndex = 0;
            this.button_Random.Text = "Создать";
            this.button_Random.UseVisualStyleBackColor = true;
            this.button_Random.Click += new System.EventHandler(this.button_Random_Click);
            // 
            // tabPage_Notepad
            // 
            this.tabPage_Notepad.Controls.Add(this.richTextBox1);
            this.tabPage_Notepad.Location = new System.Drawing.Point(8, 39);
            this.tabPage_Notepad.Name = "tabPage_Notepad";
            this.tabPage_Notepad.Size = new System.Drawing.Size(784, 363);
            this.tabPage_Notepad.TabIndex = 2;
            this.tabPage_Notepad.Text = "Блокнот";
            this.tabPage_Notepad.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(784, 363);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPage_Pass
            // 
            this.tabPage_Pass.Controls.Add(this.textBox_Pass);
            this.tabPage_Pass.Controls.Add(this.button_Pass);
            this.tabPage_Pass.Controls.Add(this.label5);
            this.tabPage_Pass.Controls.Add(this.textBox_Spec_char);
            this.tabPage_Pass.Controls.Add(this.label1);
            this.tabPage_Pass.Controls.Add(this.checkedListBox1);
            this.tabPage_Pass.Controls.Add(this.numeric_Lenght_pass);
            this.tabPage_Pass.Location = new System.Drawing.Point(8, 39);
            this.tabPage_Pass.Name = "tabPage_Pass";
            this.tabPage_Pass.Size = new System.Drawing.Size(784, 363);
            this.tabPage_Pass.TabIndex = 3;
            this.tabPage_Pass.Text = "Пароли";
            this.tabPage_Pass.UseVisualStyleBackColor = true;
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Location = new System.Drawing.Point(415, 106);
            this.textBox_Pass.MaxLength = 10;
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(333, 31);
            this.textBox_Pass.TabIndex = 6;
            // 
            // button_Pass
            // 
            this.button_Pass.Location = new System.Drawing.Point(415, 3);
            this.button_Pass.Name = "button_Pass";
            this.button_Pass.Size = new System.Drawing.Size(333, 87);
            this.button_Pass.TabIndex = 5;
            this.button_Pass.Text = "Создать";
            this.button_Pass.UseVisualStyleBackColor = true;
            this.button_Pass.Click += new System.EventHandler(this.button_Pass_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дополнительные символы";
            // 
            // textBox_Spec_char
            // 
            this.textBox_Spec_char.Location = new System.Drawing.Point(9, 190);
            this.textBox_Spec_char.MaxLength = 10;
            this.textBox_Spec_char.Name = "textBox_Spec_char";
            this.textBox_Spec_char.Size = new System.Drawing.Size(365, 31);
            this.textBox_Spec_char.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество символов";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы",
            "Символы"});
            this.checkedListBox1.Location = new System.Drawing.Point(9, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(365, 144);
            this.checkedListBox1.TabIndex = 1;
            // 
            // numeric_Lenght_pass
            // 
            this.numeric_Lenght_pass.Location = new System.Drawing.Point(254, 237);
            this.numeric_Lenght_pass.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numeric_Lenght_pass.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Lenght_pass.Name = "numeric_Lenght_pass";
            this.numeric_Lenght_pass.Size = new System.Drawing.Size(120, 31);
            this.numeric_Lenght_pass.TabIndex = 0;
            this.numeric_Lenght_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_Lenght_pass.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Мои утилиты";
            this.Load += new System.EventHandler(this.ToolStripMenuItem_Load_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Counter.ResumeLayout(false);
            this.tabPage_Counter.PerformLayout();
            this.tabPage_Generator.ResumeLayout(false);
            this.tabPage_Generator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage_Notepad.ResumeLayout(false);
            this.tabPage_Pass.ResumeLayout(false);
            this.tabPage_Pass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Lenght_pass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_About;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Counter;
        private System.Windows.Forms.Label label_Counter;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Minus;
        private System.Windows.Forms.Button button_Plus;
        private System.Windows.Forms.TabPage tabPage_Generator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label_Random;
        private System.Windows.Forms.Button button_Random;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox_Random;
        private System.Windows.Forms.Button button_Random_clear;
        private System.Windows.Forms.Button button_Random_copy;
        private System.Windows.Forms.CheckBox checkBox_Random;
        private System.Windows.Forms.ToolStripMenuItem блокнотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Add_date;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Add_time;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Save;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Load;
        private System.Windows.Forms.TabPage tabPage_Notepad;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage_Pass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Spec_char;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.NumericUpDown numeric_Lenght_pass;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.Button button_Pass;
    }
}

