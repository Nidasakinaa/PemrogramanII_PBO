namespace P7_1_714220040_1_
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
            this.lblNama = new System.Windows.Forms.Label();
            this.lblProdi = new System.Windows.Forms.Label();
            this.lblKelas = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbProdi = new System.Windows.Forms.TextBox();
            this.tbKelas = new System.Windows.Forms.TextBox();
            this.btnCek = new System.Windows.Forms.Button();
            this.btnTutupForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rbMinggu = new System.Windows.Forms.RadioButton();
            this.rbSenin = new System.Windows.Forms.RadioButton();
            this.cbKuliah = new System.Windows.Forms.CheckBox();
            this.cbTravelling = new System.Windows.Forms.CheckBox();
            this.cbTidur = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(39, 66);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(64, 25);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama";
            // 
            // lblProdi
            // 
            this.lblProdi.AutoSize = true;
            this.lblProdi.Location = new System.Drawing.Point(39, 126);
            this.lblProdi.Name = "lblProdi";
            this.lblProdi.Size = new System.Drawing.Size(57, 25);
            this.lblProdi.TabIndex = 1;
            this.lblProdi.Text = "Prodi";
            // 
            // lblKelas
            // 
            this.lblKelas.AutoSize = true;
            this.lblKelas.Location = new System.Drawing.Point(39, 180);
            this.lblKelas.Name = "lblKelas";
            this.lblKelas.Size = new System.Drawing.Size(62, 25);
            this.lblKelas.TabIndex = 2;
            this.lblKelas.Text = "Kelas";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(224, 66);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(334, 29);
            this.tbNama.TabIndex = 3;
            // 
            // tbProdi
            // 
            this.tbProdi.Location = new System.Drawing.Point(224, 122);
            this.tbProdi.Name = "tbProdi";
            this.tbProdi.Size = new System.Drawing.Size(334, 29);
            this.tbProdi.TabIndex = 4;
            // 
            // tbKelas
            // 
            this.tbKelas.Location = new System.Drawing.Point(224, 180);
            this.tbKelas.Name = "tbKelas";
            this.tbKelas.Size = new System.Drawing.Size(334, 29);
            this.tbKelas.TabIndex = 5;
            // 
            // btnCek
            // 
            this.btnCek.Location = new System.Drawing.Point(224, 243);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(134, 48);
            this.btnCek.TabIndex = 6;
            this.btnCek.Text = "Cek";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // btnTutupForm
            // 
            this.btnTutupForm.Location = new System.Drawing.Point(418, 243);
            this.btnTutupForm.Name = "btnTutupForm";
            this.btnTutupForm.Size = new System.Drawing.Size(140, 48);
            this.btnTutupForm.TabIndex = 7;
            this.btnTutupForm.Text = "Tutup Form";
            this.btnTutupForm.UseVisualStyleBackColor = true;
            this.btnTutupForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(287, 312);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(203, 29);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "LIST KEGIATAN";
            // 
            // rbMinggu
            // 
            this.rbMinggu.AutoSize = true;
            this.rbMinggu.Location = new System.Drawing.Point(44, 363);
            this.rbMinggu.Name = "rbMinggu";
            this.rbMinggu.Size = new System.Drawing.Size(102, 29);
            this.rbMinggu.TabIndex = 9;
            this.rbMinggu.TabStop = true;
            this.rbMinggu.Text = "Minggu";
            this.rbMinggu.UseVisualStyleBackColor = true;
            this.rbMinggu.CheckedChanged += new System.EventHandler(this.rbMinggu_CheckedChanged);
            // 
            // rbSenin
            // 
            this.rbSenin.AutoSize = true;
            this.rbSenin.Location = new System.Drawing.Point(44, 403);
            this.rbSenin.Name = "rbSenin";
            this.rbSenin.Size = new System.Drawing.Size(88, 29);
            this.rbSenin.TabIndex = 10;
            this.rbSenin.TabStop = true;
            this.rbSenin.Text = "Senin";
            this.rbSenin.UseVisualStyleBackColor = true;
            this.rbSenin.CheckedChanged += new System.EventHandler(this.rbSenin_CheckedChanged);
            // 
            // cbKuliah
            // 
            this.cbKuliah.AutoSize = true;
            this.cbKuliah.Location = new System.Drawing.Point(44, 461);
            this.cbKuliah.Name = "cbKuliah";
            this.cbKuliah.Size = new System.Drawing.Size(93, 29);
            this.cbKuliah.TabIndex = 11;
            this.cbKuliah.Text = "Kuliah";
            this.cbKuliah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbKuliah.UseVisualStyleBackColor = true;
            // 
            // cbTravelling
            // 
            this.cbTravelling.AutoSize = true;
            this.cbTravelling.Location = new System.Drawing.Point(44, 505);
            this.cbTravelling.Name = "cbTravelling";
            this.cbTravelling.Size = new System.Drawing.Size(123, 29);
            this.cbTravelling.TabIndex = 12;
            this.cbTravelling.Text = "Travelling";
            this.cbTravelling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbTravelling.UseVisualStyleBackColor = true;
            // 
            // cbTidur
            // 
            this.cbTidur.AutoSize = true;
            this.cbTidur.Location = new System.Drawing.Point(44, 549);
            this.cbTidur.Name = "cbTidur";
            this.cbTidur.Size = new System.Drawing.Size(83, 29);
            this.cbTidur.TabIndex = 13;
            this.cbTidur.Text = "Tidur";
            this.cbTidur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbTidur.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(224, 549);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(134, 48);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(424, 549);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(134, 48);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 650);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cbTidur);
            this.Controls.Add(this.cbTravelling);
            this.Controls.Add(this.cbKuliah);
            this.Controls.Add(this.rbSenin);
            this.Controls.Add(this.rbMinggu);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnTutupForm);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.tbKelas);
            this.Controls.Add(this.tbProdi);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.lblKelas);
            this.Controls.Add(this.lblProdi);
            this.Controls.Add(this.lblNama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblProdi;
        private System.Windows.Forms.Label lblKelas;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbProdi;
        private System.Windows.Forms.TextBox tbKelas;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.Button btnTutupForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rbMinggu;
        private System.Windows.Forms.RadioButton rbSenin;
        private System.Windows.Forms.CheckBox cbKuliah;
        private System.Windows.Forms.CheckBox cbTravelling;
        private System.Windows.Forms.CheckBox cbTidur;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnReset;
    }
}

