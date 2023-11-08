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

namespace P7_1_714220040_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(370, 200);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (string.IsNullOrWhiteSpace(tbNama.Text))
            {
                errorMessage += "Nama Belum Diisi!\n";
            }

            if (string.IsNullOrWhiteSpace(tbProdi.Text))
            {
                errorMessage += "Prodi Belum Diisi!\n";
            }
            else if (!Regex.IsMatch(tbProdi.Text, @"^[A-Za-z0-9]+-[A-Za-z0-9]+$"))
            {
                errorMessage += "Prodi harus sesuai format [Strata]-[Prodi]\n";
            }

            if (string.IsNullOrWhiteSpace(tbKelas.Text))
            {
                errorMessage += "Kelas Belum Diisi!\n";
            }

            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show("Lengkapi!", "Informasi Data Submit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Size = new Size(450, 433);
            }
            else
            {
                MessageBox.Show(errorMessage, "Informasi Data Submit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void rbSenin_CheckedChanged(object sender, EventArgs e)
        {
            cbKuliah.Enabled = true; cbKuliah.Checked = true;
            cbTravelling.Enabled = false; cbTravelling.Checked = false;
            cbTidur.Enabled = true; cbTidur.Checked = true;
        }

        private void rbMinggu_CheckedChanged(object sender, EventArgs e)
        {
            cbKuliah.Enabled = false; cbKuliah.Checked = false;
            cbTravelling.Enabled = true; cbTravelling.Checked = true;
            cbTidur.Enabled = true; cbTidur.Checked = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //tbNama.Text = null;
            //tbProdi.Text = null;
            //tbKelas.Text = null;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Text = string.Empty;
                else if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = true;
                else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;

            }

            this.Size = new Size(413, 220);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            String Hari = "";
            String Kegiatan = "";

            if (rbSenin.Checked)
            {
                Hari += "Senin";
            }
            else if (rbMinggu.Checked)
            {
                Hari += "Minggu";
            }

            if (cbTidur.Checked && cbKuliah.Checked)
            {
                Kegiatan += "Kuliah, Tidur";
            }
            else if (cbTravelling.Checked && cbTidur.Checked)
            {
                Kegiatan += "Travelling, Tidur";
            }

            MessageBox.Show("Nama :" + tbNama.Text +
                "\nProdi :" + tbProdi.Text +
                "\nKelas :" + tbKelas.Text +
                "\nHari :" + Hari +
                "\nKegiatan :" + Kegiatan,
                "Informasi Kegiatan",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
