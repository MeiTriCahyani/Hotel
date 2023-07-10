using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class DataPemesanan : Form
    {
        public DataPemesanan()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataPegawai pgw = new DataPegawai();
            pgw.Show();
            this.Hide();
        }

        private void dataPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataPelanggan plg = new DataPelanggan();
            plg.Show();
            this.Hide();
        }

        private void dataKamarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataKamar kmr = new DataKamar();
            kmr.Show();
            this.Hide();
        }

        private void dataPemesananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataPemesanan pms = new DataPemesanan();
            pms.Show();
            this.Hide();
        }

        private void dataTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTansaksi trs = new DataTansaksi();
            trs.Show();
            this.Hide();
        }

        private void DataPemesanan_Load(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            DataTansaksi trs = new DataTansaksi();
            trs.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            home hom = new home();
            hom.Show();
            this.Hide();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home hom = new home();
            hom.Show();
            this.Hide();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }
    }
}
