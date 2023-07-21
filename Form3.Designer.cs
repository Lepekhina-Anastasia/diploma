namespace Project1
{
    partial class Form3
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hlamidiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Packingfield = new System.Windows.Forms.ComboBox();
            this.REFfield = new System.Windows.Forms.TextBox();
            this.Namefield = new System.Windows.Forms.TextBox();
            this.LOTfield = new System.Windows.Forms.TextBox();
            this.Positionfield = new System.Windows.Forms.TextBox();
            this.Expiration_datefield = new System.Windows.Forms.TextBox();
            this.Samples_quantityfield = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Login3 = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hlamidiaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 28);
            // 
            // hlamidiaToolStripMenuItem
            // 
            this.hlamidiaToolStripMenuItem.Name = "hlamidiaToolStripMenuItem";
            this.hlamidiaToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.hlamidiaToolStripMenuItem.Text = "Hlamidia";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(746, 474);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(103, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ввведите данные реагента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "REF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Название реагента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "LOT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Позиция";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Срок годности";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Количество проб";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Фасовка";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Packingfield
            // 
            this.Packingfield.FormattingEnabled = true;
            this.Packingfield.Items.AddRange(new object[] {
            "U",
            "S",
            "A"});
            this.Packingfield.Location = new System.Drawing.Point(207, 299);
            this.Packingfield.Name = "Packingfield";
            this.Packingfield.Size = new System.Drawing.Size(181, 24);
            this.Packingfield.TabIndex = 10;
            this.Packingfield.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // REFfield
            // 
            this.REFfield.Location = new System.Drawing.Point(207, 82);
            this.REFfield.Name = "REFfield";
            this.REFfield.Size = new System.Drawing.Size(181, 22);
            this.REFfield.TabIndex = 11;
            this.REFfield.TextChanged += new System.EventHandler(this.REFfield_TextChanged);
            this.REFfield.Enter += new System.EventHandler(this.REFfield_Enter);
            this.REFfield.Leave += new System.EventHandler(this.REFfield_Leave);
            // 
            // Namefield
            // 
            this.Namefield.Location = new System.Drawing.Point(207, 115);
            this.Namefield.Name = "Namefield";
            this.Namefield.Size = new System.Drawing.Size(181, 22);
            this.Namefield.TabIndex = 12;
            this.Namefield.Enter += new System.EventHandler(this.Namefield_Enter);
            this.Namefield.Leave += new System.EventHandler(this.Namefield_Leave);
            // 
            // LOTfield
            // 
            this.LOTfield.Location = new System.Drawing.Point(207, 151);
            this.LOTfield.Name = "LOTfield";
            this.LOTfield.Size = new System.Drawing.Size(181, 22);
            this.LOTfield.TabIndex = 13;
            this.LOTfield.Enter += new System.EventHandler(this.LOTfield_Enter);
            this.LOTfield.Leave += new System.EventHandler(this.LOTfield_Leave);
            // 
            // Positionfield
            // 
            this.Positionfield.Location = new System.Drawing.Point(207, 185);
            this.Positionfield.Name = "Positionfield";
            this.Positionfield.Size = new System.Drawing.Size(181, 22);
            this.Positionfield.TabIndex = 14;
            this.Positionfield.Enter += new System.EventHandler(this.Positionfield_Enter);
            this.Positionfield.Leave += new System.EventHandler(this.Positionfield_Leave);
            // 
            // Expiration_datefield
            // 
            this.Expiration_datefield.Location = new System.Drawing.Point(207, 222);
            this.Expiration_datefield.Name = "Expiration_datefield";
            this.Expiration_datefield.Size = new System.Drawing.Size(181, 22);
            this.Expiration_datefield.TabIndex = 15;
            this.Expiration_datefield.Enter += new System.EventHandler(this.Expiration_datefield_Enter);
            this.Expiration_datefield.Leave += new System.EventHandler(this.Expiration_datefield_Leave);
            // 
            // Samples_quantityfield
            // 
            this.Samples_quantityfield.Location = new System.Drawing.Point(207, 260);
            this.Samples_quantityfield.Name = "Samples_quantityfield";
            this.Samples_quantityfield.Size = new System.Drawing.Size(181, 22);
            this.Samples_quantityfield.TabIndex = 16;
            this.Samples_quantityfield.TextChanged += new System.EventHandler(this.Samples_Quantityfield_TextChanged);
            this.Samples_quantityfield.Enter += new System.EventHandler(this.Samples_quantityfield_Enter);
            this.Samples_quantityfield.Leave += new System.EventHandler(this.Samples_quantityfield_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Создать код";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(566, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 220);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Login3
            // 
            this.Login3.Location = new System.Drawing.Point(13, 475);
            this.Login3.Name = "Login3";
            this.Login3.Size = new System.Drawing.Size(100, 22);
            this.Login3.TabIndex = 19;
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(169, 475);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(100, 22);
            this.Surname.TabIndex = 20;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 509);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Login3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Samples_quantityfield);
            this.Controls.Add(this.Expiration_datefield);
            this.Controls.Add(this.Positionfield);
            this.Controls.Add(this.LOTfield);
            this.Controls.Add(this.Namefield);
            this.Controls.Add(this.REFfield);
            this.Controls.Add(this.Packingfield);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Name = "Form3";
            this.Text = "Добавление реагента";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hlamidiaToolStripMenuItem;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Packingfield;
        private System.Windows.Forms.TextBox REFfield;
        private System.Windows.Forms.TextBox Namefield;
        private System.Windows.Forms.TextBox LOTfield;
        private System.Windows.Forms.TextBox Positionfield;
        private System.Windows.Forms.TextBox Expiration_datefield;
        private System.Windows.Forms.TextBox Samples_quantityfield;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox Login3;
        private System.Windows.Forms.TextBox Surname;
    }
}