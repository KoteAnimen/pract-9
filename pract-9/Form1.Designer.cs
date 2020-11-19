namespace pract_9
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
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablePeople = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GetAnswer = new System.Windows.Forms.Button();
            this.middleAge = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddPerson = new System.Windows.Forms.Button();
            this.nationality = new System.Windows.Forms.TextBox();
            this.placeBorn = new System.Windows.Forms.TextBox();
            this.yearBorn = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.genderFemale = new System.Windows.Forms.CheckBox();
            this.genderMale = new System.Windows.Forms.CheckBox();
            this.middleName = new System.Windows.Forms.TextBox();
            this.secondName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePeople)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearBorn)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(473, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // tablePeople
            // 
            this.tablePeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePeople.Location = new System.Drawing.Point(6, 6);
            this.tablePeople.Name = "tablePeople";
            this.tablePeople.Size = new System.Drawing.Size(436, 150);
            this.tablePeople.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(457, 280);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.tablePeople);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(449, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список людей";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GetAnswer);
            this.groupBox1.Controls.Add(this.middleAge);
            this.groupBox1.Location = new System.Drawing.Point(120, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 82);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Средний возраст людей в таблице";
            // 
            // GetAnswer
            // 
            this.GetAnswer.Location = new System.Drawing.Point(7, 46);
            this.GetAnswer.Name = "GetAnswer";
            this.GetAnswer.Size = new System.Drawing.Size(135, 23);
            this.GetAnswer.TabIndex = 1;
            this.GetAnswer.Text = "Получить ответ";
            this.GetAnswer.UseVisualStyleBackColor = true;
            this.GetAnswer.Click += new System.EventHandler(this.GetAnswer_Click);
            // 
            // middleAge
            // 
            this.middleAge.Location = new System.Drawing.Point(6, 19);
            this.middleAge.Name = "middleAge";
            this.middleAge.Size = new System.Drawing.Size(136, 20);
            this.middleAge.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(449, 254);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить человека в список";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.AddPerson);
            this.groupBox2.Controls.Add(this.nationality);
            this.groupBox2.Controls.Add(this.placeBorn);
            this.groupBox2.Controls.Add(this.yearBorn);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.middleName);
            this.groupBox2.Controls.Add(this.secondName);
            this.groupBox2.Controls.Add(this.firstName);
            this.groupBox2.Location = new System.Drawing.Point(79, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 241);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавить человека в таблицу";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Национальность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Место рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Год рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Имя";
            // 
            // AddPerson
            // 
            this.AddPerson.Location = new System.Drawing.Point(150, 175);
            this.AddPerson.Name = "AddPerson";
            this.AddPerson.Size = new System.Drawing.Size(132, 41);
            this.AddPerson.TabIndex = 7;
            this.AddPerson.Text = "Добавить человека в таблицу";
            this.AddPerson.UseVisualStyleBackColor = true;
            this.AddPerson.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // nationality
            // 
            this.nationality.Location = new System.Drawing.Point(150, 129);
            this.nationality.Name = "nationality";
            this.nationality.Size = new System.Drawing.Size(132, 20);
            this.nationality.TabIndex = 6;
            // 
            // placeBorn
            // 
            this.placeBorn.Location = new System.Drawing.Point(150, 83);
            this.placeBorn.Name = "placeBorn";
            this.placeBorn.Size = new System.Drawing.Size(132, 20);
            this.placeBorn.TabIndex = 5;
            // 
            // yearBorn
            // 
            this.yearBorn.Location = new System.Drawing.Point(150, 40);
            this.yearBorn.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.yearBorn.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.yearBorn.Name = "yearBorn";
            this.yearBorn.Size = new System.Drawing.Size(132, 20);
            this.yearBorn.TabIndex = 4;
            this.yearBorn.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.genderFemale);
            this.groupBox3.Controls.Add(this.genderMale);
            this.groupBox3.Location = new System.Drawing.Point(7, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(129, 69);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Пол";
            // 
            // genderFemale
            // 
            this.genderFemale.AutoSize = true;
            this.genderFemale.Location = new System.Drawing.Point(7, 44);
            this.genderFemale.Name = "genderFemale";
            this.genderFemale.Size = new System.Drawing.Size(73, 17);
            this.genderFemale.TabIndex = 1;
            this.genderFemale.Text = "Женский";
            this.genderFemale.UseVisualStyleBackColor = true;
            // 
            // genderMale
            // 
            this.genderMale.AutoSize = true;
            this.genderMale.Location = new System.Drawing.Point(7, 20);
            this.genderMale.Name = "genderMale";
            this.genderMale.Size = new System.Drawing.Size(72, 17);
            this.genderMale.TabIndex = 0;
            this.genderMale.Text = "Мужской";
            this.genderMale.UseVisualStyleBackColor = true;
            // 
            // middleName
            // 
            this.middleName.Location = new System.Drawing.Point(7, 129);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(100, 20);
            this.middleName.TabIndex = 2;
            // 
            // secondName
            // 
            this.secondName.Location = new System.Drawing.Point(7, 84);
            this.secondName.Name = "secondName";
            this.secondName.Size = new System.Drawing.Size(100, 20);
            this.secondName.TabIndex = 1;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(7, 40);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 20);
            this.firstName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 314);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практическая №9";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePeople)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearBorn)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridView tablePeople;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button GetAnswer;
        private System.Windows.Forms.TextBox middleAge;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddPerson;
        private System.Windows.Forms.TextBox nationality;
        private System.Windows.Forms.TextBox placeBorn;
        private System.Windows.Forms.NumericUpDown yearBorn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox genderFemale;
        private System.Windows.Forms.CheckBox genderMale;
        private System.Windows.Forms.TextBox middleName;
        private System.Windows.Forms.TextBox secondName;
        private System.Windows.Forms.TextBox firstName;
    }
}

