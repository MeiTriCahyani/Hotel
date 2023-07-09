using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class DataMember : Form
    {
        string connectionString = "data source =LAPTOP-LE37C152\\MIMITI03;" +
           "database=Hotel;user ID=sa; password=masadepan180423";
        private SqlConnection koneksi;
        public DataMember()
        {
            InitializeComponent();
            koneksi = new SqlConnection(connectionString);
            refreshform();

        }
        private void refreshform()
        {
            idplgm.Text = "";
            idplgm.Enabled = false;
            clear.Enabled = false;
            save.Enabled = false;
            jm.Enabled = false;
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home hom = new home();
            hom.Show();
            this.Hide();
        }

        private void DataMember_Load(object sender, EventArgs e)
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

        private void next_Click(object sender, EventArgs e)
        {
            DataPemesanan pms = new DataPemesanan();
            pms.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            home hom = new home();
            hom.Show();
            this.Hide();
        }
    }
}
