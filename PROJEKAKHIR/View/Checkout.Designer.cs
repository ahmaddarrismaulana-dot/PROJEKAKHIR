using System.Drawing.Printing;
using System.Xml.Linq;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace PROJEKAKHIR
{
    partial class Checkout
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            lblInfoTitle = new Label();
            lblRingkasan = new Label();
            dgvPesanan = new DataGridView();
            colProduk = new DataGridViewTextBoxColumn();
            colJumlah = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            lblSepTotal = new Label();
            lblTotalLabel = new Label();
            lblTotalVal = new Label();
            btnLanjut = new Button();
            lblIDTransaksi = new Label();
            lblTotalBayar = new Label();
            txtTotalBayar = new TextBox();
            lblNama = new Label();
            txtNama = new TextBox();
            lblMetodePembayaran = new Label();
            cmbMetodePembayaran = new ComboBox();
            lblBankTujuan = new Label();
            cmbBankTujuan = new ComboBox();
            lblDetailPembayaran = new Label();
            lblInstruksi = new Label();
            lblStep1 = new Label();
            lblStep2 = new Label();
            lblStep3 = new Label();
            lblUploadBukti = new Label();
            pnlUpload = new Panel();
            btnPilihGambar = new Button();
            picUploadIcon = new PictureBox();
            lblUploadFormat = new Label();
            lblAlamat = new Label();
            txtAlamat = new RichTextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblTransaksi = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPesanan).BeginInit();
            pnlUpload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUploadIcon).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblInfoTitle
            // 
            lblInfoTitle.AutoSize = true;
            lblInfoTitle.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoTitle.Location = new Point(14, 13);
            lblInfoTitle.Name = "lblInfoTitle";
            lblInfoTitle.Size = new Size(120, 27);
            lblInfoTitle.TabIndex = 0;
            lblInfoTitle.Text = "Checkout";
            // 
            // lblRingkasan
            // 
            lblRingkasan.AutoSize = true;
            lblRingkasan.Font = new Font("Arial Rounded MT Bold", 12F);
            lblRingkasan.Location = new Point(495, 68);
            lblRingkasan.Name = "lblRingkasan";
            lblRingkasan.Size = new Size(201, 23);
            lblRingkasan.TabIndex = 7;
            lblRingkasan.Text = "Ringkasan Pesanan";
            // 
            // dgvPesanan
            // 
            dgvPesanan.AllowUserToAddRows = false;
            dgvPesanan.AllowUserToDeleteRows = false;
            dgvPesanan.AllowUserToResizeRows = false;
            dgvPesanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPesanan.BackgroundColor = Color.White;
            dgvPesanan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.LightGray;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvPesanan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvPesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPesanan.Columns.AddRange(new DataGridViewColumn[] { colProduk, colJumlah, colSubtotal });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvPesanan.DefaultCellStyle = dataGridViewCellStyle8;
            dgvPesanan.EnableHeadersVisualStyles = false;
            dgvPesanan.GridColor = Color.FromArgb(220, 220, 220);
            dgvPesanan.Location = new Point(495, 114);
            dgvPesanan.Margin = new Padding(3, 4, 3, 4);
            dgvPesanan.Name = "dgvPesanan";
            dgvPesanan.ReadOnly = true;
            dgvPesanan.RowHeadersVisible = false;
            dgvPesanan.RowHeadersWidth = 51;
            dgvPesanan.RowTemplate.Height = 38;
            dgvPesanan.ScrollBars = ScrollBars.Vertical;
            dgvPesanan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPesanan.Size = new Size(560, 400);
            dgvPesanan.TabIndex = 8;
            dgvPesanan.CellContentClick += dgvPesanan_CellContentClick;
            // 
            // colProduk
            // 
            dataGridViewCellStyle6.BackColor = Color.White;
            colProduk.DefaultCellStyle = dataGridViewCellStyle6;
            colProduk.FillWeight = 220F;
            colProduk.HeaderText = "Produk";
            colProduk.MinimumWidth = 6;
            colProduk.Name = "colProduk";
            colProduk.ReadOnly = true;
            // 
            // colJumlah
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colJumlah.DefaultCellStyle = dataGridViewCellStyle7;
            colJumlah.FillWeight = 80F;
            colJumlah.HeaderText = "Jumlah";
            colJumlah.MinimumWidth = 6;
            colJumlah.Name = "colJumlah";
            colJumlah.ReadOnly = true;
            // 
            // colSubtotal
            // 
            colSubtotal.FillWeight = 130F;
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.MinimumWidth = 6;
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            // 
            // lblSepTotal
            // 
            lblSepTotal.BackColor = Color.FromArgb(210, 210, 210);
            lblSepTotal.Location = new Point(495, 528);
            lblSepTotal.Name = "lblSepTotal";
            lblSepTotal.Size = new Size(560, 1);
            lblSepTotal.TabIndex = 9;
            // 
            // lblTotalLabel
            // 
            lblTotalLabel.AutoSize = true;
            lblTotalLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalLabel.ForeColor = Color.FromArgb(30, 30, 30);
            lblTotalLabel.Location = new Point(495, 548);
            lblTotalLabel.Name = "lblTotalLabel";
            lblTotalLabel.Size = new Size(49, 23);
            lblTotalLabel.TabIndex = 10;
            lblTotalLabel.Text = "Total";
            // 
            // lblTotalVal
            // 
            lblTotalVal.AutoSize = true;
            lblTotalVal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTotalVal.ForeColor = Color.ForestGreen;
            lblTotalVal.Location = new Point(924, 541);
            lblTotalVal.Name = "lblTotalVal";
            lblTotalVal.Size = new Size(131, 30);
            lblTotalVal.TabIndex = 11;
            lblTotalVal.Text = "Rp 128.000";
            // 
            // btnLanjut
            // 
            btnLanjut.BackColor = Color.ForestGreen;
            btnLanjut.FlatAppearance.BorderSize = 0;
            btnLanjut.FlatStyle = FlatStyle.Flat;
            btnLanjut.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLanjut.ForeColor = Color.White;
            btnLanjut.Location = new Point(865, 601);
            btnLanjut.Margin = new Padding(3, 4, 3, 4);
            btnLanjut.Name = "btnLanjut";
            btnLanjut.Size = new Size(190, 53);
            btnLanjut.TabIndex = 12;
            btnLanjut.Text = "Checkout";
            btnLanjut.UseVisualStyleBackColor = false;
            btnLanjut.Click += btnLanjut_Click;
            // 
            // lblIDTransaksi
            // 
            lblIDTransaksi.AutoSize = true;
            lblIDTransaksi.Font = new Font("Segoe UI", 9F);
            lblIDTransaksi.ForeColor = Color.Black;
            lblIDTransaksi.Location = new Point(23, 119);
            lblIDTransaksi.Name = "lblIDTransaksi";
            lblIDTransaksi.Size = new Size(87, 20);
            lblIDTransaksi.TabIndex = 14;
            lblIDTransaksi.Text = "ID Transaksi";
            // 
            // lblTotalBayar
            // 
            lblTotalBayar.AutoSize = true;
            lblTotalBayar.Font = new Font("Segoe UI", 9F);
            lblTotalBayar.ForeColor = Color.Black;
            lblTotalBayar.Location = new Point(23, 166);
            lblTotalBayar.Name = "lblTotalBayar";
            lblTotalBayar.Size = new Size(83, 20);
            lblTotalBayar.TabIndex = 16;
            lblTotalBayar.Text = "Total Bayar";
            // 
            // txtTotalBayar
            // 
            txtTotalBayar.BackColor = Color.FromArgb(245, 245, 245);
            txtTotalBayar.BorderStyle = BorderStyle.None;
            txtTotalBayar.Font = new Font("Segoe UI", 9F);
            txtTotalBayar.ForeColor = Color.FromArgb(30, 30, 30);
            txtTotalBayar.Location = new Point(194, 163);
            txtTotalBayar.Margin = new Padding(3, 4, 3, 4);
            txtTotalBayar.Name = "txtTotalBayar";
            txtTotalBayar.ReadOnly = true;
            txtTotalBayar.Size = new Size(274, 20);
            txtTotalBayar.TabIndex = 17;
            txtTotalBayar.Text = "Rp 128.000";
            txtTotalBayar.TextChanged += txtTotalBayar_TextChanged;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 9F);
            lblNama.ForeColor = Color.Black;
            lblNama.Location = new Point(23, 213);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(49, 20);
            lblNama.TabIndex = 18;
            lblNama.Text = "Nama";
            // 
            // txtNama
            // 
            txtNama.BackColor = Color.FromArgb(245, 245, 245);
            txtNama.BorderStyle = BorderStyle.None;
            txtNama.Font = new Font("Segoe UI", 9F);
            txtNama.ForeColor = Color.FromArgb(30, 30, 30);
            txtNama.Location = new Point(194, 210);
            txtNama.Margin = new Padding(3, 4, 3, 4);
            txtNama.Name = "txtNama";
            txtNama.ReadOnly = true;
            txtNama.Size = new Size(274, 20);
            txtNama.TabIndex = 19;
            txtNama.Text = "Rudi Setiawan";
            // 
            // lblMetodePembayaran
            // 
            lblMetodePembayaran.AutoSize = true;
            lblMetodePembayaran.Font = new Font("Segoe UI", 9F);
            lblMetodePembayaran.ForeColor = Color.Black;
            lblMetodePembayaran.Location = new Point(23, 384);
            lblMetodePembayaran.Name = "lblMetodePembayaran";
            lblMetodePembayaran.Size = new Size(146, 20);
            lblMetodePembayaran.TabIndex = 20;
            lblMetodePembayaran.Text = "Metode Pembayaran";
            // 
            // cmbMetodePembayaran
            // 
            cmbMetodePembayaran.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodePembayaran.Font = new Font("Segoe UI", 9F);
            cmbMetodePembayaran.Items.AddRange(new object[] { "Transfer Bank", "COD", "E-Wallet" });
            cmbMetodePembayaran.Location = new Point(194, 380);
            cmbMetodePembayaran.Margin = new Padding(3, 4, 3, 4);
            cmbMetodePembayaran.Name = "cmbMetodePembayaran";
            cmbMetodePembayaran.Size = new Size(274, 28);
            cmbMetodePembayaran.TabIndex = 21;
            cmbMetodePembayaran.SelectedIndexChanged += cmbMetodePembayaran_SelectedIndexChanged;
            // 
            // lblBankTujuan
            // 
            lblBankTujuan.AutoSize = true;
            lblBankTujuan.Font = new Font("Segoe UI", 9F);
            lblBankTujuan.ForeColor = Color.Black;
            lblBankTujuan.Location = new Point(23, 438);
            lblBankTujuan.Name = "lblBankTujuan";
            lblBankTujuan.Size = new Size(89, 20);
            lblBankTujuan.TabIndex = 22;
            lblBankTujuan.Text = "Bank Tujuan";
            // 
            // cmbBankTujuan
            // 
            cmbBankTujuan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBankTujuan.Font = new Font("Segoe UI", 9F);
            cmbBankTujuan.Items.AddRange(new object[] { "BCA - 12345 6789 (BibitKu)", "BNI - 98765 4321 (BibitKu)", "Mandiri - 11223 3445 (BibitKu)" });
            cmbBankTujuan.Location = new Point(194, 434);
            cmbBankTujuan.Margin = new Padding(3, 4, 3, 4);
            cmbBankTujuan.Name = "cmbBankTujuan";
            cmbBankTujuan.Size = new Size(274, 28);
            cmbBankTujuan.TabIndex = 23;
            cmbBankTujuan.SelectedIndexChanged += cmbBankTujuan_SelectedIndexChanged;
            // 
            // lblDetailPembayaran
            // 
            lblDetailPembayaran.AutoSize = true;
            lblDetailPembayaran.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDetailPembayaran.ForeColor = Color.FromArgb(30, 30, 30);
            lblDetailPembayaran.Location = new Point(23, 73);
            lblDetailPembayaran.Name = "lblDetailPembayaran";
            lblDetailPembayaran.Size = new Size(195, 23);
            lblDetailPembayaran.TabIndex = 13;
            lblDetailPembayaran.Text = "Detail Pembayaran";
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblInstruksi.ForeColor = Color.FromArgb(30, 30, 30);
            lblInstruksi.Location = new Point(23, 489);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(204, 25);
            lblInstruksi.TabIndex = 24;
            lblInstruksi.Text = "Instruksi Pembayaran";
            // 
            // lblStep1
            // 
            lblStep1.AutoSize = true;
            lblStep1.Font = new Font("Segoe UI", 9F);
            lblStep1.ForeColor = Color.FromArgb(60, 60, 60);
            lblStep1.Location = new Point(23, 529);
            lblStep1.Name = "lblStep1";
            lblStep1.Size = new Size(306, 20);
            lblStep1.TabIndex = 25;
            lblStep1.Text = "1. Transfer sesuai nominal ke rekening tujuan.";
            // 
            // lblStep2
            // 
            lblStep2.AutoSize = true;
            lblStep2.Font = new Font("Segoe UI", 9F);
            lblStep2.ForeColor = Color.FromArgb(60, 60, 60);
            lblStep2.Location = new Point(23, 555);
            lblStep2.Name = "lblStep2";
            lblStep2.Size = new Size(200, 20);
            lblStep2.TabIndex = 26;
            lblStep2.Text = "2. Upload bukti pembayaran.";
            // 
            // lblStep3
            // 
            lblStep3.AutoSize = true;
            lblStep3.Font = new Font("Segoe UI", 9F);
            lblStep3.ForeColor = Color.FromArgb(60, 60, 60);
            lblStep3.Location = new Point(23, 582);
            lblStep3.Name = "lblStep3";
            lblStep3.Size = new Size(270, 20);
            lblStep3.TabIndex = 27;
            lblStep3.Text = "3. Klik tombol 'Konfirmasi Pembayaran'.";
            // 
            // lblUploadBukti
            // 
            lblUploadBukti.AutoSize = true;
            lblUploadBukti.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblUploadBukti.ForeColor = Color.FromArgb(30, 30, 30);
            lblUploadBukti.Location = new Point(23, 622);
            lblUploadBukti.Name = "lblUploadBukti";
            lblUploadBukti.Size = new Size(244, 25);
            lblUploadBukti.TabIndex = 28;
            lblUploadBukti.Text = "Upload Bukti Pembayaran";
            // 
            // pnlUpload
            // 
            pnlUpload.BackColor = Color.White;
            pnlUpload.BorderStyle = BorderStyle.FixedSingle;
            pnlUpload.Controls.Add(btnPilihGambar);
            pnlUpload.Controls.Add(picUploadIcon);
            pnlUpload.Controls.Add(lblUploadFormat);
            pnlUpload.Cursor = Cursors.Hand;
            pnlUpload.Location = new Point(23, 662);
            pnlUpload.Margin = new Padding(3, 4, 3, 4);
            pnlUpload.Name = "pnlUpload";
            pnlUpload.Size = new Size(424, 119);
            pnlUpload.TabIndex = 29;
            pnlUpload.Paint += pnlUpload_Paint;
            // 
            // btnPilihGambar
            // 
            btnPilihGambar.BackColor = Color.FromArgb(108, 117, 125);
            btnPilihGambar.FlatAppearance.BorderSize = 0;
            btnPilihGambar.FlatStyle = FlatStyle.Flat;
            btnPilihGambar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPilihGambar.ForeColor = Color.White;
            btnPilihGambar.Location = new Point(79, 29);
            btnPilihGambar.Margin = new Padding(3, 4, 3, 4);
            btnPilihGambar.Name = "btnPilihGambar";
            btnPilihGambar.Size = new Size(146, 31);
            btnPilihGambar.TabIndex = 17;
            btnPilihGambar.Text = "Pilih Gambar";
            btnPilihGambar.UseVisualStyleBackColor = false;
            btnPilihGambar.Click += btnPilihGambar_Click;
            // 
            // picUploadIcon
            // 
            picUploadIcon.Location = new Point(17, 29);
            picUploadIcon.Margin = new Padding(3, 4, 3, 4);
            picUploadIcon.Name = "picUploadIcon";
            picUploadIcon.Size = new Size(46, 53);
            picUploadIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picUploadIcon.TabIndex = 0;
            picUploadIcon.TabStop = false;
            picUploadIcon.Click += picUploadIcon_Click;
            // 
            // lblUploadFormat
            // 
            lblUploadFormat.AutoSize = true;
            lblUploadFormat.Font = new Font("Segoe UI", 8F);
            lblUploadFormat.ForeColor = Color.FromArgb(130, 130, 130);
            lblUploadFormat.Location = new Point(74, 64);
            lblUploadFormat.Name = "lblUploadFormat";
            lblUploadFormat.Size = new Size(199, 19);
            lblUploadFormat.TabIndex = 2;
            lblUploadFormat.Text = "Format: JPG, PNG (Maks. 2MB)";
            lblUploadFormat.Click += lblUploadFormat_Click;
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Font = new Font("Segoe UI", 9F);
            lblAlamat.ForeColor = Color.Black;
            lblAlamat.Location = new Point(23, 252);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(57, 20);
            lblAlamat.TabIndex = 30;
            lblAlamat.Text = "Alamat";
            lblAlamat.Click += lblAlamat_Click;
            // 
            // txtAlamat
            // 
            txtAlamat.BorderStyle = BorderStyle.FixedSingle;
            txtAlamat.Font = new Font("Segoe UI", 9F);
            txtAlamat.Location = new Point(194, 250);
            txtAlamat.Margin = new Padding(3, 4, 3, 4);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.ScrollBars = RichTextBoxScrollBars.None;
            txtAlamat.Size = new Size(274, 111);
            txtAlamat.TabIndex = 31;
            txtAlamat.Text = "";
            txtAlamat.TextChanged += txtAlamat_TextChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblTransaksi);
            flowLayoutPanel1.Location = new Point(14, 55);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(462, 735);
            flowLayoutPanel1.TabIndex = 32;
            // 
            // lblTransaksi
            // 
            lblTransaksi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTransaksi.AutoSize = true;
            lblTransaksi.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTransaksi.ForeColor = Color.Black;
            lblTransaksi.Location = new Point(3, 0);
            lblTransaksi.Name = "lblTransaksi";
            lblTransaksi.Size = new Size(81, 22);
            lblTransaksi.TabIndex = 33;
            lblTransaksi.Text = "id transaksi";
            lblTransaksi.Click += lblTransaksi_Click;
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblAlamat);
            Controls.Add(txtAlamat);
            Controls.Add(lblInstruksi);
            Controls.Add(lblStep1);
            Controls.Add(lblStep2);
            Controls.Add(lblStep3);
            Controls.Add(lblUploadBukti);
            Controls.Add(pnlUpload);
            Controls.Add(lblDetailPembayaran);
            Controls.Add(lblIDTransaksi);
            Controls.Add(lblTotalBayar);
            Controls.Add(txtTotalBayar);
            Controls.Add(lblNama);
            Controls.Add(txtNama);
            Controls.Add(lblMetodePembayaran);
            Controls.Add(cmbMetodePembayaran);
            Controls.Add(lblBankTujuan);
            Controls.Add(cmbBankTujuan);
            Controls.Add(lblInfoTitle);
            Controls.Add(lblRingkasan);
            Controls.Add(dgvPesanan);
            Controls.Add(lblSepTotal);
            Controls.Add(lblTotalLabel);
            Controls.Add(lblTotalVal);
            Controls.Add(btnLanjut);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Checkout";
            Size = new Size(1134, 856);
            ((System.ComponentModel.ISupportInitialize)dgvPesanan).EndInit();
            pnlUpload.ResumeLayout(false);
            pnlUpload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUploadIcon).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblInfoTitle;
        private System.Windows.Forms.Label lblRingkasan;
        private System.Windows.Forms.DataGridView dgvPesanan;
        private System.Windows.Forms.Label lblSepTotal;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotalVal;
        private System.Windows.Forms.Button btnLanjut;
        private DataGridViewTextBoxColumn colProduk;
        private DataGridViewTextBoxColumn colJumlah;
        private DataGridViewTextBoxColumn colSubtotal;
        private Label lblIDTransaksi;
        private Label lblTotalBayar;
        private TextBox txtTotalBayar;
        private Label lblNama;
        private TextBox txtNama;
        private Label lblMetodePembayaran;
        private ComboBox cmbMetodePembayaran;
        private Label lblBankTujuan;
        private ComboBox cmbBankTujuan;
        private Label lblDetailPembayaran;
        private Label lblInstruksi;
        private Label lblStep1;
        private Label lblStep2;
        private Label lblStep3;
        private Label lblUploadBukti;
        private Panel pnlUpload;
        private Button btnPilihGambar;
        private PictureBox picUploadIcon;
        private Label lblUploadFormat;
        private Label lblAlamat;
        private RichTextBox txtAlamat;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblTransaksi;
    }
}