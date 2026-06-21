namespace PROJEKAKHIR
{
    partial class editdatabiibit
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
            lblJudul       = new Label();
            lblSubJudul    = new Label();
            lblNamaBibit   = new Label();
            txtNamaBibit   = new TextBox();
            lblKategori    = new Label();
            cmbKategori    = new ComboBox();
            lblUmurBibit   = new Label();
            textUmurBibit  = new TextBox();
            lblHarga       = new Label();
            numHarga       = new NumericUpDown();
            lblStok        = new Label();
            numStok        = new NumericUpDown();
            lblDeskripsi   = new Label();
            txtDeskripsi   = new RichTextBox();
            lblFoto        = new Label();
            picBibit       = new PictureBox();
            btnPilihGambar = new Button();
            lblSeparator   = new Label();
            btnSimpan      = new Button();
            btnBatal       = new Button();

            ((System.ComponentModel.ISupportInitialize)numHarga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBibit).BeginInit();
            SuspendLayout();

            // ─────────────────────────────────────────
            // lblJudul
            // ─────────────────────────────────────────
            lblJudul.AutoSize = true;
            lblJudul.Font     = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(23, 13);
            lblJudul.Name     = "lblJudul";
            lblJudul.Size     = new Size(161, 23);
            lblJudul.TabIndex = 0;
            lblJudul.Text     = "Edit Data Bibit";

            // ─────────────────────────────────────────
            // lblSubJudul
            // ─────────────────────────────────────────
            lblSubJudul.AutoSize = true;
            lblSubJudul.Font     = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubJudul.Location = new Point(25, 39);
            lblSubJudul.Name     = "lblSubJudul";
            lblSubJudul.Size     = new Size(210, 16);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text     = "Perbarui informasi data bibit Anda";

            // ─────────────────────────────────────────
            // lblNamaBibit
            // ─────────────────────────────────────────
            lblNamaBibit.AutoSize = true;
            lblNamaBibit.Font     = new Font("Segoe UI", 9F);
            lblNamaBibit.Location = new Point(23, 73);
            lblNamaBibit.Name     = "lblNamaBibit";
            lblNamaBibit.Size     = new Size(84, 20);
            lblNamaBibit.TabIndex = 2;
            lblNamaBibit.Text     = "Nama Bibit";

            // ─────────────────────────────────────────
            // txtNamaBibit
            // ─────────────────────────────────────────
            txtNamaBibit.Location = new Point(166, 69);
            txtNamaBibit.Margin   = new Padding(3, 4, 3, 4);
            txtNamaBibit.Name     = "txtNamaBibit";
            txtNamaBibit.Size     = new Size(365, 27);
            txtNamaBibit.TabIndex = 3;

            // ─────────────────────────────────────────
            // lblKategori
            // ─────────────────────────────────────────
            lblKategori.AutoSize = true;
            lblKategori.Font     = new Font("Segoe UI", 9F);
            lblKategori.Location = new Point(23, 120);
            lblKategori.Name     = "lblKategori";
            lblKategori.Size     = new Size(66, 20);
            lblKategori.TabIndex = 4;
            lblKategori.Text     = "Kategori";

            // ─────────────────────────────────────────
            // cmbKategori
            // ─────────────────────────────────────────
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.Location      = new Point(166, 116);
            cmbKategori.Margin        = new Padding(3, 4, 3, 4);
            cmbKategori.Name          = "cmbKategori";
            cmbKategori.Size          = new Size(171, 28);
            cmbKategori.TabIndex      = 5;

            // ─────────────────────────────────────────
            // lblUmurBibit
            // ─────────────────────────────────────────
            lblUmurBibit.AutoSize = true;
            lblUmurBibit.Font     = new Font("Segoe UI", 9F);
            lblUmurBibit.Location = new Point(23, 167);
            lblUmurBibit.Name     = "lblUmurBibit";
            lblUmurBibit.Size     = new Size(80, 20);
            lblUmurBibit.TabIndex = 6;
            lblUmurBibit.Text     = "Umur Bibit";

            // ─────────────────────────────────────────
            // textUmurBibit
            // ─────────────────────────────────────────
            textUmurBibit.Location = new Point(166, 163);
            textUmurBibit.Margin   = new Padding(3, 4, 3, 4);
            textUmurBibit.Name     = "textUmurBibit";
            textUmurBibit.Size     = new Size(171, 27);
            textUmurBibit.TabIndex = 7;

            // ─────────────────────────────────────────
            // lblHarga
            // ─────────────────────────────────────────
            lblHarga.AutoSize = true;
            lblHarga.Font     = new Font("Segoe UI", 9F);
            lblHarga.Location = new Point(23, 213);
            lblHarga.Name     = "lblHarga";
            lblHarga.Size     = new Size(82, 20);
            lblHarga.TabIndex = 8;
            lblHarga.Text     = "Harga (Rp)";

            // ─────────────────────────────────────────
            // numHarga
            // ─────────────────────────────────────────
            numHarga.Location  = new Point(166, 209);
            numHarga.Margin    = new Padding(3, 4, 3, 4);
            numHarga.Maximum   = new decimal(new int[] { 9999999, 0, 0, 0 });
            numHarga.Name      = "numHarga";
            numHarga.Size      = new Size(171, 27);
            numHarga.TabIndex  = 9;
            numHarga.ThousandsSeparator = true;

            // ─────────────────────────────────────────
            // lblStok
            // ─────────────────────────────────────────
            lblStok.AutoSize = true;
            lblStok.Font     = new Font("Segoe UI", 9F);
            lblStok.Location = new Point(23, 260);
            lblStok.Name     = "lblStok";
            lblStok.Size     = new Size(38, 20);
            lblStok.TabIndex = 10;
            lblStok.Text     = "Stok";

            // ─────────────────────────────────────────
            // numStok
            // ─────────────────────────────────────────
            numStok.Location = new Point(166, 256);
            numStok.Margin   = new Padding(3, 4, 3, 4);
            numStok.Maximum  = new decimal(new int[] { 9999999, 0, 0, 0 });
            numStok.Name     = "numStok";
            numStok.Size     = new Size(171, 27);
            numStok.TabIndex = 11;

            // ─────────────────────────────────────────
            // lblDeskripsi
            // ─────────────────────────────────────────
            lblDeskripsi.AutoSize = true;
            lblDeskripsi.Font     = new Font("Segoe UI", 9F);
            lblDeskripsi.Location = new Point(23, 307);
            lblDeskripsi.Name     = "lblDeskripsi";
            lblDeskripsi.Size     = new Size(69, 20);
            lblDeskripsi.TabIndex = 12;
            lblDeskripsi.Text     = "Deskripsi";

            // ─────────────────────────────────────────
            // txtDeskripsi
            // ─────────────────────────────────────────
            txtDeskripsi.BorderStyle = BorderStyle.FixedSingle;
            txtDeskripsi.Location    = new Point(166, 303);
            txtDeskripsi.Margin      = new Padding(3, 4, 3, 4);
            txtDeskripsi.Name        = "txtDeskripsi";
            txtDeskripsi.ScrollBars  = RichTextBoxScrollBars.Vertical;
            txtDeskripsi.Size        = new Size(365, 85);
            txtDeskripsi.TabIndex    = 13;
            txtDeskripsi.Text        = "";

            // ─────────────────────────────────────────
            // lblFoto
            // ─────────────────────────────────────────
            lblFoto.AutoSize = true;
            lblFoto.Font     = new Font("Segoe UI", 9F);
            lblFoto.Location = new Point(23, 403);
            lblFoto.Name     = "lblFoto";
            lblFoto.Size     = new Size(34, 20);
            lblFoto.TabIndex = 14;
            lblFoto.Text     = "Foto";

            // ─────────────────────────────────────────
            // picBibit
            // ─────────────────────────────────────────
            picBibit.BorderStyle = BorderStyle.FixedSingle;
            picBibit.Location    = new Point(594, 69);
            picBibit.Margin      = new Padding(3, 4, 3, 4);
            picBibit.Name        = "picBibit";
            picBibit.Size        = new Size(171, 199);
            picBibit.SizeMode    = PictureBoxSizeMode.Zoom;
            picBibit.TabIndex    = 15;
            picBibit.TabStop     = false;

            // ─────────────────────────────────────────
            // btnPilihGambar
            // ─────────────────────────────────────────
            btnPilihGambar.BackColor = Color.FromArgb(108, 117, 125);
            btnPilihGambar.FlatAppearance.BorderSize = 0;
            btnPilihGambar.FlatStyle = FlatStyle.Flat;
            btnPilihGambar.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPilihGambar.ForeColor = Color.White;
            btnPilihGambar.Location  = new Point(594, 280);
            btnPilihGambar.Margin    = new Padding(3, 4, 3, 4);
            btnPilihGambar.Name      = "btnPilihGambar";
            btnPilihGambar.Size      = new Size(171, 35);
            btnPilihGambar.TabIndex  = 16;
            btnPilihGambar.Text      = "Pilih Gambar";
            btnPilihGambar.UseVisualStyleBackColor = false;
            btnPilihGambar.Click    += btnPilihGambar_Click;

            // ─────────────────────────────────────────
            // lblSeparator
            // ─────────────────────────────────────────
            lblSeparator.BackColor = Color.FromArgb(220, 220, 220);
            lblSeparator.Location  = new Point(23, 455);
            lblSeparator.Name      = "lblSeparator";
            lblSeparator.Size      = new Size(760, 1);
            lblSeparator.TabIndex  = 17;

            // ─────────────────────────────────────────
            // btnSimpan
            // ─────────────────────────────────────────
            btnSimpan.BackColor = Color.FromArgb(34, 139, 34);
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location  = new Point(166, 472);
            btnSimpan.Margin    = new Padding(3, 4, 3, 4);
            btnSimpan.Name      = "btnSimpan";
            btnSimpan.Size      = new Size(171, 40);
            btnSimpan.TabIndex  = 18;
            btnSimpan.Text      = "Simpan Perubahan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click    += btnSimpan_Click;

            // ─────────────────────────────────────────
            // btnBatal
            // ─────────────────────────────────────────
            btnBatal.BackColor = Color.FromArgb(211, 47, 47);
            btnBatal.FlatAppearance.BorderSize = 0;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBatal.ForeColor = Color.White;
            btnBatal.Location  = new Point(352, 472);
            btnBatal.Margin    = new Padding(3, 4, 3, 4);
            btnBatal.Name      = "btnBatal";
            btnBatal.Size      = new Size(171, 40);
            btnBatal.TabIndex  = 19;
            btnBatal.Text      = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click    += btnBatal_Click;

            // ─────────────────────────────────────────
            // editdatabiibit (UserControl)
            // ─────────────────────────────────────────
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode       = AutoScaleMode.Font;
            BackColor           = Color.White;
            Margin              = new Padding(3, 4, 3, 4);
            Name                = "editdatabiibit";
            Size                = new Size(1029, 560);

            Controls.Add(lblJudul);
            Controls.Add(lblSubJudul);
            Controls.Add(lblNamaBibit);
            Controls.Add(txtNamaBibit);
            Controls.Add(lblKategori);
            Controls.Add(cmbKategori);
            Controls.Add(lblUmurBibit);
            Controls.Add(textUmurBibit);
            Controls.Add(lblHarga);
            Controls.Add(numHarga);
            Controls.Add(lblStok);
            Controls.Add(numStok);
            Controls.Add(lblDeskripsi);
            Controls.Add(txtDeskripsi);
            Controls.Add(lblFoto);
            Controls.Add(picBibit);
            Controls.Add(btnPilihGambar);
            Controls.Add(lblSeparator);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);

            ((System.ComponentModel.ISupportInitialize)numHarga).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBibit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label      lblJudul;
        private System.Windows.Forms.Label      lblSubJudul;
        private System.Windows.Forms.Label      lblNamaBibit;
        private System.Windows.Forms.TextBox    txtNamaBibit;
        private System.Windows.Forms.Label      lblKategori;
        private System.Windows.Forms.ComboBox   cmbKategori;
        private System.Windows.Forms.Label      lblUmurBibit;
        private System.Windows.Forms.TextBox    textUmurBibit;
        private System.Windows.Forms.Label      lblHarga;
        private System.Windows.Forms.NumericUpDown numHarga;
        private System.Windows.Forms.Label      lblStok;
        private System.Windows.Forms.NumericUpDown numStok;
        private System.Windows.Forms.Label      lblDeskripsi;
        private System.Windows.Forms.RichTextBox txtDeskripsi;
        private System.Windows.Forms.Label      lblFoto;
        private System.Windows.Forms.PictureBox picBibit;
        private System.Windows.Forms.Button     btnPilihGambar;
        private System.Windows.Forms.Label      lblSeparator;
        private System.Windows.Forms.Button     btnSimpan;
        private System.Windows.Forms.Button     btnBatal;
    }
}