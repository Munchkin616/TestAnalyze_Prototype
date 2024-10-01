namespace TestAnalyze_Prototype
{
    partial class Testing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AnswerTB = new System.Windows.Forms.TextBox();
            this.AnswerCB3 = new System.Windows.Forms.CheckBox();
            this.AnswerCB2 = new System.Windows.Forms.CheckBox();
            this.AnswerCB1 = new System.Windows.Forms.CheckBox();
            this.TestBut = new System.Windows.Forms.Button();
            this.progTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AnswerTB);
            this.groupBox1.Controls.Add(this.AnswerCB3);
            this.groupBox1.Controls.Add(this.AnswerCB2);
            this.groupBox1.Controls.Add(this.AnswerCB1);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 343);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(742, 247);
            this.label2.TabIndex = 5;
            this.label2.Text = "Хочу понять таким же образом, будет ли это на несколько строк, потому что не хват" +
    "ает места, ибо задание на несколько строка и продолжается она или переносится";
            // 
            // AnswerTB
            // 
            this.AnswerTB.Location = new System.Drawing.Point(139, 276);
            this.AnswerTB.Name = "AnswerTB";
            this.AnswerTB.Size = new System.Drawing.Size(423, 26);
            this.AnswerTB.TabIndex = 3;
            // 
            // AnswerCB3
            // 
            this.AnswerCB3.AutoSize = true;
            this.AnswerCB3.Location = new System.Drawing.Point(502, 313);
            this.AnswerCB3.Name = "AnswerCB3";
            this.AnswerCB3.Size = new System.Drawing.Size(113, 24);
            this.AnswerCB3.TabIndex = 2;
            this.AnswerCB3.Text = "checkBox3";
            this.AnswerCB3.UseVisualStyleBackColor = true;
            this.AnswerCB3.CheckedChanged += new System.EventHandler(this.AnswerCB3_CheckedChanged);
            this.AnswerCB3.Click += new System.EventHandler(this.AnswerCB3_Click);
            // 
            // AnswerCB2
            // 
            this.AnswerCB2.AutoSize = true;
            this.AnswerCB2.Location = new System.Drawing.Point(243, 313);
            this.AnswerCB2.Name = "AnswerCB2";
            this.AnswerCB2.Size = new System.Drawing.Size(113, 24);
            this.AnswerCB2.TabIndex = 1;
            this.AnswerCB2.Text = "checkBox2";
            this.AnswerCB2.UseVisualStyleBackColor = true;
            this.AnswerCB2.CheckedChanged += new System.EventHandler(this.AnswerCB2_CheckedChanged);
            this.AnswerCB2.Click += new System.EventHandler(this.AnswerCB2_Click);
            // 
            // AnswerCB1
            // 
            this.AnswerCB1.AutoSize = true;
            this.AnswerCB1.Location = new System.Drawing.Point(16, 313);
            this.AnswerCB1.Name = "AnswerCB1";
            this.AnswerCB1.Size = new System.Drawing.Size(113, 24);
            this.AnswerCB1.TabIndex = 0;
            this.AnswerCB1.Text = "checkBox1";
            this.AnswerCB1.UseVisualStyleBackColor = true;
            this.AnswerCB1.CheckedChanged += new System.EventHandler(this.AnswerCB1_CheckedChanged);
            this.AnswerCB1.Click += new System.EventHandler(this.AnswerCB1_Click);
            // 
            // TestBut
            // 
            this.TestBut.Location = new System.Drawing.Point(283, 385);
            this.TestBut.Name = "TestBut";
            this.TestBut.Size = new System.Drawing.Size(170, 53);
            this.TestBut.TabIndex = 4;
            this.TestBut.Text = "Далее";
            this.TestBut.UseVisualStyleBackColor = true;
            this.TestBut.Click += new System.EventHandler(this.TestBut_Click);
            // 
            // progTimer
            // 
            this.progTimer.Enabled = true;
            this.progTimer.Interval = 1000;
            this.progTimer.Tick += new System.EventHandler(this.progTimer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(715, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // Testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TestBut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Testing";
            this.Text = "Testing";
            this.Load += new System.EventHandler(this.Testing_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button TestBut;
        private System.Windows.Forms.Timer progTimer;
        private System.Windows.Forms.TextBox AnswerTB;
        private System.Windows.Forms.CheckBox AnswerCB3;
        private System.Windows.Forms.CheckBox AnswerCB2;
        private System.Windows.Forms.CheckBox AnswerCB1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}