using BibitKu.Controllers;
using BibitKu.Helpers;
using BibitKu.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PROJEKAKHIR
{
    public partial class RiwayatTransaksi : UserControl
    {
        private RiwayatTransaksiController _controller = new RiwayatTransaksiController();
        private List<RiwayatTransaksiModel> _semuaData = new List<RiwayatTransaksiModel>();
        private string _filterAktif = "Semua";

        public RiwayatTransaksi()
        {
            InitializeComponent();

            this.Load += RiwayatTransaksi_Load;

            // Tombol filter
            btnSemua.Click += (s, e) => SetFilter("Semua", btnSemua);
            btnSelesai.Click += (s, e) => SetFilter("Selesai", btnSelesai);
            btnDiproses.Click += (s, e) => SetFilter("Diproses", btnDiproses);
            btnDibatalkan.Click += (s, e) => SetFilter("Dibatalkan", btnDibatalkan);

            // Klik detail
            dgvRiwayat.CellContentClick += dgvRiwayat_CellContentClick;
        }

        private void RiwayatTransaksi_Load(object sender, EventArgs e)
        {
            MuatData();
        }

        // Dipanggil saat panel ini ditampilkan (refresh otomatis)
        public void RefreshData()
        {
            MuatData();
        }

        private void MuatData()
        {
            try
            {
                var pembeli = Session.CurrentUser as Pembeli;
                if (pembeli == null) return;

                _semuaData = _controller.GetRiwayatByUser(
                    pembeli.Id, _filterAktif);

                TampilkanData(_semuaData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat riwayat: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TampilkanData(List<RiwayatTransaksiModel> data)
        {
            dgvRiwayat.Rows.Clear();

            if (data.Count == 0)
            {
                dgvRiwayat.Rows.Add("-", "-", "Tidak ada transaksi", "-", "-");
                return;
            }

            foreach (var item in data)
            {
                int idx = dgvRiwayat.Rows.Add(
                    "TRX-" + item.id_transaksi.ToString("D4"),
                    item.tanggal,
                    "Rp " + item.total_harga.ToString("N0"),
                    item.status_pesanan,
                    "Detail"
                );

                var row = dgvRiwayat.Rows[idx];
                row.Tag = item;

                // Warna baris sesuai status
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
        }

        // Klik tombol Detail di baris
        private void dgvRiwayat_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvRiwayat.Columns[e.ColumnIndex].Name != "colAksi") return;

            var item = dgvRiwayat.Rows[e.RowIndex].Tag as RiwayatTransaksiModel;
            if (item == null) return;

            // Ambil detail item transaksi
            var detailItems = _controller.GetDetailTransaksi(item.id_transaksi);

            string detailText = string.Join("\n", detailItems);

            MessageBox.Show(
                $"ID Transaksi  : TRX-{item.id_transaksi:D4}\n" +
                $"Tanggal       : {item.tanggal}\n" +
                $"Metode Bayar  : {item.metode_pembayaran}\n" +
                $"Status Bayar  : {item.status_pembayaran}\n" +
                $"Status Pesanan: {item.status_pesanan}\n" +
                $"Total         : Rp {item.total_harga:N0}\n\n" +
                $"─────────────────────────\n" +
                $"Detail Produk:\n{detailText}",
                $"Detail Transaksi TRX-{item.id_transaksi:D4}",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Ganti filter aktif dan update tampilan tombol
        private void SetFilter(string filter, Button btnAktif)
        {
            _filterAktif = filter;

            // Reset semua tombol
            foreach (Button btn in new[] { btnSemua, btnSelesai, btnDiproses, btnDibatalkan })
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.FromArgb(60, 60, 60);
                btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            }

            // Aktifkan tombol yang dipilih
            btnAktif.BackColor = Color.ForestGreen;
            btnAktif.ForeColor = Color.White;
            btnAktif.Font = new System.Drawing.Font(
                "Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            MuatData();
        }
    }
}