using BibitKu.Controllers;
using BibitKu.Helpers;
using PROJEKAKHIR.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PROJEKAKHIR
{
    public partial class TransaksiMasuk : UserControl
    {
        private TransaksiMasukController _controller = new TransaksiMasukController();
        private List<TransaksiMasukModel> _semuaData = new List<TransaksiMasukModel>();

        public TransaksiMasuk()
        {
            InitializeComponent();

            // Event
            this.Load += TransaksiMasuk_Load;
            txtCari.TextChanged += txtCari_TextChanged;
            cmbStatus.SelectedIndexChanged += cmbStatus_Changed;
            dtpDari.ValueChanged += Filter_Changed;
            dtpSampai.ValueChanged += Filter_Changed;
            dgvTransaksi.CellContentClick += dgvTransaksi_CellContentClick;
        }

        private void TransaksiMasuk_Load(object sender, EventArgs e)
        {
            // Set default tanggal
            dtpDari.Value = DateTime.Now.AddMonths(-1);
            dtpSampai.Value = DateTime.Now;

            // Default combobox
            if (cmbStatus.Items.Count > 0)
                cmbStatus.SelectedIndex = 0;

            MuatData();
        }

        private void MuatData()
        {
            try
            {
                int idToko = Session.IdToko;

                string keyword = txtCari.Text.Trim();
                string status = cmbStatus.SelectedItem?.ToString() ?? "Semua Status";
                DateTime dari = dtpDari.Value.Date;
                DateTime sampai = dtpSampai.Value.Date;

                _semuaData = _controller.GetTransaksiMasuk(
                    idToko, dari, sampai, status, keyword);

                TampilkanData(_semuaData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat transaksi: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TampilkanData(List<  TransaksiMasukModel> data)
        {
            dgvTransaksi.Rows.Clear();

            foreach (var item in data)
            {
                int idx = dgvTransaksi.Rows.Add(
                    "TRX-" + item.id_transaksi.ToString("D4"),
                    item.tanggal,
                    item.nama_pembeli,
                    "Rp " + item.total_harga.ToString("N0"),
                    item.metode_pembayaran,
                    item.status_pesanan,
                    "Detail"
                );

                // Warna status
                var row = dgvTransaksi.Rows[idx];
                row.Tag = item;

                Color warna = item.status_pesanan switch
                {
                    "Selesai" => Color.FromArgb(200, 230, 201), // hijau
                    "Diproses" => Color.FromArgb(255, 243, 205), // kuning
                    "Dibatalkan" => Color.FromArgb(255, 205, 210), // merah
                    "Menunggu Pembayaran" => Color.FromArgb(225, 245, 254), // biru
                    _ => Color.White
                };

                row.DefaultCellStyle.BackColor = warna;
                row.DefaultCellStyle.SelectionBackColor = warna;
                row.DefaultCellStyle.SelectionForeColor = Color.Black;
            }

            // Tampilkan pesan jika kosong
            if (data.Count == 0)
            {
                dgvTransaksi.Rows.Add(
                    "-", "-", "Tidak ada transaksi", "-", "-", "-", "-");
            }
        }

        // Klik tombol Detail / aksi di baris
        private void dgvTransaksi_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvTransaksi.Columns[e.ColumnIndex].Name != "colAksi") return;

            var item = dgvTransaksi.Rows[e.RowIndex].Tag as TransaksiMasukModel;
            if (item == null) return;

            // Tampilkan opsi aksi
            var menu = new ContextMenuStrip();

            menu.Items.Add("✅ Konfirmasi Pembayaran (Lunas)", null, (s, ev) =>
            {
                if (item.status_pembayaran == "Lunas")
                {
                    MessageBox.Show("Pembayaran sudah dikonfirmasi.",
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var konfirmasi = MessageBox.Show(
                    $"Konfirmasi pembayaran TRX-{item.id_transaksi:D4}?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (konfirmasi == DialogResult.Yes)
                {
                    _controller.KonfirmasiPembayaran(item.id_transaksi);
                    _controller.UpdateStatusPesanan(item.id_transaksi, "Diproses");
                    MessageBox.Show("Pembayaran dikonfirmasi, status diubah ke Diproses.",
                        "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MuatData();
                }
            });

            menu.Items.Add("📦 Tandai Selesai", null, (s, ev) =>
            {
                var konfirmasi = MessageBox.Show(
                    $"Tandai TRX-{item.id_transaksi:D4} sebagai Selesai?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (konfirmasi == DialogResult.Yes)
                {
                    _controller.UpdateStatusPesanan(item.id_transaksi, "Selesai");
                    MessageBox.Show("Status diubah ke Selesai.",
                        "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MuatData();
                }
            });

            menu.Items.Add("❌ Batalkan Transaksi", null, (s, ev) =>
            {
                var konfirmasi = MessageBox.Show(
                    $"Batalkan TRX-{item.id_transaksi:D4}?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (konfirmasi == DialogResult.Yes)
                {
                    _controller.UpdateStatusPesanan(item.id_transaksi, "Dibatalkan");
                    MessageBox.Show("Transaksi dibatalkan.",
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MuatData();
                }
            });

            // Tampilkan menu di posisi tombol
            var btn = dgvTransaksi.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
            menu.Show(dgvTransaksi, btn.Left, btn.Bottom);
        }

        // Filter events
        private void txtCari_TextChanged(object sender, EventArgs e) => MuatData();
        private void cmbStatus_Changed(object sender, EventArgs e) => MuatData();
        private void Filter_Changed(object sender, EventArgs e) => MuatData();

        private void label1_Click(object sender, EventArgs e) { }
    }
}