using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_4_714220040_1_
{
    public partial class Form1 : Form
    {
        private string jkelamin;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            string inputName = tbName.Text;

            if (string.IsNullOrEmpty(inputName))
            {
                epWarning.SetError(tbName, "Nama Tidak Boleh Kosong!");
                epError.SetError(tbName, "");
                epCorrect.SetError(tbName, "");
            }
            else
            {
                if (char.IsUpper(inputName[0]) && inputName.Substring(1).All(char.IsLetter))
                {
                    epWarning.SetError(tbName, "");
                    epError.SetError(tbName, "");
                    epCorrect.SetError(tbName, "Benar!");
                }
                else
                {
                    epWarning.SetError(tbName, "");
                    epError.SetError(tbName, "Awali dengan Huruf Kapital!");
                    epCorrect.SetError(tbName, "");
                }
            }
        }

        private void tbAlamat_Leave(object sender, EventArgs e)
        {
            string inputAlamat = tbAlamat.Text;

            if (string.IsNullOrEmpty(inputAlamat))
            {
                epWarning.SetError(tbAlamat, "Alamat Tidak Boleh Kosong!");
                epError.SetError(tbAlamat, "");
                epCorrect.SetError(tbAlamat, "");
            }
            else
            {
                if (char.IsLower(inputAlamat[0]) && inputAlamat.Substring(1).All(char.IsLetter))
                {
                    epWarning.SetError(tbAlamat, "");
                    epError.SetError(tbAlamat, "");
                    epCorrect.SetError(tbAlamat, "Benar!");
                }
                else
                {
                    epWarning.SetError(tbAlamat, "");
                    epError.SetError(tbAlamat, "Awali dengan Huruf Kecil!");
                    epCorrect.SetError(tbAlamat, "");
                }
            }
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            String jkelamin = "";
            String agama = "";

            if (rb1.Checked == true)
            {
                jkelamin = "Perempuan";
            }
            else if (rb2.Checked == true)
            {
                jkelamin = "Laki-laki";
            }
            else
            {
                MessageBox.Show("Pilih Jenis Kelamin!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbAgama.Text != "Islam" && cbAgama.Text != "Kristen" && cbAgama.Text != "Katholik" && cbAgama.Text != "Hindu" && cbAgama.Text != "Buddha" && cbAgama.Text != "Konghucu")
            {
                MessageBox.Show("Pilih Agama!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Nama : " + tbName.Text +
              "\nTanggal Lahir :" + dateTimePicker.Text +
              "\nAlamat :" + tbAlamat.Text +
              "\nJenis Kelamin :" + jkelamin +
              "\nAgama :" + cbAgama.Text +
              "\nNo Telp :" + tbNoTelp.Text,
              "Informasi Pendaftaran",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tbNoTelp_TextChanged(object sender, EventArgs e)
        {
            if (tbNoTelp.Text == "")
            {
                epWarning.SetError(tbNoTelp, "No Telp Harus Diisi!");
                epError.SetError(tbNoTelp, "");
                epCorrect.SetError(tbNoTelp, "");
            }
            else
            {
                if ((tbNoTelp.Text).All(char.IsNumber))
                {
                    if (tbNoTelp.Text.Length >= 10 && tbNoTelp.Text.Length <= 13)
                    {
                        epWarning.SetError(tbNoTelp, "");
                        epError.SetError(tbNoTelp, "");
                        epCorrect.SetError(tbNoTelp, "Betul!");
                    }
                    else
                    {
                        epWarning.SetError(tbNoTelp, "No Telp Minimal 10 angka!");
                        epError.SetError(tbNoTelp, "");
                        epCorrect.SetError(tbNoTelp, "");
                    }
                }
                else
                {
                    epWarning.SetError(tbNoTelp, "");
                    epError.SetError(tbNoTelp, "Hanya Angka yang Dapat Diinputkan!");
                    epCorrect.SetError(tbNoTelp, "");
                }
            }
        }


        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
