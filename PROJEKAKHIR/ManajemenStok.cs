using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bibitku.Controllers;
using PROJEKAKHIR.Models;

namespace bibitku_app
{
    public partial class ManajemenStok : UserControl
    {
        private ManajemenStokController controller;
        private List<Bibit> daftarBibit;

        public ManajemenStok()
        {
            InitializeComponent();
            controller = new ManajemenStokController();
        }

        // =====================================================
        // LOAD USERCONTROL
        // =====================================================
        private void ManajemenStok_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // =====================================================
        // LOAD SEMUA DATA
        // =====================================================
        private void LoadData()
        {
            try
            {
                LoadDaftarBibit();
                LoadRingkasanStok();
                LoadComboBoxBibit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // LOAD DATA BIBIT KE DATAGRIDVIEW
        // =====================================================
        private void LoadDaftarBibit()
        {
            daftarBibit = controller.GetAllBibit();
            dgvStok.Rows.Clear();

            foreach (var item in daftarBibit)
            {
                string status = controller.GetStatusStok(item.stok);
                DataGridViewRow row = new DataGridViewRow();

                dgvStok.Rows.Add(
                    item.id_bibit,
                    item.nama_bibit,
                    item.stok,
                    status
                );

                // Warna baris berdasarkan status
                int rowIndex = dgvStok.Rows.Count - 1;
                if (status == "Habis")
                {
                    dgvStok.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 240, 240);
                    dgvStok.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(220, 53, 69);
                }
                else if (status == "Menipis")
                {
                    dgvStok.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 248, 240);
                    dgvStok.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(255, 153, 0);
                }
                else
                {
                    dgvStok.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(240, 255, 240);
                    dgvStok.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(40, 167, 69);
                }
            }
        }

        // =====================================================
        // LOAD RINGKASAN STOK (TOTAL, MENIPIS, HABIS)
        // =====================================================
        private void LoadRingkasanStok()
        {
            var ringkasan = controller.GetRingkasanStok();

            lblTotalStokVal.Text = $"{ringkasan.totalStok} pcs";
            lblMenipisVal.Text = $"{ringkasan.stokMenipis} item";
            lblHabisVal.Text = $"{ringkasan.stokHabis} item";
        }

        // =====================================================
        // LOAD COMBOBOX BIBIT
        // =====================================================
        private void LoadComboBoxBibit()
        {
            cmbPilihBibit.Items.Clear();
            cmbPilihBibit.Items.Add("-- Pilih Bibit --");

            foreach (var bibit in daftarBibit)
            {
                cmbPilihBibit.Items.Add($"{bibit.id_bibit} - {bibit.nama_bibit} (Stok: {bibit.stok})");
            }

            cmbPilihBibit.SelectedIndex = 0;
        }

