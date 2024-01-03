using MySql.Data.MySqlClient;
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
    public partial class FormTransaksiBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        string id_transaksi;
        M_transaksi_barang m_transaksibarang = new M_transaksi_barang();    
        M_barang m_Barang = new M_barang();
        public FormTransaksiBarang()
        {
            InitializeComponent();
            nama.ReadOnly = true;
            nama.Enabled = false;
            harga.Enabled = false;
            harga.ReadOnly = true;
            total.Enabled = false;
            total.ReadOnly = true;

            LoadIdBarang();
        }

        public void Tampil()
        {
            DataTransaksi.DataSource = koneksi.ShowData("SELECT id_transaksi, b.id_barang, nama_barang, harga, qty, total FROM t_transaksi t JOIN t_barang b ON (t.id_barang = b.id_barang)");
            DataTransaksi.Columns[0].HeaderText = "ID";
            DataTransaksi.Columns[1].HeaderText = "ID Barang";
            DataTransaksi.Columns[2].HeaderText = "Nama Barang";
            DataTransaksi.Columns[3].HeaderText = "Harga";
            DataTransaksi.Columns[4].HeaderText = "QTY";
            DataTransaksi.Columns[5].HeaderText = "Total Harga";
        }

        public void resetForm()
        {
            id.Text = "";
            nama.Text = "";
            harga.Text = "";
            qty.Text = "";
            total.Text = "";
            tbCariData.Text = "";
        }

        public void GetDataBarang(int selectIdBarang)
        {
            koneksi.OpenConnection();

            string query = $"SELECT nama_barang, harga FROM t_barang WHERE id_barang = {selectIdBarang}";
            MySqlDataReader reader = koneksi.reader(query);

            if (reader.Read())
            {
                nama.Text = reader["nama_barang"].ToString();
                harga.Text = reader["harga"].ToString();
            }

            reader.Close();
            koneksi.CloseConnection();
        }

        private void Total()
        {
            if (double.TryParse(qty.Text, out double qty_barang) && double.TryParse(harga.Text.Replace(".", ""), out double harga_barang))
            {
                double totals = qty_barang*harga_barang;
                string formattedTotal = string.Format("{0:#,##0}", totals);
                total.Text = formattedTotal;
            }
        }

        public void LoadIdBarang()
        {
            koneksi.OpenConnection();

            string query = "SELECT id_barang FROM t_barang";
            object dataTable = koneksi.ShowData(query);

            id.DisplayMember = "id_barang";
            id.ValueMember = "id_barang";
            id.DataSource = dataTable;

            koneksi.CloseConnection();
        }

        private void FormTransaksiBarang_Load(object sender, EventArgs e)
        {
            Tampil();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

            if (id.Text == "" || nama.Text == "" || harga.Text == "" || qty.Text == "" || total.Text == "" || id.Text.Any(Char.IsLetter) || qty.Text.Any(Char.IsLetter) || id.SelectedItem == null)
            {
                MessageBox.Show("Isi form dengan benar sebelum disimpan!", "Gagal Menyimpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TransaksiBarang tf = new TransaksiBarang();
                m_transaksibarang.Id_barang = id.Text;
                m_transaksibarang.Qty = qty.Text;

                string formattedTotal = total.Text.Replace("Rp ", "").Replace(",", "");
                if (double.TryParse(formattedTotal, out double numericTotal))
                {
                    m_transaksibarang.Total = numericTotal.ToString();
                }

                tf.Insert(m_transaksibarang);
                resetForm();
                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (id.Text != "" || nama.Text != "" || harga.Text != "" || qty.Text != "" || total.Text != "" || !id.Text.Any(Char.IsLetter) || !qty.Text.Any(Char.IsLetter) || id.SelectedItem != null)
            {
                TransaksiBarang tf = new TransaksiBarang();
                m_transaksibarang.Id_barang = id.Text;
                m_transaksibarang.Qty = qty.Text;

                string formattedTotal = total.Text.Replace("Rp ", "").Replace(",", "");
                if (double.TryParse(formattedTotal, out double numericTotal))
                {
                    m_transaksibarang.Total = numericTotal.ToString();
                }

                tf.Update(m_transaksibarang, id_transaksi);
                resetForm();
                Tampil();
            }
            else
            {
                MessageBox.Show("Isi data dengan benar sebelum diperbarui!", "Terjadi Kesalahan Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Apakah kamu yakin ingin menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                TransaksiBarang tf = new TransaksiBarang();
                tf.Delete(id_transaksi);
                resetForm();
                Tampil();
            }
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            DataTransaksi.DataSource = koneksi.ShowData("SELECT id_transaksi, b.id_barang, nama_barang, harga, qty, total FROM t_transaksi t JOIN t_barang b ON (t.id_barang = b.id_barang) WHERE id_transaksi LIKE '%' '" + tbCariData.Text + "' '%' OR t.id_barang LIKE '%' '" + tbCariData.Text + "' '%' OR b.id_barang LIKE '%' '" + tbCariData.Text + "' '%' OR nama_barang LIKE '%' '" + tbCariData.Text + "' '%' OR harga LIKE '%' '" + tbCariData.Text + "' '%' OR qty LIKE '%' '" + tbCariData.Text + "' '%' OR total LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private void DataTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_transaksi = DataTransaksi.Rows[e.RowIndex].Cells[0].Value.ToString();
            id.Text = DataTransaksi.Rows[e.RowIndex].Cells[1].Value.ToString();
            nama.Text = DataTransaksi.Rows[e.RowIndex].Cells[2].Value.ToString();
            harga.Text = DataTransaksi.Rows[e.RowIndex].Cells[3].Value.ToString();
            qty.Text = DataTransaksi.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void harga_TextChanged(object sender, EventArgs e)
        {

        }

        private void total_TextChanged(object sender, EventArgs e)
        {
            Total();
        }

        private void qty_TextChanged(object sender, EventArgs e)
        {
            Total();
        }

        private void id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (id.SelectedValue != null)
            {
                int selectIdBarang;
                if (int.TryParse(id.SelectedValue.ToString(), out selectIdBarang))
                {
                    GetDataBarang(selectIdBarang);
                }
            }
        }
    }
}
