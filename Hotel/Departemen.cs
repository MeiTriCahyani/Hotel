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
    public partial class Departemen : Form
    {
        string connectionString = "data source =LAPTOP-LE37C152\\MIMITI03;" +
          "database=Hotel;user ID=sa; password=masadepan180423";
        private SqlConnection koneksi;
        public Departemen()
        {
            InitializeComponent();
        }

        private void mENUToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }
    }
}

