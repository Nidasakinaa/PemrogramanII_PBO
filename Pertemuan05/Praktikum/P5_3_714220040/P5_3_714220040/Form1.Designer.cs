namespace P5_3_714220040
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMerkHP = new System.Windows.Forms.TextBox();
            this.rb_android = new System.Windows.Forms.RadioButton();
            this.iOS = new System.Windows.Forms.RadioButton();
            this.cbYa = new System.Windows.Forms.CheckBox();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Merk HP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "OS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sudah Diperbaiki?";
            // 
            // txtMerkHP
            // 
            this.txtMerkHP.Font = new System.Drawing.Font("Trebuchet MS", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMerkHP.Location = new System.Drawing.Point(205, 35);
            this.txtMerkHP.Name = "txtMerkHP";
            this.txtMerkHP.Size = new System.Drawing.Size(239, 34);
            this.txtMerkHP.TabIndex = 3;
            // 
            // rb_android
            // 
            this.rb_android.AutoSize = true;
            this.rb_android.Location = new System.Drawing.Point(205, 104);
            this.rb_android.Name = "rb_android";
            this.rb_android.Size = new System.Drawing.Size(105, 29);
            this.rb_android.TabIndex = 4;
            this.rb_android.TabStop = true;
            this.rb_android.Text = "Android";
            this.rb_android.UseVisualStyleBackColor = true;
            // 
            // iOS
            // 
            this.iOS.AutoSize = true;
            this.iOS.Location = new System.Drawing.Point(373, 105);
            this.iOS.Name = "iOS";
            this.iOS.Size = new System.Drawing.Size(71, 29);
            this.iOS.TabIndex = 5;
            this.iOS.TabStop = true;
            this.iOS.Text = "iOS";
            this.iOS.UseVisualStyleBackColor = true;
            // 
            // cbYa
            // 
            this.cbYa.AutoSize = true;
            this.cbYa.Location = new System.Drawing.Point(242, 170);
            this.cbYa.Name = "cbYa";
            this.cbYa.Size = new System.Drawing.Size(62, 29);
            this.cbYa.TabIndex = 6;
            this.cbYa.Text = "Ya";
            this.cbYa.UseVisualStyleBackColor = true;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(47, 243);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(118, 44);
            this.btnTampilkan.TabIndex = 7;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(259, 243);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(118, 44);
            this.btnKeluar.TabIndex = 8;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(456, 299);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.cbYa);
            this.Controls.Add(this.iOS);
            this.Controls.Add(this.rb_android);
            this.Controls.Add(this.txtMerkHP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Service HP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMerkHP;
        private System.Windows.Forms.RadioButton rb_android;
        private System.Windows.Forms.RadioButton iOS;
        private System.Windows.Forms.CheckBox cbYa;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnKeluar;
    }
}

