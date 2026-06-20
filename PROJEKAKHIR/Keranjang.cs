using BibitKu.Controllers;
using BibitKu.Helpers;
using BibitKu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROJEKAKHIR
{
    public partial class Keranjang : UserControl
    {
        public Keranjang()
        {
            InitializeComponent();
        }
        private KeranjangController controller =
    new KeranjangController();
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Keranjang_Load(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKeranjang_CellContentClick_1(
     object sender,
     DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var item =
                (PROJEKAKHIR.Models.Keranjang)
                dgvKeranjang.Rows[e.RowIndex].Tag;

            string namaKolom =
                dgvKeranjang.Columns[e.ColumnIndex].Name;

            // =====================
            // TAMBAH JUMLAH
            // =====================
            if (namaKolom == "colTambah")
            {
                int jumlahBaru = item.jumlah + 1;

                controller.UpdateJumlah(
                    item.id_keranjang,
                    jumlahBaru,
                    item.harga);

                LoadKeranjang();
            }

            // =====================
            // KURANGI JUMLAH
            // =====================
            else if (namaKolom == "colKurang")
            {
                if (item.jumlah > 1)
                {
                    int jumlahBaru = item.jumlah - 1;

                    controller.UpdateJumlah(
                        item.id_keranjang,
                        jumlahBaru,
                        item.harga);

                    LoadKeranjang();
                }
            }

            // =====================
            // HAPUS
            // =====================
            else if (namaKolom == "colHapus")
            {
                DialogResult hasil =
                    MessageBox.Show(
                        "Hapus item ini?",
                        "Konfirmasi",
                        MessageBoxButtons.YesNo);

                if (hasil == DialogResult.Yes)
                {
                    controller.HapusItem(
                        item.id_keranjang);

                    LoadKeranjang();
                }
            }
        }
        private void Keranjang_Load_1(object sender,EventArgs e)
        {
            LoadKeranjang();
        }

        private void LoadKeranjang()
        {
            dgvKeranjang.Rows.Clear();

            Pembeli pembeli =
                Session.CurrentUser as Pembeli;

            if (pembeli == null)
                return;

            var daftar =
                controller.GetKeranjangByUser(
                    pembeli.Id);

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

                dgvKeranjang.Rows[
                    dgvKeranjang.Rows.Count - 1
                ].Tag = item;

                totalBelanja += item.sub_total;
            }

            lblTotalBelanjaValue.Text =
                "Rp " + totalBelanja.ToString("N0");
        }
    }
}