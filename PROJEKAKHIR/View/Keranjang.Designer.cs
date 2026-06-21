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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
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
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(34, 139, 34);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvKeranjang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvKeranjang.ColumnHeadersHeight = 42;
            dgvKeranjang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvKeranjang.Columns.AddRange(new DataGridViewColumn[] { colNo, colProduk, colHarga, colKurang, colJumlah, colTambah, colSubtotal, colHapus });
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = SystemColors.Window;
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle20.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle20.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle20.SelectionBackColor = Color.FromArgb(232, 245, 233);
            dataGridViewCellStyle20.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.False;
            dgvKeranjang.DefaultCellStyle = dataGridViewCellStyle20;
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
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.White;
            colNo.DefaultCellStyle = dataGridViewCellStyle12;
            colNo.FillWeight = 6F;
            colNo.HeaderText = "No.";
            colNo.MinimumWidth = 50;
            colNo.Name = "colNo";
            // 
            // colProduk
            // 
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colProduk.DefaultCellStyle = dataGridViewCellStyle13;
            colProduk.FillWeight = 28F;
            colProduk.HeaderText = "Produk";
            colProduk.MinimumWidth = 6;
            colProduk.Name = "colProduk";
            // 
            // colHarga
            // 
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colHarga.DefaultCellStyle = dataGridViewCellStyle14;
            colHarga.FillWeight = 14F;
            colHarga.HeaderText = "Harga";
            colHarga.MinimumWidth = 6;
            colHarga.Name = "colHarga";
            // 
            // colKurang
            // 
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            colKurang.DefaultCellStyle = dataGridViewCellStyle15;
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
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colJumlah.DefaultCellStyle = dataGridViewCellStyle16;
            colJumlah.FillWeight = 7F;
            colJumlah.HeaderText = "Jumlah";
            colJumlah.MinimumWidth = 60;
            colJumlah.Name = "colJumlah";
            // 
            // colTambah
            // 
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            colTambah.DefaultCellStyle = dataGridViewCellStyle17;
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
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colSubtotal.DefaultCellStyle = dataGridViewCellStyle18;
            colSubtotal.FillWeight = 14F;
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.MinimumWidth = 6;
            colSubtotal.Name = "colSubtotal";
            // 
            // colHapus
            // 
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.ForeColor = Color.FromArgb(211, 47, 47);
            colHapus.DefaultCellStyle = dataGridViewCellStyle19;
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
            btnCheckout.Click += btnCheckout_Click;
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
            Load += Keranjang_Load_1;
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