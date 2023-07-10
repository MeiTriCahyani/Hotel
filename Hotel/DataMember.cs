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
    public partial class Membre : Form
    {
        private string stringConnection = "data source = DESKTOP-ACER202\\MAHARANI; database = Hotel; user ID = sa; password = 123";
        private SqlConnection connection;
        public Membre()
        {
            InitializeComponent();
            connection = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            idplgm.Text ="";
            idplgm.Enabled = false;
            jm.Text = "";
            jm.Enabled = false;
            save.Enabled = false;
            clear.Enabled = false;
            clearBinding();
        }

        private void Membre_Load(object sender, EventArgs e)
        {

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

        private void add_Click(object sender, EventArgs e)
        {
            idplgm.Text = "";
            jm.Text = "";
            idplgm.Enabled = true;
            jm.Enabled = true;
            save.Enabled = true;
            clear.Enabled = true;
            add.Enabled = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            string idpelanggan = idplgm.Text.Trim();
            string jenismember = jm.Text.Trim();

            if (string.IsNullOrEmpty(idpelanggan) || string.IsNullOrEmpty(jenismember))
            {
                MessageBox.Show("Please fill the data!");
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO member (id_pelanggan, jenis_member) VALUES(@id_pelanggan, @jenis_member)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id_pelanggan", idpelanggan);
                    command.Parameters.AddWithValue("@jenis_member", jenismember);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Data has been saved to the database.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally 
                { 
                    connection.Close();
                }
            }
            refreshform();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void clearBinding()
        {
            this.idplgm.DataBindings.Clear();
            this.jm.DataBindings.Clear();
        }

        private void DataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();
                    string query = "SELECT m.id_pelanggan, m.jenis_member FROM dbo.Pelanggan m join dbo.Member p on m.id_pelanggan = p.id_pelanggan";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    memberview.DataSource = dataSet.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void open_Click(object sender, EventArgs e)
        {
            DataGridView();
            open.Enabled = true;
        }
    }
}
