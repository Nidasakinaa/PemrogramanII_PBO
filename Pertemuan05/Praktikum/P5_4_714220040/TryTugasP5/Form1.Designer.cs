namespace P5_4_714220040
{
    partial class FormAstraMusicSchool
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
            this.lblName = new System.Windows.Forms.Label();
            this.LabelJK = new System.Windows.Forms.Label();
            this.labelTL = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.CBJK = new System.Windows.Forms.ComboBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GBPK = new System.Windows.Forms.GroupBox();
            this.CBKomposer = new System.Windows.Forms.CheckBox();
            this.CBVokal = new System.Windows.Forms.CheckBox();
            this.CBDrum = new System.Windows.Forms.CheckBox();
            this.CBPiano = new System.Windows.Forms.CheckBox();
            this.CBKonduktor = new System.Windows.Forms.CheckBox();
            this.CBSaxophone = new System.Windows.Forms.CheckBox();
            this.CBGitar = new System.Windows.Forms.CheckBox();
            this.CBBiola = new System.Windows.Forms.CheckBox();
            this.groupBoxPJ = new System.Windows.Forms.GroupBox();
            this.RB4 = new System.Windows.Forms.RadioButton();
            this.RB3 = new System.Windows.Forms.RadioButton();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GBPK.SuspendLayout();
            this.groupBoxPJ.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(236, 83);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nama";
            // 
            // LabelJK
            // 
            this.LabelJK.AutoSize = true;
            this.LabelJK.Location = new System.Drawing.Point(233, 135);
            this.LabelJK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelJK.Name = "LabelJK";
            this.LabelJK.Size = new System.Drawing.Size(135, 25);
            this.LabelJK.TabIndex = 1;
            this.LabelJK.Text = "Jenis Kelamin";
            // 
            // labelTL
            // 
            this.labelTL.AutoSize = true;
            this.labelTL.Location = new System.Drawing.Point(233, 190);
            this.labelTL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTL.Name = "labelTL";
            this.labelTL.Size = new System.Drawing.Size(132, 25);
            this.labelTL.TabIndex = 2;
            this.labelTL.Text = "Tanggal Lahir";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(416, 83);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(321, 29);
            this.textBoxName.TabIndex = 3;
            // 
            // CBJK
            // 
            this.CBJK.FormattingEnabled = true;
            this.CBJK.Items.AddRange(new object[] {
            "Perempuan",
            "Laki-laki"});
            this.CBJK.Location = new System.Drawing.Point(416, 131);
            this.CBJK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBJK.Name = "CBJK";
            this.CBJK.Size = new System.Drawing.Size(218, 32);
            this.CBJK.TabIndex = 4;
            this.CBJK.Text = "--Pilih Jenis Kelamin--";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(416, 185);
            this.DateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(321, 29);
            this.DateTimePicker.TabIndex = 5;
            // 
            // GBPK
            // 
            this.GBPK.Controls.Add(this.CBKomposer);
            this.GBPK.Controls.Add(this.CBVokal);
            this.GBPK.Controls.Add(this.CBDrum);
            this.GBPK.Controls.Add(this.CBPiano);
            this.GBPK.Controls.Add(this.CBKonduktor);
            this.GBPK.Controls.Add(this.CBSaxophone);
            this.GBPK.Controls.Add(this.CBGitar);
            this.GBPK.Controls.Add(this.CBBiola);
            this.GBPK.Location = new System.Drawing.Point(48, 244);
            this.GBPK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBPK.Name = "GBPK";
            this.GBPK.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBPK.Size = new System.Drawing.Size(350, 249);
            this.GBPK.TabIndex = 6;
            this.GBPK.TabStop = false;
            this.GBPK.Text = "Pilihan Kelas";
            // 
            // CBKomposer
            // 
            this.CBKomposer.AutoSize = true;
            this.CBKomposer.Location = new System.Drawing.Point(169, 199);
            this.CBKomposer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBKomposer.Name = "CBKomposer";
            this.CBKomposer.Size = new System.Drawing.Size(128, 29);
            this.CBKomposer.TabIndex = 8;
            this.CBKomposer.Text = "Komposer";
            this.CBKomposer.UseVisualStyleBackColor = true;
            // 
            // CBVokal
            // 
            this.CBVokal.AutoSize = true;
            this.CBVokal.Location = new System.Drawing.Point(169, 148);
            this.CBVokal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBVokal.Name = "CBVokal";
            this.CBVokal.Size = new System.Drawing.Size(88, 29);
            this.CBVokal.TabIndex = 6;
            this.CBVokal.Text = "Vokal";
            this.CBVokal.UseVisualStyleBackColor = true;
            // 
            // CBDrum
            // 
            this.CBDrum.AutoSize = true;
            this.CBDrum.Location = new System.Drawing.Point(169, 98);
            this.CBDrum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBDrum.Name = "CBDrum";
            this.CBDrum.Size = new System.Drawing.Size(85, 29);
            this.CBDrum.TabIndex = 5;
            this.CBDrum.Text = "Drum";
            this.CBDrum.UseVisualStyleBackColor = true;
            // 
            // CBPiano
            // 
            this.CBPiano.AutoSize = true;
            this.CBPiano.Location = new System.Drawing.Point(169, 41);
            this.CBPiano.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBPiano.Name = "CBPiano";
            this.CBPiano.Size = new System.Drawing.Size(88, 29);
            this.CBPiano.TabIndex = 4;
            this.CBPiano.Text = "Piano";
            this.CBPiano.UseVisualStyleBackColor = true;
            // 
            // CBKonduktor
            // 
            this.CBKonduktor.AutoSize = true;
            this.CBKonduktor.Location = new System.Drawing.Point(16, 199);
            this.CBKonduktor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBKonduktor.Name = "CBKonduktor";
            this.CBKonduktor.Size = new System.Drawing.Size(128, 29);
            this.CBKonduktor.TabIndex = 3;
            this.CBKonduktor.Text = "Konduktor";
            this.CBKonduktor.UseVisualStyleBackColor = true;
            // 
            // CBSaxophone
            // 
            this.CBSaxophone.AutoSize = true;
            this.CBSaxophone.Location = new System.Drawing.Point(16, 148);
            this.CBSaxophone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBSaxophone.Name = "CBSaxophone";
            this.CBSaxophone.Size = new System.Drawing.Size(139, 29);
            this.CBSaxophone.TabIndex = 2;
            this.CBSaxophone.Text = "Saxophone";
            this.CBSaxophone.UseVisualStyleBackColor = true;
            // 
            // CBGitar
            // 
            this.CBGitar.AutoSize = true;
            this.CBGitar.Location = new System.Drawing.Point(16, 98);
            this.CBGitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBGitar.Name = "CBGitar";
            this.CBGitar.Size = new System.Drawing.Size(79, 29);
            this.CBGitar.TabIndex = 1;
            this.CBGitar.Text = "Gitar";
            this.CBGitar.UseVisualStyleBackColor = true;
            // 
            // CBBiola
            // 
            this.CBBiola.AutoSize = true;
            this.CBBiola.Location = new System.Drawing.Point(16, 39);
            this.CBBiola.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBBiola.Name = "CBBiola";
            this.CBBiola.Size = new System.Drawing.Size(81, 29);
            this.CBBiola.TabIndex = 0;
            this.CBBiola.Text = "Biola";
            this.CBBiola.UseVisualStyleBackColor = true;
            // 
            // groupBoxPJ
            // 
            this.groupBoxPJ.Controls.Add(this.RB4);
            this.groupBoxPJ.Controls.Add(this.RB3);
            this.groupBoxPJ.Controls.Add(this.RB2);
            this.groupBoxPJ.Controls.Add(this.RB1);
            this.groupBoxPJ.Location = new System.Drawing.Point(462, 244);
            this.groupBoxPJ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxPJ.Name = "groupBoxPJ";
            this.groupBoxPJ.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxPJ.Size = new System.Drawing.Size(363, 249);
            this.groupBoxPJ.TabIndex = 7;
            this.groupBoxPJ.TabStop = false;
            this.groupBoxPJ.Text = "Pilihan Jadwal";
            // 
            // RB4
            // 
            this.RB4.AutoSize = true;
            this.RB4.Location = new System.Drawing.Point(24, 177);
            this.RB4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RB4.Name = "RB4";
            this.RB4.Size = new System.Drawing.Size(227, 29);
            this.RB4.TabIndex = 8;
            this.RB4.TabStop = true;
            this.RB4.Text = "Minggu, 13.00 - 17.00";
            this.RB4.UseVisualStyleBackColor = true;
            // 
            // RB3
            // 
            this.RB3.AutoSize = true;
            this.RB3.Location = new System.Drawing.Point(24, 133);
            this.RB3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RB3.Name = "RB3";
            this.RB3.Size = new System.Drawing.Size(289, 29);
            this.RB3.TabIndex = 2;
            this.RB3.TabStop = true;
            this.RB3.Text = "Sabtu & Minggu, 09.00 - 11.00";
            this.RB3.UseVisualStyleBackColor = true;
            // 
            // RB2
            // 
            this.RB2.AutoSize = true;
            this.RB2.Location = new System.Drawing.Point(24, 85);
            this.RB2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RB2.Name = "RB2";
            this.RB2.Size = new System.Drawing.Size(278, 29);
            this.RB2.TabIndex = 1;
            this.RB2.TabStop = true;
            this.RB2.Text = "Selasa & Kamis, 14.00-16.00";
            this.RB2.UseVisualStyleBackColor = true;
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.Location = new System.Drawing.Point(24, 39);
            this.RB1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(269, 29);
            this.RB1.TabIndex = 0;
            this.RB1.TabStop = true;
            this.RB1.Text = "Senin & Rabu, 14.00 - 16.00";
            this.RB1.UseVisualStyleBackColor = true;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(280, 539);
            this.btnTampilkan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(117, 48);
            this.btnTampilkan.TabIndex = 8;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(462, 539);
            this.btnSelesai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(104, 48);
            this.btnSelesai.TabIndex = 9;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(321, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "FORM PENDAFTARAN";
            // 
            // FormAstraMusicSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(874, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.groupBoxPJ);
            this.Controls.Add(this.GBPK);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.CBJK);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelTL);
            this.Controls.Add(this.LabelJK);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAstraMusicSchool";
            this.Text = " ";
            this.GBPK.ResumeLayout(false);
            this.GBPK.PerformLayout();
            this.groupBoxPJ.ResumeLayout(false);
            this.groupBoxPJ.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label LabelJK;
        private System.Windows.Forms.Label labelTL;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox CBJK;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.GroupBox GBPK;
        private System.Windows.Forms.GroupBox groupBoxPJ;
        private System.Windows.Forms.RadioButton RB4;
        private System.Windows.Forms.RadioButton RB3;
        private System.Windows.Forms.RadioButton RB2;
        private System.Windows.Forms.RadioButton RB1;
        private System.Windows.Forms.CheckBox CBKomposer;
        private System.Windows.Forms.CheckBox CBVokal;
        private System.Windows.Forms.CheckBox CBDrum;
        private System.Windows.Forms.CheckBox CBPiano;
        private System.Windows.Forms.CheckBox CBKonduktor;
        private System.Windows.Forms.CheckBox CBSaxophone;
        private System.Windows.Forms.CheckBox CBGitar;
        private System.Windows.Forms.CheckBox CBBiola;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Label label1;
    }
}

