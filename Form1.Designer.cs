namespace Project1
{
    partial class Form1
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
            this.database1DataSet1 = new Project1.Database1DataSet1();
            this.лабработникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.лаб_работникиTableAdapter = new Project1.Database1DataSet1TableAdapters.Лаб_работникиTableAdapter();
            this.database1DataSet2 = new Project1.Database1DataSet2();
            this.реагентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.реагентыTableAdapter = new Project1.Database1DataSet2TableAdapters.РеагентыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.лабработникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.реагентыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // лабработникиBindingSource
            // 
            this.лабработникиBindingSource.DataMember = "Лаб_работники";
            this.лабработникиBindingSource.DataSource = this.database1DataSet1;
            // 
            // лаб_работникиTableAdapter
            // 
            this.лаб_работникиTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // реагентыBindingSource
            // 
            this.реагентыBindingSource.DataMember = "Реагенты";
            this.реагентыBindingSource.DataSource = this.database1DataSet2;
            // 
            // реагентыTableAdapter
            // 
            this.реагентыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить реагент";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Использовать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(335, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 49);
            this.button3.TabIndex = 3;
            this.button3.Text = "Открыть историю";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "второе окно";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.лабработникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.реагентыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource лабработникиBindingSource;
        private Database1DataSet1TableAdapters.Лаб_работникиTableAdapter лаб_работникиTableAdapter;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource реагентыBindingSource;
        private Database1DataSet2TableAdapters.РеагентыTableAdapter реагентыTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}