        // =====================================================
        // EVENT: COMBOBOX BIBIT BERUBAH
        // =====================================================
        private void cmbPilihBibit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPilihBibit.SelectedIndex > 0)
            {
                try
                {
                    // Ambil ID bibit dari teks yang dipilih
                    string selectedText = cmbPilihBibit.SelectedItem.ToString();
                    int idBibit = int.Parse(selectedText.Split('-')[0].Trim());

                    var bibit = daftarBibit.FirstOrDefault(b => b.id_bibit == idBibit);
                    if (bibit != null)
                    {
                        // PERBAIKAN: Set Minimum terlebih dahulu sebelum Value
                        if (rbSetManual.Checked)
                        {
                            numJumlah.Minimum = 0;
                            numJumlah.Maximum = 999999;
                            numJumlah.Value = bibit.stok;
                        }
                        else if (rbStokMasuk.Checked)
                        {
                            numJumlah.Minimum = 1;
                            numJumlah.Maximum = 999999;
                            numJumlah.Value = 1;
                        }
                        else if (rbStokKeluar.Checked)
                        {
                            numJumlah.Minimum = 1;
                            numJumlah.Maximum = bibit.stok > 0 ? bibit.stok : 1;
                            numJumlah.Value = 1;
                        }
                        else
                        {
                            // Default case
                            numJumlah.Minimum = 0;
                            numJumlah.Maximum = 999999;
                            numJumlah.Value = 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting bibit: " + ex.Message);
                }
            }
            else
            {
                // Jika tidak ada bibit dipilih, reset dengan aman
                numJumlah.Minimum = 0;
                numJumlah.Maximum = 999999;
                numJumlah.Value = 0;
            }
        }

        // =====================================================
        // EVENT: RADIO BUTTON BERUBAH
        // =====================================================
        private void rbStokMasuk_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStokMasuk.Checked)
            {
                lblJumlah.Text = "Jumlah Masuk *";
                // PERBAIKAN: Set Minimum dan Maximum sebelum Value
                numJumlah.Minimum = 1;
                numJumlah.Maximum = 999999;
                numJumlah.Value = 1;
            }
        }

        private void rbStokKeluar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStokKeluar.Checked)
            {
                lblJumlah.Text = "Jumlah Keluar *";
                numJumlah.Minimum = 1;
                numJumlah.Maximum = 999999;

                // Validasi tidak boleh melebihi stok
                if (cmbPilihBibit.SelectedIndex > 0)
                {
                    try
                    {
                        string selectedText = cmbPilihBibit.SelectedItem.ToString();
                        int idBibit = int.Parse(selectedText.Split('-')[0].Trim());
                        var bibit = daftarBibit.FirstOrDefault(b => b.id_bibit == idBibit);
                        if (bibit != null && bibit.stok > 0)
                        {
                            numJumlah.Maximum = bibit.stok;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }

                numJumlah.Value = 1;
            }
        }

        private void rbSetManual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSetManual.Checked)
            {
                lblJumlah.Text = "Stok Baru *";
                // PERBAIKAN: Set Minimum dulu
                numJumlah.Minimum = 0;
                numJumlah.Maximum = 999999;

                // Set nilai ke stok saat ini
                if (cmbPilihBibit.SelectedIndex > 0)
                {
                    try
                    {
                        string selectedText = cmbPilihBibit.SelectedItem.ToString();
                        int idBibit = int.Parse(selectedText.Split('-')[0].Trim());
                        var bibit = daftarBibit.FirstOrDefault(b => b.id_bibit == idBibit);
                        if (bibit != null)
                        {
                            numJumlah.Value = bibit.stok;
                        }
                        else
                        {
                            numJumlah.Value = 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        numJumlah.Value = 0;
                    }
                }
                else
                {
                    numJumlah.Value = 0;
                }
            }
        }

        // =====================================================
        // EVENT: SIMPAN PENYESUAIAN STOK
        // =====================================================
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi pilih bibit
                if (cmbPilihBibit.SelectedIndex <= 0)
                {
                    MessageBox.Show("Silakan pilih bibit terlebih dahulu!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbPilihBibit.Focus();
                    return;
                }

                // Validasi jumlah
                if (numJumlah.Value <= 0 && !rbSetManual.Checked)
                {
                    MessageBox.Show("Jumlah harus lebih dari 0!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numJumlah.Focus();
                    return;
                }

                // Ambil ID bibit yang dipilih
                string selectedText = cmbPilihBibit.SelectedItem.ToString();
                int idBibit = int.Parse(selectedText.Split('-')[0].Trim());
                var bibit = daftarBibit.FirstOrDefault(b => b.id_bibit == idBibit);

                if (bibit == null)
                {
                    MessageBox.Show("Data bibit tidak ditemukan!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int stokBaru = 0;
                string tipePenyesuaian = "";

                // Hitung stok baru berdasarkan pilihan
                if (rbStokMasuk.Checked)
                {
                    stokBaru = bibit.stok + (int)numJumlah.Value;
                    tipePenyesuaian = "Stok Masuk";
                }
                else if (rbStokKeluar.Checked)
                {
                    if ((int)numJumlah.Value > bibit.stok)
                    {
                        MessageBox.Show($"Stok keluar tidak boleh melebihi stok yang ada (Stok saat ini: {bibit.stok})",
                            "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    stokBaru = bibit.stok - (int)numJumlah.Value;
                    tipePenyesuaian = "Stok Keluar";
                }
                else if (rbSetManual.Checked)
                {
                    stokBaru = (int)numJumlah.Value;
                    tipePenyesuaian = "Set Manual";
                }
                else
                {
                    MessageBox.Show("Silakan pilih tipe penyesuaian!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Konfirmasi
                DialogResult result = MessageBox.Show(
                    $"Bibit: {bibit.nama_bibit}\n" +
                    $"Tipe: {tipePenyesuaian}\n" +
                    $"Stok Lama: {bibit.stok}\n" +
                    $"Stok Baru: {stokBaru}\n\n" +
                    $"Apakah Anda yakin?",
                    "Konfirmasi Penyesuaian Stok",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool berhasil = controller.UpdateStok(idBibit, stokBaru, tipePenyesuaian);

                    if (berhasil)
                    {
                        MessageBox.Show("Stok berhasil diperbarui!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh data
                        LoadData();

                        // Reset form
                        cmbPilihBibit.SelectedIndex = 0;
                        numJumlah.Value = 0;
                        rbStokMasuk.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui stok!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // EVENT: DOUBLE CLICK DATA GRID UNTUK EDIT CEPAT
        // =====================================================
        private void dgvStok_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idBibit = Convert.ToInt32(dgvStok.Rows[e.RowIndex].Cells[0].Value);
                var bibit = daftarBibit.FirstOrDefault(b => b.id_bibit == idBibit);

                if (bibit != null)
                {
                    // Pilih bibit di combobox
                    for (int i = 0; i < cmbPilihBibit.Items.Count; i++)
                    {
                        if (cmbPilihBibit.Items[i].ToString().Contains(idBibit.ToString()))
                        {
                            cmbPilihBibit.SelectedIndex = i;
                            break;
                        }
                    }

                    // Set ke mode manual dengan stok saat ini
                    rbSetManual.Checked = true;
                    numJumlah.Value = bibit.stok;

                    // Scroll ke panel penyesuaian
                    panelPenyesuaian.Focus();
                }
            }
        }

        // =====================================================
        // EVENT: PAINT UNTUK STYLING (Opsional)
        // =====================================================
        private void panelTotalStok_Paint(object sender, PaintEventArgs e) { }
        private void panelMenipis_Paint(object sender, PaintEventArgs e) { }
        private void panelHabis_Paint(object sender, PaintEventArgs e) { }

        private void lblMenipisTitle_Click(object sender, EventArgs e)
        {

        }

        private void dgvStok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Mengulangdata()
        {
            LoadData();
        }
    }
}