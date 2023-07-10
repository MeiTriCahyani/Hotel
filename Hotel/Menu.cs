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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DataPegawai pgw = new DataPegawai();
            pgw.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Departemen dpt = new Departemen();
            dpt.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DataPelanggan plg = new DataPelanggan();
            plg.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Membre mm = new Membre();
            mm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DataKamar kmr = new DataKamar();
            kmr.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DataPemesanan psn = new DataPemesanan();
            psn.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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
    }
}
