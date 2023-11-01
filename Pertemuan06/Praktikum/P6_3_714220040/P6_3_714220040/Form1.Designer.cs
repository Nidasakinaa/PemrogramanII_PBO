namespace P6_3_714220040
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblHrf = new System.Windows.Forms.Label();
            this.lblAngka = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAngka1 = new System.Windows.Forms.Label();
            this.lblAngka2 = new System.Windows.Forms.Label();
            this.txtHuruf = new System.Windows.Forms.TextBox();
            this.txtAngka = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAngka1 = new System.Windows.Forms.TextBox();
            this.txtAngka2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHrf
            // 
            this.lblHrf.AutoSize = true;
            this.lblHrf.Location = new System.Drawing.Point(118, 44);
            this.lblHrf.Name = "lblHrf";
            this.lblHrf.Size = new System.Drawing.Size(59, 25);
            this.lblHrf.TabIndex = 0;
            this.lblHrf.Text = "Huruf";
            // 
            // lblAngka
            // 
            this.lblAngka.AutoSize = true;
            this.lblAngka.Location = new System.Drawing.Point(117, 95);
            this.lblAngka.Name = "lblAngka";
            this.lblAngka.Size = new System.Drawing.Size(69, 25);
            this.lblAngka.TabIndex = 1;
            this.lblAngka.Text = "Angka";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(118, 145);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblAngka1
            // 
            this.lblAngka1.AutoSize = true;
            this.lblAngka1.Location = new System.Drawing.Point(113, 250);
            this.lblAngka1.Name = "lblAngka1";
            this.lblAngka1.Size = new System.Drawing.Size(85, 25);
            this.lblAngka1.TabIndex = 3;
            this.lblAngka1.Text = "Angka 1";
            // 
            // lblAngka2
            // 
            this.lblAngka2.AutoSize = true;
            this.lblAngka2.Location = new System.Drawing.Point(118, 309);
            this.lblAngka2.Name = "lblAngka2";
            this.lblAngka2.Size = new System.Drawing.Size(85, 25);
            this.lblAngka2.TabIndex = 4;
            this.lblAngka2.Text = "Angka 2";
            // 
            // txtHuruf
            // 
            this.txtHuruf.Location = new System.Drawing.Point(351, 44);
            this.txtHuruf.Name = "txtHuruf";
            this.txtHuruf.Size = new System.Drawing.Size(324, 29);
            this.txtHuruf.TabIndex = 5;
            this.txtHuruf.Leave += new System.EventHandler(this.txtHuruf_Leave);
            // 
            // txtAngka
            // 
            this.txtAngka.Location = new System.Drawing.Point(351, 95);
            this.txtAngka.Name = "txtAngka";
            this.txtAngka.Size = new System.Drawing.Size(324, 29);
            this.txtAngka.TabIndex = 6;
            this.txtAngka.Leave += new System.EventHandler(this.txtAngka_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(351, 140);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(324, 29);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtAngka1
            // 
            this.txtAngka1.Location = new System.Drawing.Point(351, 250);
            this.txtAngka1.Name = "txtAngka1";
            this.txtAngka1.Size = new System.Drawing.Size(324, 29);
            this.txtAngka1.TabIndex = 8;
            this.txtAngka1.Leave += new System.EventHandler(this.txtAngka1_Leave);
            // 
            // txtAngka2
            // 
            this.txtAngka2.Location = new System.Drawing.Point(351, 309);
            this.txtAngka2.Name = "txtAngka2";
            this.txtAngka2.Size = new System.Drawing.Size(324, 29);
            this.txtAngka2.TabIndex = 9;
            this.txtAngka2.Leave += new System.EventHandler(this.txtAngka2_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(123, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "*Angka 1 > Angka 2";
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAngka2);
            this.Controls.Add(this.txtAngka1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAngka);
            this.Controls.Add(this.txtHuruf);
            this.Controls.Add(this.lblAngka2);
            this.Controls.Add(this.lblAngka1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAngka);
            this.Controls.Add(this.lblHrf);
            this.Name = "Form1";
            this.Text = "Validasi";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHrf;
        private System.Windows.Forms.Label lblAngka;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAngka1;
        private System.Windows.Forms.Label lblAngka2;
        private System.Windows.Forms.TextBox txtHuruf;
        private System.Windows.Forms.TextBox txtAngka;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAngka1;
        private System.Windows.Forms.TextBox txtAngka2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}

