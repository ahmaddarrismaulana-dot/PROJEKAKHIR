namespace PROJEKAKHIR
{
    partial class Katalog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            txtCari = new TextBox();
            cmbKategori = new ComboBox();
            cmbHarga = new ComboBox();
            btnTambah = new Button();
            flpProduk = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // txtCari
            // 
            txtCari.Location = new Point(11, 13);
            txtCari.Margin = new Padding(3, 4, 3, 4);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "Cari bibit atau kategori...";
            txtCari.Size = new Size(217, 27);
            txtCari.TabIndex = 0;
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.Items.AddRange(new object[] { "Semua Kategori", "Mangga", "Jeruk", "Durian", "Alpukat", "Jambu", "Rambutan", "Strawberry", "Anggur" });
            cmbKategori.Location = new Point(240, 13);
            cmbKategori.Margin = new Padding(3, 4, 3, 4);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(205, 28);
            cmbKategori.TabIndex = 1;
            // 
            // cmbHarga
            // 
            cmbHarga.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHarga.Items.AddRange(new object[] { "Semua Harga", "< Rp 25.000", "Rp 25.000 - Rp 50.000", "> Rp 50.000" });
            cmbHarga.Location = new Point(457, 13);
            cmbHarga.Margin = new Padding(3, 4, 3, 4);
            cmbHarga.Name = "cmbHarga";
            cmbHarga.Size = new Size(205, 28);
            cmbHarga.TabIndex = 2;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.ForestGreen;
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(754, 11);
            btnTambah.Margin = new Padding(3, 4, 3, 4);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(217, 36);
            btnTambah.TabIndex = 3;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // flpProduk
            // 
            flpProduk.AutoScroll = true;
            flpProduk.Location = new Point(11, 86);
            flpProduk.Name = "flpProduk";
            flpProduk.Size = new Size(960, 726);
            flpProduk.TabIndex = 4;
            flpProduk.Paint += flowLayoutPanel1_Paint;
            // 
            // Katalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flpProduk);
            Controls.Add(txtCari);
            Controls.Add(cmbKategori);
            Controls.Add(cmbHarga);
            Controls.Add(btnTambah);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Katalog";
            Size = new Size(983, 827);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ComboBox cmbHarga;
        private System.Windows.Forms.Button btnTambah;
        private FlowLayoutPanel flpProduk;
    }
}