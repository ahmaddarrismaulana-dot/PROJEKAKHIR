using BibitKu.Controllers;
using BibitKu.Helpers;
using BibitKu.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PROJEKAKHIR
{
    public partial class Keranjang : UserControl
    {
        public Keranjang()
        {
            InitializeComponent();
            btnCheckout.Click += btnCheckout_Click;
        }

        private KeranjangController controller = new KeranjangController();

        private void Keranjang_Load_1(object sender, EventArgs e)
        {
            LoadKeranjang();
        }

        private void LoadKeranjang()
        {
            dgvKeranjang.Rows.Clear();

            Pembeli pembeli = Session.CurrentUser as Pembeli;
            if (pembeli == null) return;

            var daftar = controller.GetKeranjangByUser(pembeli.Id);

            long totalBelanja = 0;
            int no = 1;

            foreach (var item in daftar)
            {
                dgvKeranjang.Rows.Add(
                    no++,
                    item.nama_bibit,
                    "Rp " + item.harga.ToString("N0"),
                    "-",
                    item.jumlah,
                    "+",
                    "Rp " + item.sub_total.ToString("N0"),
                    "Hapus"
                );

                dgvKeranjang.Rows[dgvKeranjang.Rows.Count - 1].Tag = item;
                totalBelanja += item.sub_total;
            }

            lblTotalBelanjaValue.Text = "Rp " + totalBelanja.ToString("N0");
        }

        private void dgvKeranjang_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var item = (PROJEKAKHIR.Models.Keranjang)dgvKeranjang.Rows[e.RowIndex].Tag;
            string namaKolom = dgvKeranjang.Columns[e.ColumnIndex].Name;

            if (namaKolom == "colTambah")
            {
                controller.UpdateJumlah(item.id_keranjang, item.jumlah + 1, item.harga);
                LoadKeranjang();
            }
            else if (namaKolom == "colKurang")
            {
                if (item.jumlah > 1)
                {
                    controller.UpdateJumlah(item.id_keranjang, item.jumlah - 1, item.harga);
                    LoadKeranjang();
                }
            }
            else if (namaKolom == "colHapus")
            {
                var hasil = MessageBox.Show("Hapus item ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (hasil == DialogResult.Yes)
                {
                    controller.HapusItem(item.id_keranjang);
                    LoadKeranjang();
                }
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            // Validasi keranjang tidak kosong
            if (dgvKeranjang.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Keranjang masih kosong!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Ambil data keranjang dari DB
            Pembeli pembeli = Session.CurrentUser as Pembeli;
            if (pembeli == null) return;

            var items = controller.GetKeranjangByUser(pembeli.Id);

            // Kirim ke FormPembeli untuk pindah ke checkout
            var formPembeli = this.FindForm() as FormPembeli;
            if (formPembeli != null)
            {
                formPembeli.PindahKeCheckout(items);
            }
        }
        public void RefreshKeranjang()
        {
            LoadKeranjang();
        }

        // Event handler kosong
        private void dgvKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void Keranjang_Load(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label16_Click(object sender, EventArgs e) { }
        private void label21_Click(object sender, EventArgs e) { }
        private void label21_Click_1(object sender, EventArgs e) { }
    }
}