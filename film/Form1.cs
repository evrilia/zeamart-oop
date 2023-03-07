using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace film
{
    public partial class Form1 : Form
    {
        int i = 0;

        MySqlConnection koneksi = Connections.getConnection();
        DataTable dataTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        public DataTable getDataFilm()
        {
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM film", koneksi))
            {
                koneksi.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;
        }

        public void filldataTable()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowTemplate.Height = 200;
            dataGridView1.DataSource = getDataFilm();
            Column1.DataPropertyName = "id";
            Column2.DataPropertyName = "judul";
            Column3.DataPropertyName = "genre";
            Column4.DataPropertyName = "deskripsi";
            Column5.DataPropertyName = "durasi";
            Column6.DataPropertyName = "image";
            Column7.DataPropertyName = "harga";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filldataTable();
        }

        public void resetIncrement()
        {
            MySqlScript script = new MySqlScript(koneksi, "SET @id :=0; Update film SET id = @id := (@id+1); " +
                "ALTER TABLE film AUTO_INCREMENT = 1;");
            script.Execute();
        }

        public void searchData(string ValueToFind)
        {
            string searchQuery = "SELECT * FROM film WHERE CONCAT (judul, genre, deskripsi, durasi, harga) LIKE '%" + ValueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, koneksi);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void b_image_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openimage = new OpenFileDialog();
            if (openimage.ShowDialog() == DialogResult.OK)
            {
                p_image.Image = new Bitmap(openimage.FileName);
                p_image.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void t_search_TextChanged(object sender, EventArgs e)
        {
                searchData(t_search.Text);
        }

        private void b_tambah_Click(object sender, EventArgs e)
        {
            // Convert image to byte array
            byte[] imageData;
            using (MemoryStream ms = new MemoryStream())
            {
                p_image.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageData = ms.ToArray();
            }
            MySqlCommand cmd;

            try
            {
                resetIncrement();

                cmd = koneksi.CreateCommand();
                cmd.CommandText = "insert into film(judul, genre, deskripsi, durasi, image, harga) VALUE (@judul, @genre, @deskrip, @durasi, @image, @harga)";
                cmd.Parameters.AddWithValue("@judul", t_judul.Text);
                cmd.Parameters.AddWithValue("@genre", t_genre.Text);
                cmd.Parameters.AddWithValue("@deskrip", t_deskrip.Text);
                cmd.Parameters.AddWithValue("@durasi", t_durasi.Text);
                cmd.Parameters.AddWithValue("@image", imageData);
                cmd.Parameters.AddWithValue("@harga", t_harga.Text);

                cmd.ExecuteNonQuery();
                koneksi.Close();
                dataTable.Clear();
                filldataTable();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error karena = " + ex);
            }
        }

        private void b_ubah_Click(object sender, EventArgs e)
        {
            // Convert image to byte array
            MemoryStream ms = new MemoryStream();
            p_image.Image.Save(ms, p_image.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand cmd;
            // mengecek apakah ada field yang kosong
            if ((t_id.Text == string.Empty || t_judul.Text == string.Empty || t_deskrip.Text == string.Empty || t_durasi.Text == string.Empty || t_harga.Text == string.Empty))
            {
                MessageBox.Show("Tolong Isi Semua Field!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "UPDATE film SET judul=@judul,genre=@genre,deskripsi=@deskrip,durasi=@durasi,image=@image,harga=@harga where id=@id";
                cmd.Parameters.AddWithValue("@id", t_id.Text);
                cmd.Parameters.AddWithValue("@judul", t_judul.Text);
                cmd.Parameters.AddWithValue("@genre", t_genre.Text);
                cmd.Parameters.AddWithValue("@deskrip", t_deskrip.Text);
                cmd.Parameters.AddWithValue("@durasi", t_durasi.Text);
                cmd.Parameters.AddWithValue("@image", img);
                cmd.Parameters.AddWithValue("@harga", t_harga.Text);
                cmd.ExecuteNonQuery();
                //
                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Data Berhasil Diupdate!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data Gagal Diupdate!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                koneksi.Close();
                filldataTable();
            }
        }

        private void b_hapus_Click(object sender, EventArgs e)
        {
            resetIncrement();
            int id = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());

            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "DELETE FROM `film` WHERE id=@id";
            cmd.Parameters.AddWithValue("@id", t_id.Text);
            i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Data Berhasil Dihapus!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Gagal Dihapus!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            koneksi.Close();
            filldataTable();
        }


        private void l_deskrip_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());
            t_id.Text = dataGridView1.Rows[id].Cells[0].Value.ToString();
            t_judul.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
            t_genre.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
            t_deskrip.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();
            t_durasi.Text = dataGridView1.Rows[id].Cells[4].Value.ToString();
            t_harga.Text = dataGridView1.Rows[id].Cells[6].Value.ToString();

            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(img);
            p_image.Image = Image.FromStream(ms);
        }
    }
}
