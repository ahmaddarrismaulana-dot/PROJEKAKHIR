using System.Drawing.Printing;
using System.Xml.Linq;

namespace bibitku_app
{
    partial class KelolaBibit
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblDataBibit = new Label();
            lblIdBibit = new Label();
            txtIdBibit = new TextBox();
            lblNamaBibit = new Label();
            txtNamaBibit = new TextBox();
            lblKategori = new Label();
            cmbKategori = new ComboBox();
            lblUmurBibit = new Label();
            cmbUmurBibit = new ComboBox();
            lblHarga = new Label();
            lblStok = new Label();
            lblDeskripsi = new Label();
            txtDeskripsi = new RichTextBox();
            picBibit = new PictureBox();
            btnPilihGambar = new Button();
            btnSimpan = new Button();
            btnReset = new Button();
            lblSeparator = new Label();
            lblDaftarBibit = new Label();
            txtCari = new TextBox();
            btnCari = new Button();
            dgvBibit = new DataGridView();
            colIdBibit = new DataGridViewTextBoxColumn();
            colNamaBibit = new DataGridViewTextBoxColumn();
            colKategori = new DataGridViewTextBoxColumn();
            colUmur = new DataGridViewTextBoxColumn();
            colHarga = new DataGridViewTextBoxColumn();
            colStok = new DataGridViewTextBoxColumn();
            colAksi = new DataGridViewTextBoxColumn();
            label1 = new Label();
            numHarga = new NumericUpDown();
            numStok = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)picBibit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBibit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHarga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStok).BeginInit();
            SuspendLayout();
            // 
            // lblDataBibit
            // 
            lblDataBibit.AutoSize = true;
            lblDataBibit.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataBibit.Location = new Point(23, 13);
            lblDataBibit.Name = "lblDataBibit";
            lblDataBibit.Size = new Size(105, 23);
            lblDataBibit.TabIndex = 0;
            lblDataBibit.Text = "Data Bibit";
            lblDataBibit.Click += lblDataBibit_Click;
            // 
            // lblIdBibit
            // 
            lblIdBibit.AutoSize = true;
            lblIdBibit.Font = new Font("Segoe UI", 9F);
            lblIdBibit.Location = new Point(23, 73);
            lblIdBibit.Name = "lblIdBibit";
            lblIdBibit.Size = new Size(59, 20);
            lblIdBibit.TabIndex = 1;
            lblIdBibit.Text = "ID Bibit";
            // 
            // txtIdBibit
            // 
            txtIdBibit.BackColor = Color.FromArgb(240, 240, 240);
            txtIdBibit.Location = new Point(166, 69);
            txtIdBibit.Margin = new Padding(3, 4, 3, 4);
            txtIdBibit.Name = "txtIdBibit";
            txtIdBibit.ReadOnly = true;
            txtIdBibit.Size = new Size(365, 27);
            txtIdBibit.TabIndex = 2;
            // 
            // lblNamaBibit
            // 
            lblNamaBibit.AutoSize = true;
            lblNamaBibit.Font = new Font("Segoe UI", 9F);
            lblNamaBibit.Location = new Point(23, 120);
            lblNamaBibit.Name = "lblNamaBibit";
            lblNamaBibit.Size = new Size(84, 20);
            lblNamaBibit.TabIndex = 3;
            lblNamaBibit.Text = "Nama Bibit";
            // 
            // txtNamaBibit
            // 
            txtNamaBibit.Location = new Point(166, 116);
            txtNamaBibit.Margin = new Padding(3, 4, 3, 4);
            txtNamaBibit.Name = "txtNamaBibit";
            txtNamaBibit.Size = new Size(365, 27);
            txtNamaBibit.TabIndex = 4;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Font = new Font("Segoe UI", 9F);
            lblKategori.Location = new Point(23, 167);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(66, 20);
            lblKategori.TabIndex = 5;
            lblKategori.Text = "Kategori";
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.Location = new Point(166, 163);
            cmbKategori.Margin = new Padding(3, 4, 3, 4);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(171, 28);
            cmbKategori.TabIndex = 6;
            // 
            // lblUmurBibit
            // 
            lblUmurBibit.AutoSize = true;
            lblUmurBibit.Font = new Font("Segoe UI", 9F);
            lblUmurBibit.Location = new Point(23, 213);
            lblUmurBibit.Name = "lblUmurBibit";
            lblUmurBibit.Size = new Size(80, 20);
            lblUmurBibit.TabIndex = 7;
            lblUmurBibit.Text = "Umur Bibit";
            // 
            // cmbUmurBibit
            // 
            cmbUmurBibit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUmurBibit.Location = new Point(166, 209);
            cmbUmurBibit.Margin = new Padding(3, 4, 3, 4);
            cmbUmurBibit.Name = "cmbUmurBibit";
            cmbUmurBibit.Size = new Size(171, 28);
            cmbUmurBibit.TabIndex = 8;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Segoe UI", 9F);
            lblHarga.Location = new Point(23, 260);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(82, 20);
            lblHarga.TabIndex = 9;
            lblHarga.Text = "Harga (Rp)";
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.Font = new Font("Segoe UI", 9F);
            lblStok.Location = new Point(23, 307);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(38, 20);
            lblStok.TabIndex = 11;
            lblStok.Text = "Stok";
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.AutoSize = true;
            lblDeskripsi.Font = new Font("Segoe UI", 9F);
            lblDeskripsi.Location = new Point(23, 353);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(69, 20);
            lblDeskripsi.TabIndex = 13;
            lblDeskripsi.Text = "Deskripsi";
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.BorderStyle = BorderStyle.FixedSingle;
            txtDeskripsi.Location = new Point(166, 349);
            txtDeskripsi.Margin = new Padding(3, 4, 3, 4);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtDeskripsi.Size = new Size(365, 85);
            txtDeskripsi.TabIndex = 14;
            txtDeskripsi.Text = "";
            // 
            // picBibit
            // 
            picBibit.BorderStyle = BorderStyle.FixedSingle;
            picBibit.Location = new Point(594, 69);
            picBibit.Margin = new Padding(3, 4, 3, 4);
            picBibit.Name = "picBibit";
            picBibit.Size = new Size(171, 199);
            picBibit.SizeMode = PictureBoxSizeMode.Zoom;
            picBibit.TabIndex = 15;
            picBibit.TabStop = false;
            // 
            // btnPilihGambar
            // 
            btnPilihGambar.BackColor = Color.FromArgb(108, 117, 125);
            btnPilihGambar.FlatAppearance.BorderSize = 0;
            btnPilihGambar.FlatStyle = FlatStyle.Flat;
            btnPilihGambar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPilihGambar.ForeColor = Color.White;
            btnPilihGambar.Location = new Point(594, 280);
            btnPilihGambar.Margin = new Padding(3, 4, 3, 4);
            btnPilihGambar.Name = "btnPilihGambar";
            btnPilihGambar.Size = new Size(171, 40);
            btnPilihGambar.TabIndex = 16;
            btnPilihGambar.Text = "Pilih Gambar";
            btnPilihGambar.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(40, 167, 69);
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(166, 460);
            btnSimpan.Margin = new Padding(3, 4, 3, 4);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(114, 45);
            btnSimpan.TabIndex = 17;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(200, 200, 200);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(296, 460);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(114, 45);
            btnReset.TabIndex = 20;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // lblSeparator
            // 
            lblSeparator.BackColor = Color.FromArgb(220, 220, 220);
            lblSeparator.Location = new Point(0, 527);
            lblSeparator.Name = "lblSeparator";
            lblSeparator.Size = new Size(1029, 1);
            lblSeparator.TabIndex = 21;
            // 
            // lblDaftarBibit
            // 
            lblDaftarBibit.AutoSize = true;
            lblDaftarBibit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDaftarBibit.Location = new Point(23, 547);
            lblDaftarBibit.Name = "lblDaftarBibit";
            lblDaftarBibit.Size = new Size(106, 23);
            lblDaftarBibit.TabIndex = 22;
            lblDaftarBibit.Text = "Daftar Bibit";
            // 
            // txtCari
            // 
            txtCari.Location = new Point(720, 544);
            txtCari.Margin = new Padding(3, 4, 3, 4);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "Cari bibit...";
            txtCari.Size = new Size(217, 27);
            txtCari.TabIndex = 23;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.FromArgb(40, 167, 69);
            btnCari.FlatAppearance.BorderSize = 0;
            btnCari.FlatStyle = FlatStyle.Flat;
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(943, 544);
            btnCari.Margin = new Padding(3, 4, 3, 4);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(34, 31);
            btnCari.TabIndex = 24;
            btnCari.Text = "🔍";
            btnCari.UseVisualStyleBackColor = false;
            // 
            // dgvBibit
            // 
            dgvBibit.AllowUserToAddRows = false;
            dgvBibit.AllowUserToDeleteRows = false;
            dgvBibit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBibit.BackgroundColor = Color.White;
            dgvBibit.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvBibit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvBibit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBibit.Columns.AddRange(new DataGridViewColumn[] { colIdBibit, colNamaBibit, colKategori, colUmur, colHarga, colStok, colAksi });
            dgvBibit.EnableHeadersVisualStyles = false;
            dgvBibit.GridColor = Color.FromArgb(230, 230, 230);
            dgvBibit.Location = new Point(23, 587);
            dgvBibit.Margin = new Padding(3, 4, 3, 4);
            dgvBibit.Name = "dgvBibit";
            dgvBibit.ReadOnly = true;
            dgvBibit.RowHeadersVisible = false;
            dgvBibit.RowHeadersWidth = 51;
            dgvBibit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBibit.Size = new Size(983, 240);
            dgvBibit.TabIndex = 25;
            // 
            // colIdBibit
            // 
            colIdBibit.FillWeight = 80F;
            colIdBibit.HeaderText = "ID Bibit";
            colIdBibit.MinimumWidth = 6;
            colIdBibit.Name = "colIdBibit";
            colIdBibit.ReadOnly = true;
            // 
            // colNamaBibit
            // 
            colNamaBibit.FillWeight = 200F;
            colNamaBibit.HeaderText = "Nama Bibit";
            colNamaBibit.MinimumWidth = 6;
            colNamaBibit.Name = "colNamaBibit";
            colNamaBibit.ReadOnly = true;
            // 
            // colKategori
            // 
            colKategori.HeaderText = "Kategori";
            colKategori.MinimumWidth = 6;
            colKategori.Name = "colKategori";
            colKategori.ReadOnly = true;
            // 
            // colUmur
            // 
            colUmur.FillWeight = 80F;
            colUmur.HeaderText = "Umur";
            colUmur.MinimumWidth = 6;
            colUmur.Name = "colUmur";
            colUmur.ReadOnly = true;
            // 
            // colHarga
            // 
            colHarga.FillWeight = 80F;
            colHarga.HeaderText = "Harga";
            colHarga.MinimumWidth = 6;
            colHarga.Name = "colHarga";
            colHarga.ReadOnly = true;
            // 
            // colStok
            // 
            colStok.FillWeight = 60F;
            colStok.HeaderText = "Stok";
            colStok.MinimumWidth = 6;
            colStok.Name = "colStok";
            colStok.ReadOnly = true;
            // 
            // colAksi
            // 
            colAksi.FillWeight = 60F;
            colAksi.HeaderText = "Aksi";
            colAksi.MinimumWidth = 6;
            colAksi.Name = "colAksi";
            colAksi.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 39);
            label1.Name = "label1";
            label1.Size = new Size(187, 16);
            label1.TabIndex = 0;
            label1.Text = "Kelola data bibit tanaman Anda";
            label1.Click += label1_Click;
            // 
            // numHarga
            // 
            numHarga.Location = new Point(166, 256);
            numHarga.Name = "numHarga";
            numHarga.Size = new Size(171, 27);
            numHarga.TabIndex = 26;
            // 
            // numStok
            // 
            numStok.Location = new Point(166, 303);
            numStok.Name = "numStok";
            numStok.Size = new Size(171, 27);
            numStok.TabIndex = 27;
            // 
            // KelolaBibit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(numStok);
            Controls.Add(numHarga);
            Controls.Add(label1);
            Controls.Add(lblDataBibit);
            Controls.Add(lblIdBibit);
            Controls.Add(txtIdBibit);
            Controls.Add(lblNamaBibit);
            Controls.Add(txtNamaBibit);
            Controls.Add(lblKategori);
            Controls.Add(cmbKategori);
            Controls.Add(lblUmurBibit);
            Controls.Add(cmbUmurBibit);
            Controls.Add(lblHarga);
            Controls.Add(lblStok);
            Controls.Add(lblDeskripsi);
            Controls.Add(txtDeskripsi);
            Controls.Add(picBibit);
            Controls.Add(btnPilihGambar);
            Controls.Add(btnSimpan);
            Controls.Add(btnReset);
            Controls.Add(lblSeparator);
            Controls.Add(lblDaftarBibit);
            Controls.Add(txtCari);
            Controls.Add(btnCari);
            Controls.Add(dgvBibit);
            Margin = new Padding(3, 4, 3, 4);
            Name = "KelolaBibit";
            Size = new Size(1029, 853);
            ((System.ComponentModel.ISupportInitialize)picBibit).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBibit).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHarga).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDataBibit;
        private System.Windows.Forms.Label lblIdBibit;
        private System.Windows.Forms.TextBox txtIdBibit;
        private System.Windows.Forms.Label lblNamaBibit;
        private System.Windows.Forms.TextBox txtNamaBibit;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label lblUmurBibit;
        private System.Windows.Forms.ComboBox cmbUmurBibit;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.RichTextBox txtDeskripsi;
        private System.Windows.Forms.PictureBox picBibit;
        private System.Windows.Forms.Button btnPilihGambar;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.Label lblDaftarBibit;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.DataGridView dgvBibit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdBibit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamaBibit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUmur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStok;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAksi;
        private Label label1;
        private NumericUpDown numHarga;
        private NumericUpDown numStok;
    }
}