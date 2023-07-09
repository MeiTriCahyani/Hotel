namespace Hotel
{
    partial class DataPelanggan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataPelanggan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jk = new System.Windows.Forms.ComboBox();
            this.nohp = new System.Windows.Forms.TextBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.idplg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPelangganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataKamarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPemesananToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pelanggan = new System.Windows.Forms.DataGridView();
            this.next = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelanggan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.jk);
            this.groupBox1.Controls.Add(this.nohp);
            this.groupBox1.Controls.Add(this.nama);
            this.groupBox1.Controls.Add(this.idplg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 193);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Pelanggan";
            // 
            // jk
            // 
            this.jk.FormattingEnabled = true;
            this.jk.Items.AddRange(new object[] {
            "P",
            "L"});
            this.jk.Location = new System.Drawing.Point(119, 158);
            this.jk.Name = "jk";
            this.jk.Size = new System.Drawing.Size(158, 24);
            this.jk.TabIndex = 8;
            // 
            // nohp
            // 
            this.nohp.Location = new System.Drawing.Point(119, 116);
            this.nohp.Name = "nohp";
            this.nohp.Size = new System.Drawing.Size(158, 26);
            this.nohp.TabIndex = 6;
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(119, 73);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(158, 26);
            this.nama.TabIndex = 5;
            // 
            // idplg
            // 
            this.idplg.AllowDrop = true;
            this.idplg.Location = new System.Drawing.Point(119, 32);
            this.idplg.Name = "idplg";
            this.idplg.Size = new System.Drawing.Size(158, 26);
            this.idplg.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nomor HP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Pelanggan";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(211, 352);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(76, 23);
            this.add.TabIndex = 17;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button3_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(344, 352);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 16;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(475, 352);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 15;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(258, 395);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "EXIT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.hOMEToolStripMenuItem.Text = "HOME";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataPegawaiToolStripMenuItem,
            this.dataPelangganToolStripMenuItem,
            this.dataKamarToolStripMenuItem,
            this.dataPemesananToolStripMenuItem,
            this.dataTransaksiToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menuToolStripMenuItem.Text = "MENU";
            // 
            // dataPegawaiToolStripMenuItem
            // 
            this.dataPegawaiToolStripMenuItem.Name = "dataPegawaiToolStripMenuItem";
            this.dataPegawaiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataPegawaiToolStripMenuItem.Text = "Data Pegawai";
            this.dataPegawaiToolStripMenuItem.Click += new System.EventHandler(this.dataPegawaiToolStripMenuItem_Click);
            // 
            // dataPelangganToolStripMenuItem
            // 
            this.dataPelangganToolStripMenuItem.Name = "dataPelangganToolStripMenuItem";
            this.dataPelangganToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataPelangganToolStripMenuItem.Text = "Data Pelanggan";
            this.dataPelangganToolStripMenuItem.Click += new System.EventHandler(this.dataPelangganToolStripMenuItem_Click);
            // 
            // dataKamarToolStripMenuItem
            // 
            this.dataKamarToolStripMenuItem.Name = "dataKamarToolStripMenuItem";
            this.dataKamarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataKamarToolStripMenuItem.Text = "Data Kamar";
            this.dataKamarToolStripMenuItem.Click += new System.EventHandler(this.dataKamarToolStripMenuItem_Click);
            // 
            // dataPemesananToolStripMenuItem
            // 
            this.dataPemesananToolStripMenuItem.Name = "dataPemesananToolStripMenuItem";
            this.dataPemesananToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataPemesananToolStripMenuItem.Text = "Data Pemesanan";
            this.dataPemesananToolStripMenuItem.Click += new System.EventHandler(this.dataPemesananToolStripMenuItem_Click);
            // 
            // dataTransaksiToolStripMenuItem
            // 
            this.dataTransaksiToolStripMenuItem.Name = "dataTransaksiToolStripMenuItem";
            this.dataTransaksiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataTransaksiToolStripMenuItem.Text = "Data Transaksi";
            this.dataTransaksiToolStripMenuItem.Click += new System.EventHandler(this.dataTransaksiToolStripMenuItem_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Palatino Linotype", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(241, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(251, 63);
            this.label21.TabIndex = 37;
            this.label21.Text = "HOTEL TI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(523, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pelanggan
            // 
            this.pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pelanggan.Location = new System.Drawing.Point(385, 124);
            this.pelanggan.Name = "pelanggan";
            this.pelanggan.Size = new System.Drawing.Size(380, 182);
            this.pelanggan.TabIndex = 38;
            this.pelanggan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(417, 395);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 39;
            this.next.Text = "NEXT";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // DataPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(872, 560);
            this.Controls.Add(this.next);
            this.Controls.Add(this.pelanggan);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.add);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.save);
            this.Controls.Add(this.groupBox1);
            this.Name = "DataPelanggan";
            this.Text = "Data Pelanggan";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelanggan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox jk;
        private System.Windows.Forms.TextBox nohp;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.TextBox idplg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPelangganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataKamarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPemesananToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTransaksiToolStripMenuItem;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView pelanggan;
        private System.Windows.Forms.Button next;
    }
}