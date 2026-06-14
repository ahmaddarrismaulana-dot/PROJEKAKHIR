using Bibitku.Controllers;
using PROJEKAKHIR.Models;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace bibitku_app
{
    public partial class KelolaBibit : UserControl
    {
        // =====================================================
        // ATTRIBUTE
        // =====================================================
        private byte[] fotoBibit;
        private BibitController controller = new BibitController();
        private KategoriController kategoriController = new KategoriController(); // Tambahkan ini

        // =====================================================
        // CONSTRUCTOR
        // =====================================================
        public KelolaBibit()
        {
            InitializeComponent();
        }

        // =====================================================
        // LOAD USERCONTROL
        // =====================================================
        private void KelolaBibit_Load(object sender, EventArgs e)
        {
            LoadKategori(); // Tambahkan ini
            LoadDataBibit();
        }

        // =====================================================
        // LOAD KATEGORI KE COMBOBOX
        // =====================================================
        private void LoadKategori()
        {
            try
            {
                var kategoriList = kategoriController.GetAllKategori();
                cmbKategori.DataSource = kategoriList;
                cmbKategori.DisplayMember = "nama_kategori";
                cmbKategori.ValueMember = "id_kategori";
                cmbKategori.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load kategori: " + ex.Message);
            }
        }

        // =====================================================
        // LOAD DATA KE DATAGRIDVIEW
        // =====================================================
        private void LoadDataBibit()
        {
            try
            {
                dgvBibit.Rows.Clear();
                var data = controller.GetAllBibit();

                foreach (var item in data)
                {
                    // Perbaiki urutan sesuai dengan kolom di DataGridView
                    dgvBibit.Rows.Add(
                        item.id_bibit,           // ID Bibit
                        item.nama_bibit,         // Nama Bibit
                        item.nama_kategori,      // Kategori (gunakan nama_kategori)
                        item.umur_bibit,         // Umur
                        item.harga.ToString("N0"), // Harga
                        item.stok                // Stok
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data: " + ex.Message);
            }
        }

        // =====================================================
        // PILIH GAMBAR
        // =====================================================
        private void btnPilihGambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picBibit.ImageLocation = ofd.FileName;
                fotoBibit = File.ReadAllBytes(ofd.FileName);
            }
        }

        // =====================================================
        // SIMPAN BIBIT
        // =====================================================
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi input
                if (string.IsNullOrWhiteSpace(txtNamaBibit.Text))
                {
                    MessageBox.Show("Nama bibit harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNamaBibit.Focus();
                    return;
                }

                if (cmbKategori.SelectedIndex == -1)
                {
                    MessageBox.Show("Pilih kategori terlebih dahulu!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbKategori.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(textUmurBibit.Text))
                {
                    MessageBox.Show("Umur bibit harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textUmurBibit.Focus();
                    return;
                }

                if (numHarga.Value <= 0)
                {
                    MessageBox.Show("Harga harus lebih dari 0!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numHarga.Focus();
                    return;
                }

                if (numStok.Value < 0)
                {
                    MessageBox.Show("Stok tidak boleh negatif!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numStok.Focus();
                    return;
                }

                Bibit bibit = new Bibit();

                bibit.nama_bibit = txtNamaBibit.Text;

                bibit.id_kategori = new Kategori();
                bibit.id_kategori.id_kategori = Convert.ToInt32(cmbKategori.SelectedValue);

                bibit.id_toko = new Toko();
                bibit.id_toko.id_Toko = 1; // sementara hardcode

                // PERUBAHAN PENTING: Umur bibit sebagai string, bukan Convert.ToInt32
                bibit.umur_bibit = textUmurBibit.Text; // Langsung assign string

                bibit.harga = (int)numHarga.Value;
                bibit.stok = (int)numStok.Value;
                bibit.deskripsi = txtDeskripsi.Text;
                bibit.foto_bibit = fotoBibit;

                bool berhasil = controller.TambahBibit(bibit);

                if (berhasil)
                {
                    MessageBox.Show("Bibit berhasil ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataBibit();
                    BersihkanForm();
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan bibit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // RESET FORM
        // =====================================================
        private void btnReset_Click(object sender, EventArgs e)
        {
            BersihkanForm();
        }

        private void BersihkanForm()
        {
            txtNamaBibit.Clear();
            textUmurBibit.Clear();
            txtDeskripsi.Clear();
            numHarga.Value = 0;
            numStok.Value = 0;
            cmbKategori.SelectedIndex = -1;
            picBibit.Image = null;
            fotoBibit = null;
        }
        // Event handler untuk tombol Reset

        // Event handler untuk tombol Cari
        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                dgvBibit.Rows.Clear();
                var data = controller.CariBibit(txtCari.Text);

                foreach (var item in data)
                {
                    dgvBibit.Rows.Add(
                        item.id_bibit,
                        item.nama_bibit,
                        item.umur_bibit,
                        item.harga.ToString("N0"),
                        item.stok
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mencari data: " + ex.Message);
            }
        }

        // =====================================================
        // EVENT KOSONG (Opsional, bisa dihapus jika tidak digunakan)
        // =====================================================
        private void label1_Click(object sender, EventArgs e) { }
        private void lblDataBibit_Click(object sender, EventArgs e) { }
        private void textUmurBibit_TextChanged(object sender, EventArgs e) { }
        private void picBibit_Click(object sender, EventArgs e) { }
        private void txtIdBibit_TextChanged(object sender, EventArgs e) { }

        private void dgvBibit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}