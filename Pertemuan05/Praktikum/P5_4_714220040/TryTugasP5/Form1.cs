using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714220040
{
    public partial class FormAstraMusicSchool : Form
    {
        public FormAstraMusicSchool()
        {
            InitializeComponent();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            string jadwal = "";
            string kelas = "";

            if (textBoxName.Text == "")
            {
                MessageBox.Show("Nama harus diisi!",
                                    "Warning!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CBJK.Text != "Laki-laki" && CBJK.Text != "Perempuan")
            {
                MessageBox.Show("Jenis kelamin tidak valid!",
                                    "Warning!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CBBiola.Checked)
            {
                kelas += "Biola, ";
            }
            if (CBGitar.Checked)
            {
                kelas += "Gitar, ";
            }
            if (CBSaxophone.Checked)
            {
                kelas += "Saxophone, ";
            }
            if (CBKonduktor.Checked)
            {
                kelas += "Konduktor, ";
            }
            if (CBPiano.Checked)
            {
                kelas += "Piano, ";
            }
            if (CBDrum.Checked)
            {
                kelas += "Drum, ";
            }
            if (CBVokal.Checked)
            {
                kelas += "Vokal, ";
            }
            if (CBKomposer.Checked)
            {
                kelas += "Komposer, ";
            }

            kelas = kelas.TrimEnd(',', ' ');

            if (string.IsNullOrWhiteSpace(kelas))
            {
                MessageBox.Show("Harus memilih salah satu atau lebih dari pilihan kelas!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (RB1.Checked == true)
            {
                jadwal = "Senin & Rabu, 14.00 - 16.00";
            }
            else if (RB2.Checked == true)
            {
                jadwal = "Selasa & Kamis, 14.00 - 16.00";
            }
            else if (RB3.Checked == true)
            {
                jadwal = "Sabtu & Minggu, 09.00 - 11.00";
            }
            else if (RB4.Checked == true)
            {
                jadwal = "Minggu, 13.00 - 17.00";
            }
            else
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan jadwal!",
                    "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Nama : " + textBoxName.Text +
                "\nJenis Kelamin : " + CBJK.Text +
                "\nTanggal Lahir : " + DateTimePicker.Text +
                "\nPilihan Kelas : " + kelas +
                "\nPilihan Jadwal : " + jadwal,
                "Informasi Pendaftaran",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}