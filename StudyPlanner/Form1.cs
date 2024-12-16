using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyPlanner
{
    // Enumerasi hari belajar
    public enum HariBelajar
    {
        Senin,
        Selasa,
        Rabu,
        Kamis,
        Jumat,
        Sabtu,
        Minggu
    }

    public partial class Form1 : Form
    {
        // Konstanta maksimal untuk durasi belajar 2 jam
        private const int MAX_DURASI = 120;
        public Form1()
        {
            InitializeComponent();
            // Menambahkan event handler untuk FormClosing
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Menampilkan konfirmasi sebelum menutup aplikasi
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Jika pengguna memilih No, batalkan penutupan aplikasi
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HariCmb.DataSource = Enum.GetValues(typeof(HariBelajar));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TambahJadwal_Click(object sender, EventArgs e)
        {
            // Validasi input
            if (string.IsNullOrWhiteSpace(MapelTxt.Text))
            {
                MessageBox.Show("Mata pelajaran tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (HariCmb.SelectedItem == null)
            {
                MessageBox.Show("Pilih hari belajar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tampilkan pesan saat tombol 'Tambah Jadwal' ditekan
            MessageBox.Show("Tombol 'Tambah Jadwal' ditekan!");

            // Ambil data dari form
            HariBelajar hari = (HariBelajar)HariCmb.SelectedItem;  // Mengonversi ComboBox ke enum HariBelajar
            string mataPelajaran = MapelTxt.Text;
            int durasi = (int)DurasiNum.Value;

            // Validasi total durasi hari ini
            int totalDurasiHariIni = 0;
            foreach (DataGridViewRow row in JadwalDgv.Rows)
            {
                if (row.Cells[0].Value?.ToString() == hari.ToString()) // Jika hari sama
                {
                    totalDurasiHariIni += Convert.ToInt32(row.Cells[2].Value); // Menjumlahkan durasi
                }
            }

            // Cek apakah total durasi tidak melebihi 2 jam
            if (totalDurasiHariIni + durasi > MAX_DURASI)
            {
                // Jika durasi lebih dari 120 menit
                MessageBox.Show("Durasi total belajar tidak boleh melebihi 2 jam.");
            }
            else
            {
                // Menambahkan data ke DataGridView jika validasi lolos
                JadwalDgv.Rows.Add(hari.ToString(), mataPelajaran, durasi);  // Menggunakan hari.ToString() untuk menampilkan nama hari

                // Reset input setelah menambahkan
                MapelTxt.Clear();
                HariCmb.SelectedIndex = -1;
                DurasiNum.Value = 0;

                // Tampilkan pesan bahwa jadwal berhasil ditambahkan
                MessageBox.Show("Jadwal berhasil ditambahkan!");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV files|*.csv", Title = "Save Jadwal" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        // Tulis header
                        sw.WriteLine("Hari,Mata Pelajaran,Durasi (Menit)");

                        // Tulis data
                        foreach (DataGridViewRow row in JadwalDgv.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                sw.WriteLine($"{row.Cells[0].Value},{row.Cells[1].Value},{row.Cells[2].Value}");
                            }
                        }
                    }
                    MessageBox.Show("Jadwal berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void JadwalDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HariCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DurasiNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Memilih baris yang ingin dihapus
            if (JadwalDgv.SelectedRows.Count > 0)
            {
                // Menghapus baris yang dipilih
                foreach (DataGridViewRow row in JadwalDgv.SelectedRows)
                {
                    JadwalDgv.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                // Jika tidak ada baris yang dipilih, tampilkan pesan
                MessageBox.Show("Pilih jadwal yang ingin dihapus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
