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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblInfoTitle = new Label();
            lblNama = new Label();
            txtNama = new TextBox();
            lblTelepon = new Label();
            txtTelepon = new TextBox();
            lblAlamat = new Label();
            txtAlamat = new RichTextBox();
            lblRingkasan = new Label();
            dgvPesanan = new DataGridView();
            colProduk = new DataGridViewTextBoxColumn();
            colJumlah = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            lblSepTotal = new Label();
            lblTotalLabel = new Label();
            lblTotalVal = new Label();
            btnLanjut = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPesanan).BeginInit();
            SuspendLayout();
            // 
            // lblInfoTitle
            // 
            lblInfoTitle.AutoSize = true;
            lblInfoTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblInfoTitle.Location = new Point(23, 27);
            lblInfoTitle.Name = "lblInfoTitle";
            lblInfoTitle.Size = new Size(204, 25);
            lblInfoTitle.TabIndex = 0;
            lblInfoTitle.Text = "Informasi Pengiriman";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 9F);
            lblNama.Location = new Point(23, 87);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(49, 20);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama";
            // 
            // txtNama
            // 
            txtNama.Font = new Font("Segoe UI", 9F);
            txtNama.Location = new Point(23, 117);
            txtNama.Margin = new Padding(3, 4, 3, 4);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(319, 27);
            txtNama.TabIndex = 2;
            // 
            // lblTelepon
            // 
            lblTelepon.AutoSize = true;
            lblTelepon.Font = new Font("Segoe UI", 9F);
            lblTelepon.Location = new Point(23, 180);
            lblTelepon.Name = "lblTelepon";
            lblTelepon.Size = new Size(89, 20);
            lblTelepon.TabIndex = 3;
            lblTelepon.Text = "No. Telepon";
            // 
            // txtTelepon
            // 
            txtTelepon.Font = new Font("Segoe UI", 9F);
            txtTelepon.Location = new Point(23, 211);
            txtTelepon.Margin = new Padding(3, 4, 3, 4);
            txtTelepon.Name = "txtTelepon";
            txtTelepon.Size = new Size(319, 27);
            txtTelepon.TabIndex = 4;
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Font = new Font("Segoe UI", 9F);
            lblAlamat.Location = new Point(23, 273);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(57, 20);
            lblAlamat.TabIndex = 5;
            lblAlamat.Text = "Alamat";
            // 
            // txtAlamat
            // 
            txtAlamat.BorderStyle = BorderStyle.FixedSingle;
            txtAlamat.Font = new Font("Segoe UI", 9F);
            txtAlamat.Location = new Point(23, 304);
            txtAlamat.Margin = new Padding(3, 4, 3, 4);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.ScrollBars = RichTextBoxScrollBars.None;
            txtAlamat.Size = new Size(319, 172);
            txtAlamat.TabIndex = 6;
            txtAlamat.Text = "";
            // 
            // lblRingkasan
            // 
            lblRingkasan.AutoSize = true;
            lblRingkasan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRingkasan.Location = new Point(400, 27);
            lblRingkasan.Name = "lblRingkasan";
            lblRingkasan.Size = new Size(182, 25);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPesanan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPesanan.Columns.AddRange(new DataGridViewColumn[] { colProduk, colJumlah, colSubtotal });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvPesanan.DefaultCellStyle = dataGridViewCellStyle4;
            dgvPesanan.EnableHeadersVisualStyles = false;
            dgvPesanan.GridColor = Color.FromArgb(220, 220, 220);
            dgvPesanan.Location = new Point(400, 73);
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
            this.dgvPesanan.Rows.Add("Bibit Mangga Arumanis", "2", "Rp 50.000");
            this.dgvPesanan.Rows.Add("Bibit Jeruk Siam", "3", "Rp 60.000");
            this.dgvPesanan.Rows.Add("Bibit Alpukat Miki", "1", "Rp 18.000");
            // 
            // colProduk
            // 
            dataGridViewCellStyle2.BackColor = Color.White;
            colProduk.DefaultCellStyle = dataGridViewCellStyle2;
            colProduk.FillWeight = 220F;
            colProduk.HeaderText = "Produk";
            colProduk.MinimumWidth = 6;
            colProduk.Name = "colProduk";
            colProduk.ReadOnly = true;
            // 
            // colJumlah
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colJumlah.DefaultCellStyle = dataGridViewCellStyle3;
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
            lblSepTotal.Location = new Point(400, 487);
            lblSepTotal.Name = "lblSepTotal";
            lblSepTotal.Size = new Size(560, 1);
            lblSepTotal.TabIndex = 9;
            // 
            // lblTotalLabel
            // 
            lblTotalLabel.AutoSize = true;
            lblTotalLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalLabel.ForeColor = Color.FromArgb(30, 30, 30);
            lblTotalLabel.Location = new Point(400, 507);
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
            lblTotalVal.Location = new Point(777, 500);
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
            btnLanjut.Location = new Point(640, 560);
            btnLanjut.Margin = new Padding(3, 4, 3, 4);
            btnLanjut.Name = "btnLanjut";
            btnLanjut.Size = new Size(320, 53);
            btnLanjut.TabIndex = 12;
            btnLanjut.Text = "🖨  Lanjut ke Pembayaran";
            btnLanjut.UseVisualStyleBackColor = false;
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblInfoTitle);
            Controls.Add(lblNama);
            Controls.Add(txtNama);
            Controls.Add(lblTelepon);
            Controls.Add(txtTelepon);
            Controls.Add(lblAlamat);
            Controls.Add(txtAlamat);
            Controls.Add(lblRingkasan);
            Controls.Add(dgvPesanan);
            Controls.Add(lblSepTotal);
            Controls.Add(lblTotalLabel);
            Controls.Add(lblTotalVal);
            Controls.Add(btnLanjut);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Checkout";
            Size = new Size(983, 653);
            ((System.ComponentModel.ISupportInitialize)dgvPesanan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblInfoTitle;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblTelepon;
        private System.Windows.Forms.TextBox txtTelepon;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.RichTextBox txtAlamat;
        private System.Windows.Forms.Label lblRingkasan;
        private System.Windows.Forms.DataGridView dgvPesanan;
        private System.Windows.Forms.Label lblSepTotal;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotalVal;
        private System.Windows.Forms.Button btnLanjut;
        private DataGridViewTextBoxColumn colProduk;
        private DataGridViewTextBoxColumn colJumlah;
        private DataGridViewTextBoxColumn colSubtotal;
    }
}