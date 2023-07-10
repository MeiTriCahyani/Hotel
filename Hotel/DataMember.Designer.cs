namespace Hotel
{
    partial class Membre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Membre));
            this.next = new System.Windows.Forms.Button();
            this.memberview = new System.Windows.Forms.DataGridView();
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
            this.button4 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.member1 = new System.Windows.Forms.GroupBox();
            this.jm = new System.Windows.Forms.ComboBox();
            this.idplgm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.memberview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.member1.SuspendLayout();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(417, 334);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 48;
            this.next.Text = "NEXT";
            this.next.UseVisualStyleBackColor = true;
            // 
            // memberview
            // 
            this.memberview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberview.Location = new System.Drawing.Point(344, 149);
            this.memberview.Name = "memberview";
            this.memberview.Size = new System.Drawing.Size(308, 115);
            this.memberview.TabIndex = 47;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Palatino Linotype", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(241, 44);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(251, 63);
            this.label21.TabIndex = 46;
            this.label21.Text = "HOTEL TI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(523, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
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
            this.menuStrip1.TabIndex = 44;
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
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // dataPegawaiToolStripMenuItem
            // 
            this.dataPegawaiToolStripMenuItem.Name = "dataPegawaiToolStripMenuItem";
            this.dataPegawaiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataPegawaiToolStripMenuItem.Text = "Data Pegawai";
            // 
            // dataPelangganToolStripMenuItem
            // 
            this.dataPelangganToolStripMenuItem.Name = "dataPelangganToolStripMenuItem";
            this.dataPelangganToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataPelangganToolStripMenuItem.Text = "Data Pelanggan";
            // 
            // dataKamarToolStripMenuItem
            // 
            this.dataKamarToolStripMenuItem.Name = "dataKamarToolStripMenuItem";
            this.dataKamarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataKamarToolStripMenuItem.Text = "Data Kamar";
            // 
            // dataPemesananToolStripMenuItem
            // 
            this.dataPemesananToolStripMenuItem.Name = "dataPemesananToolStripMenuItem";
            this.dataPemesananToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataPemesananToolStripMenuItem.Text = "Data Pemesanan";
            // 
            // dataTransaksiToolStripMenuItem
            // 
            this.dataTransaksiToolStripMenuItem.Name = "dataTransaksiToolStripMenuItem";
            this.dataTransaksiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataTransaksiToolStripMenuItem.Text = "Data Transaksi";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(258, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 43;
            this.button4.Text = "EXIT";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(211, 291);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(76, 23);
            this.add.TabIndex = 42;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(344, 291);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 41;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(475, 291);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 40;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = true;
            // 
            // member1
            // 
            this.member1.Controls.Add(this.jm);
            this.member1.Controls.Add(this.idplgm);
            this.member1.Controls.Add(this.label4);
            this.member1.Controls.Add(this.label1);
            this.member1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member1.Location = new System.Drawing.Point(12, 140);
            this.member1.Name = "member1";
            this.member1.Size = new System.Drawing.Size(308, 124);
            this.member1.TabIndex = 49;
            this.member1.TabStop = false;
            this.member1.Text = "Data Member";
            // 
            // jm
            // 
            this.jm.FormattingEnabled = true;
            this.jm.Items.AddRange(new object[] {
            "P",
            "L"});
            this.jm.Location = new System.Drawing.Point(119, 79);
            this.jm.Name = "jm";
            this.jm.Size = new System.Drawing.Size(158, 24);
            this.jm.TabIndex = 8;
            // 
            // idplgm
            // 
            this.idplgm.AllowDrop = true;
            this.idplgm.Location = new System.Drawing.Point(119, 32);
            this.idplgm.Name = "idplgm";
            this.idplgm.Size = new System.Drawing.Size(158, 26);
            this.idplgm.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jenis Member";
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
            // Membre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.member1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.memberview);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.add);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.save);
            this.Name = "Membre";
            this.Text = "Data Member";
            this.Load += new System.EventHandler(this.Membre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.member1.ResumeLayout(false);
            this.member1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next;
        private System.Windows.Forms.DataGridView memberview;
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.GroupBox member1;
        private System.Windows.Forms.ComboBox jm;
        private System.Windows.Forms.TextBox idplgm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}