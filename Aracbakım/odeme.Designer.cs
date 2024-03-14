namespace Aracbakım
{
    partial class odeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(odeme));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OtextBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OtextBox2 = new System.Windows.Forms.TextBox();
            this.OtextBox1 = new System.Windows.Forms.TextBox();
            this.OdataGridView1 = new System.Windows.Forms.DataGridView();
            this.ranAdSoyad1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ranTelefon1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odeme1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuOdemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aracBakımDBDataSet14 = new Aracbakım.AracBakımDBDataSet14();
            this.randevuOdemeTableAdapter = new Aracbakım.AracBakımDBDataSet14TableAdapters.RandevuOdemeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuOdemeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracBakımDBDataSet14)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(87, 430);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 43);
            this.button3.TabIndex = 6;
            this.button3.Text = "GERİ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(147, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = " SIFIRLA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(28, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "ÖDEME";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(327, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 37);
            this.label2.TabIndex = 74;
            this.label2.Text = "ARAÇ BAKIM UYGULAMASI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(443, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 27);
            this.label5.TabIndex = 73;
            this.label5.Text = "ÖDEME LİSTESİ";
            // 
            // OtextBox3
            // 
            this.OtextBox3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OtextBox3.Location = new System.Drawing.Point(27, 335);
            this.OtextBox3.Name = "OtextBox3";
            this.OtextBox3.Size = new System.Drawing.Size(209, 30);
            this.OtextBox3.TabIndex = 3;
            this.OtextBox3.TextChanged += new System.EventHandler(this.OtextBox3_TextChanged);
            this.OtextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OtextBox3_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(29, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 27);
            this.label4.TabIndex = 69;
            this.label4.Text = "Ödenecek Ücret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(29, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 27);
            this.label3.TabIndex = 68;
            this.label3.Text = "Ad ve Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(29, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 27);
            this.label1.TabIndex = 78;
            this.label1.Text = "Telefon Numarası";
            // 
            // OtextBox2
            // 
            this.OtextBox2.Enabled = false;
            this.OtextBox2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OtextBox2.Location = new System.Drawing.Point(27, 270);
            this.OtextBox2.Name = "OtextBox2";
            this.OtextBox2.Size = new System.Drawing.Size(210, 30);
            this.OtextBox2.TabIndex = 77;
            this.OtextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OtextBox2_KeyPress);
            // 
            // OtextBox1
            // 
            this.OtextBox1.Enabled = false;
            this.OtextBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OtextBox1.Location = new System.Drawing.Point(28, 193);
            this.OtextBox1.Name = "OtextBox1";
            this.OtextBox1.Size = new System.Drawing.Size(209, 30);
            this.OtextBox1.TabIndex = 2;
            // 
            // OdataGridView1
            // 
            this.OdataGridView1.AllowUserToAddRows = false;
            this.OdataGridView1.AutoGenerateColumns = false;
            this.OdataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ranAdSoyad1DataGridViewTextBoxColumn,
            this.ranTelefon1DataGridViewTextBoxColumn,
            this.tarih1DataGridViewTextBoxColumn,
            this.odeme1DataGridViewTextBoxColumn});
            this.OdataGridView1.DataSource = this.randevuOdemeBindingSource;
            this.OdataGridView1.Location = new System.Drawing.Point(265, 118);
            this.OdataGridView1.Name = "OdataGridView1";
            this.OdataGridView1.RowHeadersVisible = false;
            this.OdataGridView1.RowHeadersWidth = 51;
            this.OdataGridView1.RowTemplate.Height = 24;
            this.OdataGridView1.Size = new System.Drawing.Size(523, 306);
            this.OdataGridView1.TabIndex = 79;
            this.OdataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OdataGridView1_CellClick);
            // 
            // ranAdSoyad1DataGridViewTextBoxColumn
            // 
            this.ranAdSoyad1DataGridViewTextBoxColumn.DataPropertyName = "RanAdSoyad1";
            this.ranAdSoyad1DataGridViewTextBoxColumn.HeaderText = "RanAdSoyad1";
            this.ranAdSoyad1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ranAdSoyad1DataGridViewTextBoxColumn.Name = "ranAdSoyad1DataGridViewTextBoxColumn";
            // 
            // ranTelefon1DataGridViewTextBoxColumn
            // 
            this.ranTelefon1DataGridViewTextBoxColumn.DataPropertyName = "RanTelefon1";
            this.ranTelefon1DataGridViewTextBoxColumn.HeaderText = "RanTelefon1";
            this.ranTelefon1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ranTelefon1DataGridViewTextBoxColumn.Name = "ranTelefon1DataGridViewTextBoxColumn";
            // 
            // tarih1DataGridViewTextBoxColumn
            // 
            this.tarih1DataGridViewTextBoxColumn.DataPropertyName = "Tarih1";
            this.tarih1DataGridViewTextBoxColumn.HeaderText = "Tarih1";
            this.tarih1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarih1DataGridViewTextBoxColumn.Name = "tarih1DataGridViewTextBoxColumn";
            // 
            // odeme1DataGridViewTextBoxColumn
            // 
            this.odeme1DataGridViewTextBoxColumn.DataPropertyName = "Odeme1";
            this.odeme1DataGridViewTextBoxColumn.HeaderText = "Odeme1";
            this.odeme1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odeme1DataGridViewTextBoxColumn.Name = "odeme1DataGridViewTextBoxColumn";
            // 
            // randevuOdemeBindingSource
            // 
            this.randevuOdemeBindingSource.DataMember = "RandevuOdeme";
            this.randevuOdemeBindingSource.DataSource = this.aracBakımDBDataSet14;
            // 
            // aracBakımDBDataSet14
            // 
            this.aracBakımDBDataSet14.DataSetName = "AracBakımDBDataSet14";
            this.aracBakımDBDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // randevuOdemeTableAdapter
            // 
            this.randevuOdemeTableAdapter.ClearBeforeFill = true;
            // 
            // odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.OdataGridView1);
            this.Controls.Add(this.OtextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OtextBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OtextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "odeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme";
            this.Load += new System.EventHandler(this.odeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuOdemeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracBakımDBDataSet14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OtextBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OtextBox2;
        private System.Windows.Forms.TextBox OtextBox1;
        private System.Windows.Forms.DataGridView OdataGridView1;
        private AracBakımDBDataSet14 aracBakımDBDataSet14;
        private System.Windows.Forms.BindingSource randevuOdemeBindingSource;
        private AracBakımDBDataSet14TableAdapters.RandevuOdemeTableAdapter randevuOdemeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ranAdSoyad1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ranTelefon1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odeme1DataGridViewTextBoxColumn;
    }
}