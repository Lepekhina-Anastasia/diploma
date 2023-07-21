namespace Project1
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameFe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.REF = new System.Windows.Forms.TextBox();
            this.LOT = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.TextBox();
            this.Pose = new System.Windows.Forms.TextBox();
            this.Samples = new System.Windows.Forms.TextBox();
            this.Packing = new System.Windows.Forms.TextBox();
            this.Позиция = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNA = new System.Windows.Forms.TextBox();
            this.Login4 = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск";
            // 
            // NameFe
            // 
            this.NameFe.Location = new System.Drawing.Point(89, 33);
            this.NameFe.Name = "NameFe";
            this.NameFe.Size = new System.Drawing.Size(255, 22);
            this.NameFe.TabIndex = 1;
            this.NameFe.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 493);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(908, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Использовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // REF
            // 
            this.REF.Location = new System.Drawing.Point(354, 105);
            this.REF.Name = "REF";
            this.REF.Size = new System.Drawing.Size(156, 22);
            this.REF.TabIndex = 6;
            // 
            // LOT
            // 
            this.LOT.Location = new System.Drawing.Point(186, 105);
            this.LOT.Name = "LOT";
            this.LOT.Size = new System.Drawing.Size(137, 22);
            this.LOT.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "LOT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "REF";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Годен до:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(532, 105);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(141, 22);
            this.Date.TabIndex = 13;
            // 
            // Pose
            // 
            this.Pose.Location = new System.Drawing.Point(712, 105);
            this.Pose.Name = "Pose";
            this.Pose.Size = new System.Drawing.Size(82, 22);
            this.Pose.TabIndex = 14;
            // 
            // Samples
            // 
            this.Samples.Location = new System.Drawing.Point(851, 105);
            this.Samples.Name = "Samples";
            this.Samples.Size = new System.Drawing.Size(100, 22);
            this.Samples.TabIndex = 15;
            // 
            // Packing
            // 
            this.Packing.Location = new System.Drawing.Point(991, 104);
            this.Packing.Name = "Packing";
            this.Packing.Size = new System.Drawing.Size(50, 22);
            this.Packing.TabIndex = 16;
            this.Packing.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Позиция
            // 
            this.Позиция.AutoSize = true;
            this.Позиция.Location = new System.Drawing.Point(709, 83);
            this.Позиция.Name = "Позиция";
            this.Позиция.Size = new System.Drawing.Size(64, 16);
            this.Позиция.TabIndex = 17;
            this.Позиция.Text = "Позиция";
            this.Позиция.Click += new System.EventHandler(this.Позиция_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(848, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Количество проб";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(988, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Фасовка";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 265);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(369, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 45);
            this.button3.TabIndex = 21;
            this.button3.Text = "Сканировать код";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(369, 423);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 46);
            this.button4.TabIndex = 22;
            this.button4.Text = "Распознать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Наименование";
            // 
            // textBoxNA
            // 
            this.textBoxNA.Location = new System.Drawing.Point(21, 105);
            this.textBoxNA.Name = "textBoxNA";
            this.textBoxNA.Size = new System.Drawing.Size(148, 22);
            this.textBoxNA.TabIndex = 24;
            // 
            // Login4
            // 
            this.Login4.Location = new System.Drawing.Point(29, 528);
            this.Login4.Name = "Login4";
            this.Login4.Size = new System.Drawing.Size(100, 22);
            this.Login4.TabIndex = 25;
            this.Login4.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(186, 527);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(100, 22);
            this.Surname.TabIndex = 26;
            this.Surname.TextChanged += new System.EventHandler(this.Surname_TextChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 576);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Login4);
            this.Controls.Add(this.textBoxNA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Позиция);
            this.Controls.Add(this.Packing);
            this.Controls.Add(this.Samples);
            this.Controls.Add(this.Pose);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LOT);
            this.Controls.Add(this.REF);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameFe);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Использовать";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameFe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox REF;
        private System.Windows.Forms.TextBox LOT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.TextBox Pose;
        private System.Windows.Forms.TextBox Samples;
        private System.Windows.Forms.TextBox Packing;
        private System.Windows.Forms.Label Позиция;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNA;
        public System.Windows.Forms.TextBox Login4;
        private System.Windows.Forms.TextBox Surname;
    }
}