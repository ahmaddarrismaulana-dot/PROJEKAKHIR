namespace PROJEKAKHIR
{
    partial class Keranjang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            lblTitle = new Label();
            dgvKeranjang = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colProduk = new DataGridViewTextBoxColumn();
            colHarga = new DataGridViewTextBoxColumn();
            colKurang = new DataGridViewButtonColumn();
            colJumlah = new DataGridViewTextBoxColumn();
            colTambah = new DataGridViewButtonColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            colHapus = new DataGridViewButtonColumn();
            lblTotalBelanjaTitle = new Label();
            lblTotalBelanjaValue = new Label();
            btnCheckout = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(33, 33, 33);
            lblTitle.Location = new Point(29, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(220, 27);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Keranjang Belanja";
            // 
            // dgvKeranjang
            // 
            dgvKeranjang.AllowUserToAddRows = false;
            dgvKeranjang.AllowUserToDeleteRows = false;
            dgvKeranjang.AllowUserToResizeColumns = false;
            dgvKeranjang.AllowUserToResizeRows = false;
            dgvKeranjang.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvKeranjang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKeranjang.BackgroundColor = Color.White;
            dgvKeranjang.BorderStyle = BorderStyle.None;
            dgvKeranjang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvKeranjang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(34, 139, 34);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvKeranjang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKeranjang.ColumnHeadersHeight = 42;
            dgvKeranjang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvKeranjang.Columns.AddRange(new DataGridViewColumn[] { colNo, colProduk, colHarga, colKurang, colJumlah, colTambah, colSubtotal, colHapus });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle10.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(232, 245, 233);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvKeranjang.DefaultCellStyle = dataGridViewCellStyle10;
            dgvKeranjang.EnableHeadersVisualStyles = false;
            dgvKeranjang.GridColor = Color.White;
            dgvKeranjang.Location = new Point(29, 93);
            dgvKeranjang.Margin = new Padding(3, 4, 3, 4);
            dgvKeranjang.MultiSelect = false;
            dgvKeranjang.Name = "dgvKeranjang";
            dgvKeranjang.RowHeadersVisible = false;
            dgvKeranjang.RowHeadersWidth = 51;
            dgvKeranjang.RowTemplate.Height = 48;
            dgvKeranjang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKeranjang.Size = new Size(667, 373);
            dgvKeranjang.TabIndex = 1;
            dgvKeranjang.CellContentClick += dgvKeranjang_CellContentClick_1;
            // 
            // colNo
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            colNo.DefaultCellStyle = dataGridViewCellStyle2;
            colNo.FillWeight = 6F;
            colNo.HeaderText = "No.";
            colNo.MinimumWidth = 50;
            colNo.Name = "colNo";
            // 
            // colProduk
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colProduk.DefaultCellStyle = dataGridViewCellStyle3;
            colProduk.FillWeight = 28F;
            colProduk.HeaderText = "Produk";
            colProduk.MinimumWidth = 6;
            colProduk.Name = "colProduk";
            // 
            // colHarga
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colHarga.DefaultCellStyle = dataGridViewCellStyle4;
            colHarga.FillWeight = 14F;
            colHarga.HeaderText = "Harga";
            colHarga.MinimumWidth = 6;
            colHarga.Name = "colHarga";
            // 
            // colKurang
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            colKurang.DefaultCellStyle = dataGridViewCellStyle5;
            colKurang.FillWeight = 5F;
            colKurang.FlatStyle = FlatStyle.Flat;
            colKurang.HeaderText = "";
            colKurang.MinimumWidth = 40;
            colKurang.Name = "colKurang";
            colKurang.Text = "-";
            colKurang.UseColumnTextForButtonValue = true;
            // 
            // colJumlah
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colJumlah.DefaultCellStyle = dataGridViewCellStyle6;
            colJumlah.FillWeight = 7F;
            colJumlah.HeaderText = "Jumlah";
            colJumlah.MinimumWidth = 60;
            colJumlah.Name = "colJumlah";
            // 
            // colTambah
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            colTambah.DefaultCellStyle = dataGridViewCellStyle7;
            colTambah.FillWeight = 5F;
            colTambah.FlatStyle = FlatStyle.Flat;
            colTambah.HeaderText = "";
            colTambah.MinimumWidth = 40;
            colTambah.Name = "colTambah";
            colTambah.Text = "+";
            colTambah.UseColumnTextForButtonValue = true;
            // 
            // colSubtotal
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colSubtotal.DefaultCellStyle = dataGridViewCellStyle8;
            colSubtotal.FillWeight = 14F;
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.MinimumWidth = 6;
            colSubtotal.Name = "colSubtotal";
            // 
            // colHapus
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(211, 47, 47);
            colHapus.DefaultCellStyle = dataGridViewCellStyle9;
            colHapus.FillWeight = 11F;
            colHapus.FlatStyle = FlatStyle.Flat;
            colHapus.HeaderText = "Hapus";
            colHapus.MinimumWidth = 80;
            colHapus.Name = "colHapus";
            colHapus.Text = "Hapus";
            colHapus.UseColumnTextForButtonValue = true;
            // 
            // lblTotalBelanjaTitle
            // 
            lblTotalBelanjaTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalBelanjaTitle.AutoSize = true;
            lblTotalBelanjaTitle.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalBelanjaTitle.ForeColor = Color.FromArgb(33, 33, 33);
            lblTotalBelanjaTitle.Location = new Point(489, 488);
            lblTotalBelanjaTitle.Name = "lblTotalBelanjaTitle";
            lblTotalBelanjaTitle.Size = new Size(117, 20);
            lblTotalBelanjaTitle.TabIndex = 2;
            lblTotalBelanjaTitle.Text = "Total Belanja";
            // 
            // lblTotalBelanjaValue
            // 
            lblTotalBelanjaValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalBelanjaValue.AutoSize = true;
            lblTotalBelanjaValue.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalBelanjaValue.ForeColor = Color.FromArgb(34, 139, 34);
            lblTotalBelanjaValue.Location = new Point(489, 521);
            lblTotalBelanjaValue.Name = "lblTotalBelanjaValue";
            lblTotalBelanjaValue.Size = new Size(91, 39);
            lblTotalBelanjaValue.TabIndex = 3;
            lblTotalBelanjaValue.Text = "Rp 0";
            // 
            // btnCheckout
            // 
            btnCheckout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCheckout.BackColor = Color.FromArgb(34, 139, 34);
            btnCheckout.Cursor = Cursors.Hand;
            btnCheckout.FlatAppearance.BorderSize = 0;
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(507, 581);
            btnCheckout.Margin = new Padding(3, 4, 3, 4);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(189, 56);
            btnCheckout.TabIndex = 4;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            // 
            // Keranjang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnCheckout);
            Controls.Add(lblTotalBelanjaValue);
            Controls.Add(lblTotalBelanjaTitle);
            Controls.Add(dgvKeranjang);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Keranjang";
            Size = new Size(946, 827);
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvKeranjang;
        private System.Windows.Forms.Label lblTotalBelanjaTitle;
        private System.Windows.Forms.Label lblTotalBelanjaValue;
        private System.Windows.Forms.Button btnCheckout;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colProduk;
        private DataGridViewTextBoxColumn colHarga;
        private DataGridViewButtonColumn colKurang;
        private DataGridViewTextBoxColumn colJumlah;
        private DataGridViewButtonColumn colTambah;
        private DataGridViewTextBoxColumn colSubtotal;
        private DataGridViewButtonColumn colHapus;
    }
}