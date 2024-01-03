namespace P10_1_714220040.view
{
    partial class FormNilai
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
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbnpm = new System.Windows.Forms.ComboBox();
            this.tbnilai = new System.Windows.Forms.TextBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.cbkategori = new System.Windows.Forms.ComboBox();
            this.cbmatkul = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataNilai = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(140, 36);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(373, 29);
            this.tbCariData.TabIndex = 1;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnExport);
            this.groupBox4.Controls.Add(this.tbCariData);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(744, 415);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(535, 137);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Form Pencarian";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cari Data";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(22, 47);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(500, 36);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbnpm
            // 
            this.cbnpm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnpm.FormattingEnabled = true;
            this.cbnpm.Location = new System.Drawing.Point(114, 160);
            this.cbnpm.Name = "cbnpm";
            this.cbnpm.Size = new System.Drawing.Size(282, 32);
            this.cbnpm.TabIndex = 11;
            this.cbnpm.SelectedIndexChanged += new System.EventHandler(this.cbnpm_SelectedIndexChanged);
            // 
            // tbnilai
            // 
            this.tbnilai.Location = new System.Drawing.Point(114, 226);
            this.tbnilai.Name = "tbnilai";
            this.tbnilai.Size = new System.Drawing.Size(282, 29);
            this.tbnilai.TabIndex = 9;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(22, 246);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(500, 36);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(22, 181);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(500, 36);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(22, 116);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(500, 36);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHapus);
            this.groupBox3.Controls.Add(this.btnUbah);
            this.groupBox3.Controls.Add(this.btnSimpan);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Location = new System.Drawing.Point(744, 560);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(535, 291);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tombol Action";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nilai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "NPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbnama);
            this.groupBox2.Controls.Add(this.cbkategori);
            this.groupBox2.Controls.Add(this.cbmatkul);
            this.groupBox2.Controls.Add(this.cbnpm);
            this.groupBox2.Controls.Add(this.tbnilai);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(24, 420);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(703, 291);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Input Nilai";
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(415, 163);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(282, 29);
            this.tbnama.TabIndex = 14;
            // 
            // cbkategori
            // 
            this.cbkategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkategori.FormattingEnabled = true;
            this.cbkategori.Items.AddRange(new object[] {
            "UTS",
            "UAS"});
            this.cbkategori.Location = new System.Drawing.Point(114, 104);
            this.cbkategori.Name = "cbkategori";
            this.cbkategori.Size = new System.Drawing.Size(282, 32);
            this.cbkategori.TabIndex = 13;
            // 
            // cbmatkul
            // 
            this.cbmatkul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmatkul.FormattingEnabled = true;
            this.cbmatkul.Items.AddRange(new object[] {
            "Pemrograman I",
            "Pemrograman II",
            "Pemrograman III",
            "Pemrograman IV",
            "Literasi Data",
            "Sistem ERP",
            "RPL",
            "Metodologi Penelitian",
            "PKN",
            "General English I"});
            this.cbmatkul.Location = new System.Drawing.Point(114, 51);
            this.cbmatkul.Name = "cbmatkul";
            this.cbmatkul.Size = new System.Drawing.Size(282, 32);
            this.cbmatkul.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matkul";
            // 
            // DataNilai
            // 
            this.DataNilai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataNilai.Location = new System.Drawing.Point(0, 28);
            this.DataNilai.Name = "DataNilai";
            this.DataNilai.RowHeadersWidth = 72;
            this.DataNilai.RowTemplate.Height = 31;
            this.DataNilai.Size = new System.Drawing.Size(1255, 347);
            this.DataNilai.TabIndex = 0;
            this.DataNilai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataNilai_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataNilai);
            this.groupBox1.Location = new System.Drawing.Point(24, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1255, 375);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table Data Nilai";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExport.Location = new System.Drawing.Point(140, 82);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(373, 36);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FormNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 863);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNilai";
            this.Text = "FormNilai";
            this.Load += new System.EventHandler(this.FormNilai_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbnpm;
        private System.Windows.Forms.TextBox tbnilai;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataNilai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbkategori;
        private System.Windows.Forms.ComboBox cbmatkul;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.Button btnExport;
    }
}