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
    public partial class DataPelanggan : Form
    {
        string connectionString = "data source =LAPTOP-LE37C152\\MIMITI03;" +
           "database=Hotel;user ID=sa; password=masadepan180423";
        private SqlConnection koneksi;
        public DataPelanggan()
        {
            InitializeComponent();
            koneksi = new SqlConnection(connectionString);
            refreshform();
        }
        private void refreshform()
        {
            idplg.Text = "";
            idplg.Enabled = false;
            clear.Enabled = false;
            save.Enabled = false;
            nama.Text = "";
            nama.Enabled = false;
            nohp.Text = "";
            nohp.Enabled = false;
            jk.Enabled = false;
        }

        private void Form3_Load(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            idplg.Enabled = true;
            nama.Enabled=true;
            nohp.Enabled=true;
            jk.Enabled=true;
            clear.Enabled = true;
            save.Enabled = true;
            add.Enabled = true;
        }

        private void next_Click(object sender, EventArgs e)
        {
            DataMember mb = new DataMember();
            mb.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            home hom = new home();
            hom.Show();
            this.Hide();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string IdPelanggan = idplg.Text;
            string Name = nama.Text;
            string NoHp = nohp.Text;
            string JK = jk.SelectedItem.ToString();


            if (IdPelanggan == "")
            {
                MessageBox.Show("masukan ID Kamar", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.Hotel (id_pelanggan, nama, no_hp,jk)" + "values(@id, @nm, @nohp, @jk)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id", idplg));
                cmd.Parameters.Add(new SqlParameter("nm", nama));
                cmd.Parameters.Add(new SqlParameter("nohp", nohp));
                cmd.Parameters.Add(new SqlParameter("jk", jk));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil disimpan", "sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1_CellContentClick();
                refreshform();
            }
        }

        private void dataGridView1_CellContentClick()
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            koneksi.Open();
            string query = "select id_pelanggan, nama, no_hp,jk from dbo.Hotel" + "values(@id, @nm, @nohp, @jk)";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, koneksi);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            pelanggan.DataSource = dataSet.Tables[0];
        }
    }
}
