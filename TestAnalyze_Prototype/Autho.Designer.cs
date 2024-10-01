namespace TestAnalyze_Prototype
{
    partial class Autho
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AgeNum = new System.Windows.Forms.NumericUpDown();
            this.DadnameTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.SurnameTB = new System.Windows.Forms.TextBox();
            this.AgeLal = new System.Windows.Forms.Label();
            this.DadnameLal = new System.Windows.Forms.Label();
            this.NameLal = new System.Windows.Forms.Label();
            this.SurnameLal = new System.Windows.Forms.Label();
            this.StartBut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNum)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AgeNum);
            this.groupBox1.Controls.Add(this.DadnameTB);
            this.groupBox1.Controls.Add(this.NameTB);
            this.groupBox1.Controls.Add(this.SurnameTB);
            this.groupBox1.Controls.Add(this.AgeLal);
            this.groupBox1.Controls.Add(this.DadnameLal);
            this.groupBox1.Controls.Add(this.NameLal);
            this.groupBox1.Controls.Add(this.SurnameLal);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные";
            // 
            // AgeNum
            // 
            this.AgeNum.Location = new System.Drawing.Point(94, 122);
            this.AgeNum.Maximum = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.AgeNum.Minimum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.AgeNum.Name = "AgeNum";
            this.AgeNum.Size = new System.Drawing.Size(59, 26);
            this.AgeNum.TabIndex = 7;
            this.AgeNum.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // DadnameTB
            // 
            this.DadnameTB.Location = new System.Drawing.Point(94, 90);
            this.DadnameTB.Name = "DadnameTB";
            this.DadnameTB.Size = new System.Drawing.Size(264, 26);
            this.DadnameTB.TabIndex = 6;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(94, 58);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(264, 26);
            this.NameTB.TabIndex = 5;
            // 
            // SurnameTB
            // 
            this.SurnameTB.Location = new System.Drawing.Point(94, 26);
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(264, 26);
            this.SurnameTB.TabIndex = 4;
            // 
            // AgeLal
            // 
            this.AgeLal.AutoSize = true;
            this.AgeLal.Location = new System.Drawing.Point(12, 124);
            this.AgeLal.Name = "AgeLal";
            this.AgeLal.Size = new System.Drawing.Size(76, 20);
            this.AgeLal.TabIndex = 3;
            this.AgeLal.Text = "Возраст:";
            // 
            // DadnameLal
            // 
            this.DadnameLal.AutoSize = true;
            this.DadnameLal.Location = new System.Drawing.Point(8, 93);
            this.DadnameLal.Name = "DadnameLal";
            this.DadnameLal.Size = new System.Drawing.Size(87, 20);
            this.DadnameLal.TabIndex = 2;
            this.DadnameLal.Text = "Отчество:";
            // 
            // NameLal
            // 
            this.NameLal.AutoSize = true;
            this.NameLal.Location = new System.Drawing.Point(8, 61);
            this.NameLal.Name = "NameLal";
            this.NameLal.Size = new System.Drawing.Size(44, 20);
            this.NameLal.TabIndex = 1;
            this.NameLal.Text = "Имя:";
            // 
            // SurnameLal
            // 
            this.SurnameLal.AutoSize = true;
            this.SurnameLal.Location = new System.Drawing.Point(7, 29);
            this.SurnameLal.Name = "SurnameLal";
            this.SurnameLal.Size = new System.Drawing.Size(85, 20);
            this.SurnameLal.TabIndex = 0;
            this.SurnameLal.Text = "Фамилия:";
            // 
            // StartBut
            // 
            this.StartBut.Location = new System.Drawing.Point(94, 177);
            this.StartBut.Name = "StartBut";
            this.StartBut.Size = new System.Drawing.Size(203, 47);
            this.StartBut.TabIndex = 1;
            this.StartBut.Text = "Начать тестирование";
            this.StartBut.UseVisualStyleBackColor = true;
            this.StartBut.Click += new System.EventHandler(this.StartBut_Click);
            // 
            // Autho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 244);
            this.Controls.Add(this.StartBut);
            this.Controls.Add(this.groupBox1);
            this.Name = "Autho";
            this.Text = "Авторизация";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown AgeNum;
        private System.Windows.Forms.TextBox DadnameTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox SurnameTB;
        private System.Windows.Forms.Label AgeLal;
        private System.Windows.Forms.Label DadnameLal;
        private System.Windows.Forms.Label NameLal;
        private System.Windows.Forms.Label SurnameLal;
        private System.Windows.Forms.Button StartBut;
    }
}

