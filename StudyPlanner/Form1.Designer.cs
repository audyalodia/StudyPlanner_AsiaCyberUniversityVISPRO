namespace StudyPlanner
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HariCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MapelTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DurasiNum = new System.Windows.Forms.NumericUpDown();
            this.TambahJadwal = new System.Windows.Forms.Button();
            this.JadwalDgv = new System.Windows.Forms.DataGridView();
            this.ColHari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMapel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDurasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.HapusJadwal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DurasiNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JadwalDgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // HariCmb
            // 
            this.HariCmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(200)))), ((int)(((byte)(208)))));
            this.HariCmb.Font = new System.Drawing.Font("Century Gothic", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HariCmb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(21)))), ((int)(((byte)(53)))));
            this.HariCmb.FormattingEnabled = true;
            this.HariCmb.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.HariCmb.Location = new System.Drawing.Point(260, 378);
            this.HariCmb.Name = "HariCmb";
            this.HariCmb.Size = new System.Drawing.Size(121, 24);
            this.HariCmb.TabIndex = 0;
            this.HariCmb.SelectedIndexChanged += new System.EventHandler(this.HariCmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(200)))), ((int)(((byte)(208)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(117, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mata Pelajaran:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MapelTxt
            // 
            this.MapelTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(200)))), ((int)(((byte)(208)))));
            this.MapelTxt.Font = new System.Drawing.Font("Century Gothic", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapelTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(21)))), ((int)(((byte)(53)))));
            this.MapelTxt.Location = new System.Drawing.Point(260, 330);
            this.MapelTxt.Name = "MapelTxt";
            this.MapelTxt.Size = new System.Drawing.Size(121, 23);
            this.MapelTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(200)))), ((int)(((byte)(208)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(207, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hari: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(200)))), ((int)(((byte)(208)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(91)))));
            this.label3.Location = new System.Drawing.Point(188, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Durasi:";
            // 
            // DurasiNum
            // 
            this.DurasiNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(200)))), ((int)(((byte)(208)))));
            this.DurasiNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(21)))), ((int)(((byte)(53)))));
            this.DurasiNum.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.DurasiNum.Location = new System.Drawing.Point(261, 423);
            this.DurasiNum.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.DurasiNum.Name = "DurasiNum";
            this.DurasiNum.Size = new System.Drawing.Size(120, 23);
            this.DurasiNum.TabIndex = 5;
            this.DurasiNum.ValueChanged += new System.EventHandler(this.DurasiNum_ValueChanged);
            // 
            // TambahJadwal
            // 
            this.TambahJadwal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(200)))), ((int)(((byte)(208)))));
            this.TambahJadwal.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TambahJadwal.Location = new System.Drawing.Point(193, 477);
            this.TambahJadwal.Name = "TambahJadwal";
            this.TambahJadwal.Size = new System.Drawing.Size(131, 27);
            this.TambahJadwal.TabIndex = 6;
            this.TambahJadwal.Text = "Tambah Jadwal";
            this.TambahJadwal.UseVisualStyleBackColor = false;
            this.TambahJadwal.Click += new System.EventHandler(this.TambahJadwal_Click);
            // 
            // JadwalDgv
            // 
            this.JadwalDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.JadwalDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JadwalDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColHari,
            this.ColMapel,
            this.ColDurasi});
            this.JadwalDgv.Location = new System.Drawing.Point(482, 71);
            this.JadwalDgv.Name = "JadwalDgv";
            this.JadwalDgv.RowHeadersWidth = 51;
            this.JadwalDgv.RowTemplate.Height = 24;
            this.JadwalDgv.Size = new System.Drawing.Size(430, 614);
            this.JadwalDgv.TabIndex = 7;
            this.JadwalDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.JadwalDgv_CellContentClick);
            // 
            // ColHari
            // 
            this.ColHari.HeaderText = "Hari";
            this.ColHari.MinimumWidth = 6;
            this.ColHari.Name = "ColHari";
            this.ColHari.Width = 125;
            // 
            // ColMapel
            // 
            this.ColMapel.HeaderText = "Mata Pelajaran";
            this.ColMapel.MinimumWidth = 6;
            this.ColMapel.Name = "ColMapel";
            this.ColMapel.Width = 125;
            // 
            // ColDurasi
            // 
            this.ColDurasi.HeaderText = "Durasi";
            this.ColDurasi.MinimumWidth = 6;
            this.ColDurasi.Name = "ColDurasi";
            this.ColDurasi.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(943, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(52, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 107);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(437, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 90);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(445, 643);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 75);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(23, 229);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(430, 364);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // HapusJadwal
            // 
            this.HapusJadwal.Location = new System.Drawing.Point(797, 41);
            this.HapusJadwal.Name = "HapusJadwal";
            this.HapusJadwal.Size = new System.Drawing.Size(115, 23);
            this.HapusJadwal.TabIndex = 13;
            this.HapusJadwal.Text = "Hapus Jadwal";
            this.HapusJadwal.UseVisualStyleBackColor = true;
            this.HapusJadwal.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(943, 720);
            this.Controls.Add(this.HapusJadwal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.JadwalDgv);
            this.Controls.Add(this.TambahJadwal);
            this.Controls.Add(this.DurasiNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MapelTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HariCmb);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(21)))), ((int)(((byte)(53)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DurasiNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JadwalDgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox HariCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MapelTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown DurasiNum;
        private System.Windows.Forms.Button TambahJadwal;
        private System.Windows.Forms.DataGridView JadwalDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHari;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMapel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDurasi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button HapusJadwal;
    }
}

