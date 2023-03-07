
namespace film
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.l_judul = new System.Windows.Forms.Label();
            this.l_genre = new System.Windows.Forms.Label();
            this.l_deskrip = new System.Windows.Forms.Label();
            this.l_durasi = new System.Windows.Forms.Label();
            this.t_judul = new System.Windows.Forms.TextBox();
            this.t_genre = new System.Windows.Forms.TextBox();
            this.t_deskrip = new System.Windows.Forms.TextBox();
            this.t_durasi = new System.Windows.Forms.TextBox();
            this.b_tambah = new System.Windows.Forms.Button();
            this.b_ubah = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.t_id = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.p_image = new System.Windows.Forms.PictureBox();
            this.b_image = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_hapus = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.l_id = new System.Windows.Forms.Label();
            this.t_search = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_harga = new System.Windows.Forms.Label();
            this.t_harga = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_image)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // l_judul
            // 
            this.l_judul.AutoSize = true;
            this.l_judul.Location = new System.Drawing.Point(254, 107);
            this.l_judul.Name = "l_judul";
            this.l_judul.Size = new System.Drawing.Size(35, 15);
            this.l_judul.TabIndex = 1;
            this.l_judul.Text = "Judul";
            // 
            // l_genre
            // 
            this.l_genre.AutoSize = true;
            this.l_genre.Location = new System.Drawing.Point(254, 138);
            this.l_genre.Name = "l_genre";
            this.l_genre.Size = new System.Drawing.Size(38, 15);
            this.l_genre.TabIndex = 2;
            this.l_genre.Text = "Genre";
            // 
            // l_deskrip
            // 
            this.l_deskrip.AutoSize = true;
            this.l_deskrip.Location = new System.Drawing.Point(529, 76);
            this.l_deskrip.Name = "l_deskrip";
            this.l_deskrip.Size = new System.Drawing.Size(54, 15);
            this.l_deskrip.TabIndex = 3;
            this.l_deskrip.Text = "Deskripsi";
            this.l_deskrip.Click += new System.EventHandler(this.l_deskrip_Click);
            // 
            // l_durasi
            // 
            this.l_durasi.AutoSize = true;
            this.l_durasi.Location = new System.Drawing.Point(529, 107);
            this.l_durasi.Name = "l_durasi";
            this.l_durasi.Size = new System.Drawing.Size(40, 15);
            this.l_durasi.TabIndex = 4;
            this.l_durasi.Text = "Durasi";
            // 
            // t_judul
            // 
            this.t_judul.Location = new System.Drawing.Point(337, 104);
            this.t_judul.Name = "t_judul";
            this.t_judul.Size = new System.Drawing.Size(176, 23);
            this.t_judul.TabIndex = 5;
            // 
            // t_genre
            // 
            this.t_genre.Location = new System.Drawing.Point(337, 135);
            this.t_genre.Name = "t_genre";
            this.t_genre.Size = new System.Drawing.Size(176, 23);
            this.t_genre.TabIndex = 6;
            // 
            // t_deskrip
            // 
            this.t_deskrip.Location = new System.Drawing.Point(612, 73);
            this.t_deskrip.Name = "t_deskrip";
            this.t_deskrip.Size = new System.Drawing.Size(176, 23);
            this.t_deskrip.TabIndex = 7;
            // 
            // t_durasi
            // 
            this.t_durasi.Location = new System.Drawing.Point(612, 104);
            this.t_durasi.Name = "t_durasi";
            this.t_durasi.Size = new System.Drawing.Size(176, 23);
            this.t_durasi.TabIndex = 8;
            // 
            // b_tambah
            // 
            this.b_tambah.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.b_tambah.Location = new System.Drawing.Point(61, 203);
            this.b_tambah.Name = "b_tambah";
            this.b_tambah.Size = new System.Drawing.Size(84, 46);
            this.b_tambah.TabIndex = 9;
            this.b_tambah.Text = "Tambah";
            this.b_tambah.UseVisualStyleBackColor = false;
            this.b_tambah.Click += new System.EventHandler(this.b_tambah_Click);
            // 
            // b_ubah
            // 
            this.b_ubah.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.b_ubah.Location = new System.Drawing.Point(61, 270);
            this.b_ubah.Name = "b_ubah";
            this.b_ubah.Size = new System.Drawing.Size(84, 45);
            this.b_ubah.TabIndex = 10;
            this.b_ubah.Text = "Ubah";
            this.b_ubah.UseVisualStyleBackColor = false;
            this.b_ubah.Click += new System.EventHandler(this.b_ubah_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(227, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(724, 341);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // t_id
            // 
            this.t_id.Location = new System.Drawing.Point(337, 73);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(89, 23);
            this.t_id.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(612, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // p_image
            // 
            this.p_image.BackColor = System.Drawing.Color.Lavender;
            this.p_image.Location = new System.Drawing.Point(838, 21);
            this.p_image.Name = "p_image";
            this.p_image.Size = new System.Drawing.Size(97, 109);
            this.p_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_image.TabIndex = 14;
            this.p_image.TabStop = false;
            // 
            // b_image
            // 
            this.b_image.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.b_image.Location = new System.Drawing.Point(838, 134);
            this.b_image.Name = "b_image";
            this.b_image.Size = new System.Drawing.Size(97, 22);
            this.b_image.TabIndex = 15;
            this.b_image.Text = "Browse";
            this.b_image.UseVisualStyleBackColor = false;
            this.b_image.Click += new System.EventHandler(this.b_image_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.b_hapus);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.b_tambah);
            this.panel1.Controls.Add(this.b_ubah);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 524);
            this.panel1.TabIndex = 16;
            // 
            // b_hapus
            // 
            this.b_hapus.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.b_hapus.Location = new System.Drawing.Point(61, 333);
            this.b_hapus.Name = "b_hapus";
            this.b_hapus.Size = new System.Drawing.Size(84, 45);
            this.b_hapus.TabIndex = 11;
            this.b_hapus.Text = "Hapus";
            this.b_hapus.UseVisualStyleBackColor = false;
            this.b_hapus.Click += new System.EventHandler(this.b_hapus_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Location = new System.Drawing.Point(254, 76);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(17, 15);
            this.l_id.TabIndex = 17;
            this.l_id.Text = "Id";
            // 
            // t_search
            // 
            this.t_search.Location = new System.Drawing.Point(640, 25);
            this.t_search.Name = "t_search";
            this.t_search.Size = new System.Drawing.Size(127, 23);
            this.t_search.TabIndex = 18;
            this.t_search.TextChanged += new System.EventHandler(this.t_search_TextChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 42;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Judul";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Genre";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 63;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Deskripsi";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Durasi";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 65;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Image";
            this.Column6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Harga";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 64;
            // 
            // l_harga
            // 
            this.l_harga.AutoSize = true;
            this.l_harga.Location = new System.Drawing.Point(529, 138);
            this.l_harga.Name = "l_harga";
            this.l_harga.Size = new System.Drawing.Size(39, 15);
            this.l_harga.TabIndex = 19;
            this.l_harga.Text = "Harga";
            // 
            // t_harga
            // 
            this.t_harga.Location = new System.Drawing.Point(612, 135);
            this.t_harga.Name = "t_harga";
            this.t_harga.Size = new System.Drawing.Size(176, 23);
            this.t_harga.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 521);
            this.Controls.Add(this.t_harga);
            this.Controls.Add(this.l_harga);
            this.Controls.Add(this.t_search);
            this.Controls.Add(this.l_id);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.b_image);
            this.Controls.Add(this.p_image);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.t_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.t_durasi);
            this.Controls.Add(this.t_deskrip);
            this.Controls.Add(this.t_genre);
            this.Controls.Add(this.t_judul);
            this.Controls.Add(this.l_durasi);
            this.Controls.Add(this.l_deskrip);
            this.Controls.Add(this.l_genre);
            this.Controls.Add(this.l_judul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_image)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label l_judul;
        private System.Windows.Forms.Label l_genre;
        private System.Windows.Forms.Label l_deskrip;
        private System.Windows.Forms.Label l_durasi;
        private System.Windows.Forms.TextBox t_judul;
        private System.Windows.Forms.TextBox t_genre;
        private System.Windows.Forms.TextBox t_deskrip;
        private System.Windows.Forms.TextBox t_durasi;
        private System.Windows.Forms.Button b_tambah;
        private System.Windows.Forms.Button b_ubah;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox p_image;
        private System.Windows.Forms.Button b_image;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b_hapus;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.TextBox t_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label l_harga;
        private System.Windows.Forms.TextBox t_harga;
    }
}

