namespace bibitku_app
{
    partial class TransaksiMasuk
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            lblJudul = new Label();
            dtpDari = new DateTimePicker();
            lblSampai = new Label();
            dtpSampai = new DateTimePicker();
            cmbStatus = new ComboBox();
            txtCari = new TextBox();
            dgvTransaksi = new DataGridView();
            colIdTransaksi = new DataGridViewTextBoxColumn();
            colTanggal = new DataGridViewTextBoxColumn();
            colPembeli = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colMetode = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colAksi = new DataGridViewButtonColumn();
            btnPrev = new Button();
            btnNext = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).BeginInit();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.FromArgb(30, 30, 30);
            lblJudul.Location = new Point(23, 14);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(174, 23);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Transaksi Masuk";
            // 
            // dtpDari
            // 
            dtpDari.Format = DateTimePickerFormat.Short;
            dtpDari.Location = new Point(23, 73);
            dtpDari.Margin = new Padding(3, 4, 3, 4);
            dtpDari.Name = "dtpDari";
            dtpDari.Size = new Size(148, 27);
            dtpDari.TabIndex = 1;
            // 
            // lblSampai
            // 
            lblSampai.AutoSize = true;
            lblSampai.BackColor = Color.Transparent;
            lblSampai.Font = new Font("Segoe UI", 9F);
            lblSampai.Location = new Point(171, 76);
            lblSampai.Name = "lblSampai";
            lblSampai.Size = new Size(24, 20);
            lblSampai.TabIndex = 2;
            lblSampai.Text = "—";
            // 
            // dtpSampai
            // 
            dtpSampai.Format = DateTimePickerFormat.Short;
            dtpSampai.Location = new Point(194, 73);
            dtpSampai.Margin = new Padding(3, 4, 3, 4);
            dtpSampai.Name = "dtpSampai";
            dtpSampai.Size = new Size(148, 27);
            dtpSampai.TabIndex = 3;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Items.AddRange(new object[] { "Semua Status", "Selesai", "Diproses", "Dibatalkan" });
            cmbStatus.Location = new Point(360, 73);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(171, 28);
            cmbStatus.TabIndex = 4;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(709, 73);
            txtCari.Margin = new Padding(3, 4, 3, 4);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "Cari transaksi...";
            txtCari.Size = new Size(251, 27);
            txtCari.TabIndex = 5;
            // 
            // dgvTransaksi
            // 
            dgvTransaksi.AllowUserToAddRows = false;
            dgvTransaksi.AllowUserToDeleteRows = false;
            dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransaksi.BackgroundColor = Color.White;
            dgvTransaksi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(80, 80, 80);
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaksi.Columns.AddRange(new DataGridViewColumn[] { colIdTransaksi, colTanggal, colPembeli, colTotal, colMetode, colStatus, colAksi });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(235, 248, 235);
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvTransaksi.DefaultCellStyle = dataGridViewCellStyle12;
            dgvTransaksi.EnableHeadersVisualStyles = false;
            dgvTransaksi.GridColor = Color.FromArgb(230, 230, 230);
            dgvTransaksi.Location = new Point(23, 127);
            dgvTransaksi.Margin = new Padding(3, 4, 3, 4);
            dgvTransaksi.Name = "dgvTransaksi";
            dgvTransaksi.ReadOnly = true;
            dgvTransaksi.RowHeadersVisible = false;
            dgvTransaksi.RowHeadersWidth = 51;
            dgvTransaksi.RowTemplate.Height = 38;
            dgvTransaksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransaksi.Size = new Size(937, 507);
            dgvTransaksi.TabIndex = 6;
            // 
            // colIdTransaksi
            // 
            colIdTransaksi.HeaderText = "ID Transaksi";
            colIdTransaksi.MinimumWidth = 6;
            colIdTransaksi.Name = "colIdTransaksi";
            colIdTransaksi.ReadOnly = true;
            // 
            // colTanggal
            // 
            colTanggal.FillWeight = 90F;
            colTanggal.HeaderText = "Tanggal";
            colTanggal.MinimumWidth = 6;
            colTanggal.Name = "colTanggal";
            colTanggal.ReadOnly = true;
            // 
            // colPembeli
            // 
            colPembeli.FillWeight = 140F;
            colPembeli.HeaderText = "Pembeli";
            colPembeli.MinimumWidth = 6;
            colPembeli.Name = "colPembeli";
            colPembeli.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // colMetode
            // 
            colMetode.FillWeight = 130F;
            colMetode.HeaderText = "Metode Pembayaran";
            colMetode.MinimumWidth = 6;
            colMetode.Name = "colMetode";
            colMetode.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 80F;
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colAksi
            // 
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(40, 40, 40);
            colAksi.DefaultCellStyle = dataGridViewCellStyle11;
            colAksi.FillWeight = 70F;
            colAksi.FlatStyle = FlatStyle.Flat;
            colAksi.HeaderText = "Aksi";
            colAksi.MinimumWidth = 6;
            colAksi.Name = "colAksi";
            colAksi.ReadOnly = true;
            colAksi.Text = "Detail";
            colAksi.UseColumnTextForButtonValue = true;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.White;
            btnPrev.FlatAppearance.BorderColor = Color.Black;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("Segoe UI", 9F);
            btnPrev.ForeColor = Color.FromArgb(60, 60, 60);
            btnPrev.Location = new Point(880, 642);
            btnPrev.Margin = new Padding(3, 4, 3, 4);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(37, 40);
            btnPrev.TabIndex = 8;
            btnPrev.Text = "<";
            btnPrev.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.White;
            btnNext.FlatAppearance.BorderColor = Color.Black;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 9F);
            btnNext.ForeColor = Color.FromArgb(60, 60, 60);
            btnNext.Location = new Point(923, 642);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(37, 40);
            btnNext.TabIndex = 12;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 40);
            label2.Name = "label2";
            label2.Size = new Size(305, 32);
            label2.TabIndex = 13;
            label2.Text = "Kelola dan pantau seluruh transaksi pembelian bibit\n\n";
            // 
            // TransaksiMasuk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblJudul);
            Controls.Add(dtpDari);
            Controls.Add(dtpSampai);
            Controls.Add(cmbStatus);
            Controls.Add(txtCari);
            Controls.Add(dgvTransaksi);
            Controls.Add(btnPrev);
            Controls.Add(btnNext);
            Controls.Add(lblSampai);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TransaksiMasuk";
            Size = new Size(983, 720);
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.DateTimePicker dtpDari;
        private System.Windows.Forms.Label lblSampai;
        private System.Windows.Forms.DateTimePicker dtpSampai;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.DataGridView dgvTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPembeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colAksi;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private Label label2;
    }
}