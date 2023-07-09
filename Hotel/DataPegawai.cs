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
    public partial class DataPegawai : Form
    {
        public DataPegawai()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home hom = new home();
            hom.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            home hom = new home();
            hom.Show();
            this.Hide();
        }
    }
}
