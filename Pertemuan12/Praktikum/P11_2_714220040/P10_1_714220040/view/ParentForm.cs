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
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 FormMhs = new Form1();
            FormMhs.MdiParent = this;
            FormMhs.Show();
        }

        private void dataNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNilai FrmNilai = new FormNilai();
            FrmNilai.MdiParent = this;
            FrmNilai.Show();
        }

        private void dataMasterBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 FrmMasterBarang = new FormBarang();
            FrmMasterBarang.MdiParent = this;
            FrmMasterBarang.Show();
        }

        private void dataMasterBarangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormBarang FrmDataBarang = new FormBarang();
            FrmDataBarang.MdiParent = this;
            FrmDataBarang.Show();
        }

        private void dataTransaksiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTransaksiBarang FrmTransaksi = new FormTransaksiBarang();
            FrmTransaksi.MdiParent = this;  
            FrmTransaksi.Show();
        }
    }
}
