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
    public partial class DataKamar : Form
    {
        string connectionString = "data source =LAPTOP-LE37C152\\MIMITI03;" +
           "database=Hotel;user ID=sa; password=masadepan180423";
        private SqlConnection koneksi;
        public DataKamar()
        {
            InitializeComponent();
            koneksi = new SqlConnection(connectionString);
            refreshform();
        }

        private void refreshform()
        {
            idkmr.Text = "";
            idkmr.Enabled = false;
            clear.Enabled = false;
            save.Enabled = false;
            nmkmr.Text = "";
            nmkmr.Enabled = false;
            tpkmr.Enabled = false;
            ltkmr.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            idkmr.Enabled = true;
            tpkmr.Enabled=true;
            nmkmr.Enabled=true;
            ltkmr.Enabled=true;
            clear.Enabled=true;
            save.Enabled=true;
            add.Enabled=true;

        }

        private void dataGridView(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string IdKamar = idkmr.Text;
            string NmKamar = nmkmr.Text;
            string tipekamar = tpkmr.SelectedItem.ToString();
            string LtKamar = ltkmr.SelectedItem.ToString();


            if (IdKamar == "")
            {
                MessageBox.Show("masukan ID Kamar", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.Kamar (id_kamar, tipe_kamar,no_kamar, lantai_kamar )" + "values(@nm, @id, @tk, @lk)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("nm", IdKamar));
                cmd.Parameters.Add(new SqlParameter("id", NmKamar));
                cmd.Parameters.Add(new SqlParameter("tk", tipekamar));
                cmd.Parameters.Add(new SqlParameter("lk", LtKamar));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil disimpan", "sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void dataGridView()
        {
            koneksi.Open();
            string query = "select id_kamar, tipe_kamar, no_kamar, lantai_kamar from dbo.Kamar";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, koneksi);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            kamarview.DataSource = dataSet.Tables[0];
        }

        private void exit_Click(object sender, EventArgs e)
        {
           home hom = new home ();
            hom.Show();
            this.Hide();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home hom = new home();
            hom.Show();
            this.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            DataPelanggan plg = new DataPelanggan();
            plg.Show();
            this.Hide();
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
