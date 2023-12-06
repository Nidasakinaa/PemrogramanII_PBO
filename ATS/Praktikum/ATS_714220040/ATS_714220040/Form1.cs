using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATS_714220040
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(680, 250);
            gbMatkul.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPilih_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (string.IsNullOrEmpty(tbNPM.Text))
            {
                errorMessage += "NPM belum diisi\n";
            }
            else
            {
                if (!tbNPM.Text.All(char.IsNumber))
                {
                    errorMessage += "NPM hanya berupa angka\n";
                }
                else
                {
                    if (tbNPM.Text.Length != 9)
                    {
                        errorMessage += "NPM harus terdiri dari 9 digit!\n";
                    }
                }
            }

            if (string.IsNullOrEmpty(tbNama.Text))
            {
                errorMessage += "Nama tidak boleh kosong!\n";
            }
            else
            {
                if (tbNama.Text.All(char.IsNumber))
                {
                    errorMessage += "Nama hanya berupa huruf\n";
                }
            }


            if (!rbLaki.Checked && !rbPerempuan.Checked)
            {
                errorMessage += "Pilih Jenis Kelamin!\n";
            }
            if (string.IsNullOrEmpty(tbAlamat.Text))
            {
                errorMessage += "Isi Alamat!\n";
            }

            if (cbProdi.SelectedIndex == -1)
            {
                errorMessage += "Pilih Program Studi!\n";
            }
            else
            {
                if ((cbProdi.Text != "D3 Teknik Informatika") && (cbProdi.Text != "D4 Teknik Informatika"))
                {
                    errorMessage += "Program Studi tidak sesuai\n";
                }
            }

            if (string.IsNullOrEmpty(tbTahun.Text))
            {
                errorMessage += "Isi Tahun Akademik!\n";
            }
            else
            {
                if (!Regex.IsMatch(tbTahun.Text, @"^\d{4}/\d{4}$"))
                {
                    errorMessage += "Tahun Akademik harus sesuai!\n";
                }
            }

            if (string.IsNullOrEmpty(tbSmt.Text))
            {
                errorMessage += "Semester tidak boleh kosong!\n";
            }
            else
            {
                if(!int.TryParse(tbSmt.Text, out int inputSmt))
                {
                    errorMessage += "Semester hanya berupa angka!\n";
                }else if (inputSmt <= 0 || inputSmt > 10)
                {
                    errorMessage += "Semester hanya 1 sampai dengan 10!";
                }
            }

            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(
                    "Data Lengkap!",
                    "Informasi Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Size = new Size(650, 556);
                gbMatkul.Enabled = false;
            }
            else
            {
                MessageBox.Show(
                    errorMessage,
                    "Informasi Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void tbNPM_TextChanged(object sender, EventArgs e)
        {
            if (tbNPM.Text == "")
            {
                epWarning.SetError(tbNPM, "NPM harus diisi!");
                epWrong.SetError(tbNPM, "");
                epCorrect.SetError(tbNPM, "");
            }
            else
            {
                if (!tbNPM.Text.All(Char.IsNumber))
                {
                    epWarning.SetError(tbNPM, "");
                    epWrong.SetError(tbNPM, "NPM Hanya Berbentuk Angka!");
                    epCorrect.SetError(tbNPM, "");
                }
                else
                {
                    if (tbNPM.Text.Length != 9)
                    {
                        epWarning.SetError(tbNPM, "NPM Harus Ada 9 Digit!");
                        epWrong.SetError(tbNPM, "");
                        epCorrect.SetError(tbNPM, "");
                    }
                    else
                    {
                        if ((tbNPM.Text).All(char.IsNumber))
                        {
                            epWarning.SetError(tbNPM, "");
                            epWrong.SetError(tbNPM, "");
                            epCorrect.SetError(tbNPM, "NPM Benar!");
                        }

                    }
                }
            }
        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNama.Text) || string.IsNullOrWhiteSpace(tbNama.Text))
            {
                epWarning.SetError(tbNama, "Nama tidak boleh kosong!");
                epWrong.SetError(tbNama, "");
                epCorrect.SetError(tbNama, "");
            }
            else
            {
                if (tbNama.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    epWarning.SetError(tbNama, "");
                    epWrong.SetError(tbNama, "");
                    epCorrect.SetError(tbNama, "Nama Benar!");
                }
                else
                {
                    epWarning.SetError(tbNama, "");
                    epWrong.SetError(tbNama, "Nama hanya berupa huruf!");
                    epCorrect.SetError(tbNama, "");
                }
            }
        }


        private void cbProdi_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbProdi.Text))
            {
                epWarning.SetError(cbProdi, "Program Studi tidak boleh kosong!");
                epWrong.SetError(cbProdi, "");
                epCorrect.SetError(cbProdi, "");
            }
            else
            {
                if ((cbProdi.Text != "D3 Teknik Informatika") && (cbProdi.Text != "D4 Teknik Informatika"))
                {
                    epWarning.SetError(cbProdi, "");
                    epWrong.SetError(cbProdi, "Program Studi salah!");
                    epCorrect.SetError(cbProdi, "");
                }
                else
                {
                    epWarning.SetError(cbProdi, "");
                    epWrong.SetError(cbProdi, "");
                    epCorrect.SetError(cbProdi, "Program Studi benar!");
                }
            }
        }

        private void tbTahun_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbTahun.Text, @"^\d{4}/\d{4}$"))
            {
                epWarning.SetError(tbTahun, "");
                epWrong.SetError(tbTahun, "");
                epCorrect.SetError(tbTahun, "Tahun Akademik Benar!");
            }
            else
            {
                epWarning.SetError(tbTahun, "");
                epWrong.SetError(tbTahun, "Tahun Akademik Studi salah!\nContoh Tahun Akademik yang valid: 2023/2024");
                epCorrect.SetError(tbTahun, "");
            }
        }

        private void tbSmt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSmt.Text))
            {
                epWarning.SetError(tbSmt, "Semester tidak boleh kosong!");
                epWrong.SetError(tbSmt, "");
                epCorrect.SetError(tbSmt, "");
            }
            else
            {
                if (int.TryParse(tbSmt.Text, out int inputSmt) && inputSmt > 0 && inputSmt <= 10)
                {
                    epWarning.SetError(tbSmt, "");
                    epWrong.SetError(tbSmt, "");
                    epCorrect.SetError(tbSmt, "Semester Benar!");
                }
                else
                {
                    epWarning.SetError(tbSmt, "Semester hanya berupa angka 1 sampai dengan 10!");
                    epWrong.SetError(tbSmt, "");
                    epCorrect.SetError(tbSmt, "");
                }
            }

        }

        private void tbAlamat_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbAlamat.Text))
            {
                epWarning.SetError(tbAlamat, "Isi Alamat!");
                epWrong.SetError(tbAlamat, "");
                epCorrect.SetError(tbAlamat, "");
            }
            else
            {
                epWarning.SetError(tbAlamat, "");
                epWrong.SetError(tbAlamat, "");
                epCorrect.SetError(tbAlamat, "Alamat sudah diisi");
            }
        }

        private void rb2006_CheckedChanged(object sender, EventArgs e)
        {
            gbMatkul.Enabled = true;
            if (rb2006.Checked)
            {
                cbPL.Enabled = false;
                cbPL.Checked = false;
                cbManajemen.Enabled = false;
                cbManajemen.Checked = false;
                cbMTK.Enabled = true;
                cbP1.Enabled = true;
                cbP2.Enabled = true;
                cbP3.Enabled = true;
                cbP4.Enabled = true;
                cbFisika.Enabled = true;
                cbPA.Enabled = true;
                cbPKN.Enabled = true;
                cbJK.Enabled = true;
                cbSO.Enabled = true;
            }
        }

        private void rb2013_CheckedChanged(object sender, EventArgs e)
        {
            gbMatkul.Enabled = true;
            if (rb2013.Checked)
            {
                cbPL.Enabled = true;
                cbManajemen.Enabled = true;
                cbMTK.Enabled = true;
                cbP1.Enabled = true;
                cbP2.Enabled = true;
                cbP3.Enabled = true;
                cbP4.Enabled = true;
                cbFisika.Enabled = false;
                cbFisika.Checked = false;
                cbPA.Enabled = true;
                cbPKN.Enabled = false;
                cbPKN.Checked = false;
                cbJK.Enabled = true;
                cbSO.Enabled = true;
            }
        }

        private void rbMerdeka_CheckedChanged(object sender, EventArgs e)
        {
            gbMatkul.Enabled = true;
            if (rbMerdeka.Checked)
            {
                cbPL.Enabled = false;
                cbPL.Checked = false;
                cbManajemen.Enabled = true;
                cbMTK.Enabled = false;
                cbMTK.Checked = false;
                cbP1.Enabled = true;
                cbP2.Enabled = true;
                cbP3.Enabled = true;
                cbP4.Enabled = true;
                cbFisika.Enabled = false;
                cbFisika.Checked = false;
                cbPA.Enabled = true;
                cbPKN.Enabled = true;
                cbJK.Enabled = true;
                cbSO.Enabled = true;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string jenisKelamin = "";

            if (rbLaki.Checked == true)
            {
                jenisKelamin = "Laki - Laki";
            }
            else if (rbPerempuan.Checked == true)
            {
                jenisKelamin = "Perempuan";
            }

            string kurikulum = "";
            string matkul = "";

            if (rb2006.Checked == true)
            {
                kurikulum = "Kurikulum 2006";
            }
            else if (rb2013.Checked == true)
            {
                kurikulum = "Kurikulum 2013";
            }
            else if (rbMerdeka.Checked == true)
            {
                kurikulum = "Kurikulum Merdeka";
            }
            else
            {
                MessageBox.Show("Pilih Kurikulum!",
                    "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbMTK.Checked == true)
            {
                matkul += "Matematika, ";
            }
            if (cbP1.Checked == true)
            {
                matkul += "Pemrograman 1, ";
            }
            if (cbP2.Checked == true)
            {
                matkul += "Pemrograman 2, ";
            }
            if (cbP3.Checked == true)
            {
                matkul += "Pemrograman 3, ";
            }
            if (cbP4.Checked == true)
            {
                matkul += "Pemrograman 4, ";
            }
            if (cbFisika.Checked == true)
            {
                matkul += "Fisika, ";
            }
            if (cbPA.Checked == true)
            {
                matkul += "Pendidikan Agama, ";
            }
            if (cbPKN.Checked == true)
            {
                matkul += "Pendidikan Kewarganegaraan, ";
            }
            if (cbPL.Checked == true)
            {
                matkul += "Pengantar Logistik, ";
            }
            if (cbJK.Checked == true)
            {
                matkul += "Jaringan Komputer, ";
            }
            if (cbSO.Checked == true)
            {
                matkul += "Sistem Operasi, ";
            }
            if (cbManajemen.Checked == true)
            {
                matkul += "Manajemen Rantai Pasok, ";
            }

            matkul = matkul.TrimEnd(',', ' ');

            if (String.IsNullOrWhiteSpace(matkul))
            {
                MessageBox.Show(" Pilih salah satu Mata Kuliah",
                    "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string errorMessage = "";

            if (string.IsNullOrEmpty(tbNPM.Text))
            {
                errorMessage += "Isi NPM!\n";
            }
            else
            {
                if (!tbNPM.Text.All(char.IsNumber))
                {
                    errorMessage += "NPM harus berupa angka\n";
                }
                else
                {
                    if (tbNPM.Text.Length != 9)
                    {
                        errorMessage += "NPM harus terdiri dari 9 angka!\n";
                    }
                }
            }


            if (string.IsNullOrEmpty(tbNama.Text))
            {
                errorMessage += "Nama belum diisi\n";
            }
            else
            {
                if (tbNama.Text.All(char.IsNumber))
                {
                    errorMessage += "Nama harus berupa huruf\n";
                }
            }

            if (!rbLaki.Checked && !rbPerempuan.Checked)
            {
                errorMessage += "Pilih Jenis Kelamin!\n";
            }
            if (string.IsNullOrEmpty(tbAlamat.Text))
            {
                errorMessage += "Isi Alamat!\n";
            }

            if (cbProdi.SelectedIndex == -1)
            {
                errorMessage += "Pilih Program Studi!\n";
            }
            else
            {
                if ((cbProdi.Text != "D3 Teknik Informatika") && (cbProdi.Text != "D4 Teknik Informatika"))
                {
                    errorMessage += "Program Studi tidak sesuai\n";
                }
            }

            if (string.IsNullOrEmpty(tbTahun.Text))
            {
                errorMessage += "Isi Tahun Akademik!\n";
            }
            else
            {
                if (!Regex.IsMatch(tbTahun.Text, @"^\d{4}/\d{4}$"))
                {
                    errorMessage += "Tahun Akademik tidak sesuai\n";
                }
            }


            if (string.IsNullOrEmpty(tbSmt.Text))
            {
                errorMessage += "Isi Semester!\n";
            }
            else
            {
                if (!int.TryParse(tbSmt.Text, out int inputSmt))
                {
                    errorMessage += "Semester hanya berisi angka\n";
                }
                else if (inputSmt <= 0 || inputSmt > 10)
                {
                    errorMessage += "Semester hanya angka 1 sampai dengan 10";
                }
            }

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(
                    "Data Belum Lengkap", "Informasi Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(errorMessage))
                {
                    MessageBox.Show(
                        "Data Lengkap!",
                        "Informasi Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Size = new Size(735, 500);
                    gbMatkul.Enabled = false;
                }
                else
                {
                    MessageBox.Show(
                        errorMessage,
                        "Informasi Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


            MessageBox.Show("NPM : " + tbNPM.Text +
                "\nNama : " + tbNama.Text +
                "\nJenis Kelamin : " + jenisKelamin +
                "\nAlamat : " + tbAlamat.Text +
                "\nProgram Studi : " + cbProdi.Text +
                "\nTahun Akademik : " + tbTahun.Text +
                "\nSemester : " + tbSmt.Text +
                "\n=======================================" +
                "\nKurikulum : " + kurikulum +
                "\nMata Kuliah : " + matkul,
                "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                    epWarning.SetError(textBox, "");
                    epWrong.SetError(textBox, "");
                    epCorrect.SetError(textBox, "");
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                    epWarning.SetError(comboBox, "");
                    epWrong.SetError(comboBox, "");
                    epCorrect.SetError(comboBox, "");
                }
                else if (control is GroupBox groupBox)
                {
                    foreach (Control innerControl in groupBox.Controls)
                    {
                        if (innerControl is RadioButton innerRadioButton)
                        {
                            innerRadioButton.Checked = false;
                        }
                        else if (innerControl is CheckBox innerCheckBox)
                        {
                            innerCheckBox.Checked = false;
                        }
                    }
                }
            }
            this.Size = new Size(670, 550);
            gbMatkul.Enabled = false;
        }
    }
}
