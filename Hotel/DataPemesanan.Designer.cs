namespace Hotel
{
    partial class DataPemesanan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataPemesanan));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkout = new System.Windows.Forms.DateTimePicker();
            this.chkin = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.tpkmr = new System.Windows.Forms.ComboBox();
            this.idkmr = new System.Windows.Forms.TextBox();
            this.idpgln = new System.Windows.Forms.TextBox();
            this.idpms = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.next = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPelangganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataKamarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPemesananToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkout);
            this.groupBox4.Controls.Add(this.chkin);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.tpkmr);
            this.groupBox4.Controls.Add(this.idkmr);
            this.groupBox4.Controls.Add(this.idpgln);
            this.groupBox4.Controls.Add(this.idpms);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(35, 72);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(343, 277);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data Pemesanan";
            // 
            // chkout
            // 
            this.chkout.Location = new System.Drawing.Point(147, 236);
            this.chkout.Name = "chkout";
            this.chkout.Size = new System.Drawing.Size(146, 26);
            this.chkout.TabIndex = 12;
            this.chkout.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // chkin
            // 
            this.chkin.Location = new System.Drawing.Point(147, 195);
            this.chkin.Name = "chkin";
            this.chkin.Size = new System.Drawing.Size(146, 26);
            this.chkin.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 243);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(132, 16);
            this.label18.TabIndex = 10;
            this.label18.Text = "Tanggal Check Out";
            // 
            // tpkmr
            // 
            this.tpkmr.FormattingEnabled = true;
            this.tpkmr.Items.AddRange(new object[] {
            "P",
            "L"});
            this.tpkmr.Location = new System.Drawing.Point(147, 156);
            this.tpkmr.Name = "tpkmr";
            this.tpkmr.Size = new System.Drawing.Size(146, 24);
            this.tpkmr.TabIndex = 8;
            // 
            // idkmr
            // 
            this.idkmr.Location = new System.Drawing.Point(147, 115);
            this.idkmr.Name = "idkmr";
            this.idkmr.Size = new System.Drawing.Size(146, 26);
            this.idkmr.TabIndex = 6;
            // 
            // idpgln
            // 
            this.idpgln.Location = new System.Drawing.Point(147, 76);
            this.idpgln.Name = "idpgln";
            this.idpgln.Size = new System.Drawing.Size(146, 26);
            this.idpgln.TabIndex = 5;
            // 
            // idpms
            // 
            this.idpms.Location = new System.Drawing.Point(147, 29);
            this.idpms.Name = "idpms";
            this.idpms.Size = new System.Drawing.Size(146, 26);
            this.idpms.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "Tipe Kamar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "ID Kamar";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "ID Pelanggan";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "ID Pemesanan";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 202);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 16);
            this.label17.TabIndex = 9;
            this.label17.Text = "Tanggal Chek In";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(384, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(293, 165);
            this.dataGridView1.TabIndex = 21;
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(536, 319);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 31;
            this.next.Text = "NEXT";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(419, 319);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 30;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(384, 274);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 29;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(482, 274);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 28;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(578, 274);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 27;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Palatino Linotype", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(199, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(251, 63);
            this.label21.TabIndex = 33;
            this.label21.Text = "HOTEL TI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(481, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
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
            this.dataPegawaiToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.dataPegawaiToolStripMenuItem.Text = "Data Pegawai";
            this.dataPegawaiToolStripMenuItem.Click += new System.EventHandler(this.dataPegawaiToolStripMenuItem_Click);
            // 
            // dataPelangganToolStripMenuItem
            // 
            this.dataPelangganToolStripMenuItem.Name = "dataPelangganToolStripMenuItem";
            this.dataPelangganToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.dataPelangganToolStripMenuItem.Text = "Data Pelanggan";
            this.dataPelangganToolStripMenuItem.Click += new System.EventHandler(this.dataPelangganToolStripMenuItem_Click);
            // 
            // dataKamarToolStripMenuItem
            // 
            this.dataKamarToolStripMenuItem.Name = "dataKamarToolStripMenuItem";
            this.dataKamarToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.dataKamarToolStripMenuItem.Text = "Data Kamar";
            this.dataKamarToolStripMenuItem.Click += new System.EventHandler(this.dataKamarToolStripMenuItem_Click);
            // 
            // dataPemesananToolStripMenuItem
            // 
            this.dataPemesananToolStripMenuItem.Name = "dataPemesananToolStripMenuItem";
            this.dataPemesananToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.dataPemesananToolStripMenuItem.Text = "Data Pemesanan";
            this.dataPemesananToolStripMenuItem.Click += new System.EventHandler(this.dataPemesananToolStripMenuItem_Click);
            // 
            // dataTransaksiToolStripMenuItem
            // 
            this.dataTransaksiToolStripMenuItem.Name = "dataTransaksiToolStripMenuItem";
            this.dataTransaksiToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.dataTransaksiToolStripMenuItem.Text = "Data Transaksi";
            this.dataTransaksiToolStripMenuItem.Click += new System.EventHandler(this.dataTransaksiToolStripMenuItem_Click);
            // 
            // DataPemesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Name = "DataPemesanan";
            this.Text = "Data Pemesanan";
            this.Load += new System.EventHandler(this.DataPemesanan_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker chkout;
        private System.Windows.Forms.DateTimePicker chkin;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox tpkmr;
        private System.Windows.Forms.TextBox idkmr;
        private System.Windows.Forms.TextBox idpgln;
        private System.Windows.Forms.TextBox idpms;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPelangganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataKamarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPemesananToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTransaksiToolStripMenuItem;
    }
}