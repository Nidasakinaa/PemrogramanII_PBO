using P10_1_714220040.controller;
using P10_1_714220040.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_1_714220040.view
{
    public partial class FormBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        M_barang m_barang = new M_barang();
        string id_barang;
        public FormBarang()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            DataBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang");
            DataBarang.Columns[0].HeaderText = "ID Barang";
            DataBarang.Columns[1].HeaderText = "Nama Barang";
            DataBarang.Columns[2].HeaderText = "Harga";
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void resetForm()
        {
            nama.Text = "";
            harga.Text = "";
            tbCariData.Text = "";
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            resetForm();
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if(nama.Text == "" || harga.Text == "")
            {
                MessageBox.Show("Data Tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Barang barang = new Barang();
                m_barang.Nama_barang = nama.Text;
                m_barang.Harga = harga.Text;

                barang.Insert(m_barang);
                resetForm();
                Tampil() ;
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if(nama.Text != "" || harga.Text != "")
            {
                Barang barang = new Barang();
                m_barang.Nama_barang = nama.Text;
                m_barang.Harga = harga.Text;

                barang.Update(m_barang, id_barang);
                resetForm();
                Tampil() ;
            }
            else
            {
                MessageBox.Show("Data harus diisi dengan benar!", "Kesalahan Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                Barang barang = new Barang();
                barang.Delete(id_barang);
                resetForm();
                Tampil();
            }
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            DataBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang WHERE id_barang LIKE '%' '" + tbCariData.Text + "' '%' OR nama_barang LIKE '%' '" + tbCariData.Text + "' '%' OR harga LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private void DataBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_barang = DataBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            nama.Text = DataBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            harga.Text = DataBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
