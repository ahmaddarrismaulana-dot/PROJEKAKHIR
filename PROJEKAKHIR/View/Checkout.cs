using BibitKu.Controllers;
using BibitKu.Helpers;
using BibitKu.Models;
using PROJEKAKHIR.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PROJEKAKHIR
{
    public partial class Checkout : UserControl
    {
        private List<PROJEKAKHIR.Models.Keranjang> _itemsKeranjang;
        private byte[] _buktiBayar;
        private CheckoutController _controller = new CheckoutController();

        public Checkout()
        {
            InitializeComponent();
        }

        // Dipanggil dari FormPembeli
        public void LoadDataCheckout(List<PROJEKAKHIR.Models.Keranjang> daftarKeranjang)
        {
            _itemsKeranjang = daftarKeranjang;

            dgvPesanan.Rows.Clear();
            long total = 0;

            foreach (var item in daftarKeranjang)
            {
                dgvPesanan.Rows.Add(
                    item.nama_bibit,
                    item.jumlah,
                    "Rp " + item.sub_total.ToString("N0")
                );
                total += item.sub_total;
            }

            lblTotalVal.Text = "Rp " + total.ToString("N0");
            txtTotalBayar.Text = "Rp " + total.ToString("N0");

            // Isi data user dari session
            var pembeli = Session.CurrentUser as Pembeli;
            if (pembeli != null)
            {
                txtNama.Text = pembeli.Nama;
                txtAlamat.Text = pembeli.Alamat;
            }

            // Combobox default
            if (cmbMetodePembayaran.Items.Count > 0)
                cmbMetodePembayaran.SelectedIndex = 0;
            if (cmbBankTujuan.Items.Count > 0)
                cmbBankTujuan.SelectedIndex = 0;

            // Reset bukti bayar
            _buktiBayar = null;
            picUploadIcon.Image = null;
            lblUploadFormat.Text = "Format: JPG, PNG (Maks. 2MB)";
            lblUploadFormat.ForeColor = Color.FromArgb(130, 130, 130);
        }

        private void btnPilihGambar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                ofd.Title = "Pilih Bukti Pembayaran";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(ofd.FileName);

                    if (fi.Length > 2 * 1024 * 1024)
                    {
                        MessageBox.Show(
                            "Ukuran file maksimal 2MB.",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    _buktiBayar = File.ReadAllBytes(ofd.FileName);

                    picUploadIcon.Image = Image.FromFile(ofd.FileName);
                    picUploadIcon.SizeMode = PictureBoxSizeMode.Zoom;

                    lblUploadFormat.Text = "✔ " + fi.Name;
                    lblUploadFormat.ForeColor = Color.ForestGreen;
                }
            }
        }

        private void btnLanjut_Click(object sender, EventArgs e)
        {
            // Validasi
            if (_itemsKeranjang == null || _itemsKeranjang.Count == 0)
            {
                MessageBox.Show(
                    "Tidak ada item untuk di-checkout.\nSilakan tambah item ke keranjang terlebih dahulu.",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbMetodePembayaran.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Pilih metode pembayaran terlebih dahulu.",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAlamat.Text))
            {
                MessageBox.Show(
                    "Isi alamat pengiriman terlebih dahulu.",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pembeli = Session.CurrentUser as Pembeli;
            if (pembeli == null) return;

            string metode = cmbMetodePembayaran.SelectedItem.ToString();
            string bank = cmbBankTujuan.SelectedItem?.ToString() ?? "-";

            try
            {
                int idTransaksi;
                bool berhasil = _controller.ProsesCheckout(
                    pembeli.Id,
                    _itemsKeranjang,
                    metode,
                    bank,
                    _buktiBayar,
                    txtAlamat.Text,
                    out idTransaksi
                );

                if (berhasil)
                {
                    MessageBox.Show(
                        $"Checkout berhasil!\n" +
                        $"ID Transaksi: TRX-{idTransaksi:D4}\n" +
                        $"Total: {txtTotalBayar.Text}\n\n" +
                        "Silakan tunggu konfirmasi penjual.",
                        "Sukses",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal checkout: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            dgvPesanan.Rows.Clear();
            lblTotalVal.Text = "Rp 0";
            txtTotalBayar.Text = "Rp 0";
            txtNama.Text = "";
            txtAlamat.Clear();
            _itemsKeranjang = null;
            _buktiBayar = null;
            picUploadIcon.Image = null;
            lblUploadFormat.Text = "Format: JPG, PNG (Maks. 2MB)";
            lblUploadFormat.ForeColor = Color.FromArgb(130, 130, 130);
        }

        // Event handler kosong
        private void lblAlamat_Click(object sender, EventArgs e) { }
        private void txtAlamat_TextChanged(object sender, EventArgs e) { }
        private void txtTotalBayar_TextChanged(object sender, EventArgs e) { }
        private void cmbMetodePembayaran_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbBankTujuan_SelectedIndexChanged(object sender, EventArgs e) { }
        private void pnlUpload_Paint(object sender, PaintEventArgs e) { }
        private void picUploadIcon_Click(object sender, EventArgs e) { }
        private void lblUploadFormat_Click(object sender, EventArgs e) { }
        private void dgvPesanan_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lblTransaksi_Click(object sender, EventArgs e) { }
        private void txtNama_TextChanged(object sender, EventArgs e) { }

        // ⚠️ Ini tetap ada karena ada di Designer
        private void txtIDTransaksi_TextChanged(object sender, EventArgs e) { }
    }
}