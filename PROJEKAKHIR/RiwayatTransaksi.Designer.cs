using System.Drawing.Printing;
using System.Xml.Linq;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace PROJEKAKHIR
{
    partial class RiwayatTransaksi
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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            btnSemua = new Button();
            btnSelesai = new Button();
            btnDiproses = new Button();
            btnDibatalkan = new Button();
            dgvRiwayat = new DataGridView();
            colIdTransaksi = new DataGridViewTextBoxColumn();
            colTanggal = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colAksi = new DataGridViewButtonColumn();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).BeginInit();
            SuspendLayout();
            // 
            // btnSemua
            // 
            btnSemua.BackColor = Color.ForestGreen;
            btnSemua.FlatAppearance.BorderSize = 0;
            btnSemua.FlatStyle = FlatStyle.Flat;
            btnSemua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSemua.ForeColor = Color.White;
            btnSemua.Location = new Point(23, 63);
            btnSemua.Margin = new Padding(3, 4, 3, 4);
            btnSemua.Name = "btnSemua";
            btnSemua.Size = new Size(91, 40);
            btnSemua.TabIndex = 0;
            btnSemua.Text = "Semua";
            btnSemua.UseVisualStyleBackColor = false;
            // 
            // btnSelesai
            // 
            btnSelesai.BackColor = Color.White;
            btnSelesai.FlatAppearance.BorderSize = 0;
            btnSelesai.FlatStyle = FlatStyle.Flat;
            btnSelesai.Font = new Font("Segoe UI", 9F);
            btnSelesai.ForeColor = Color.FromArgb(60, 60, 60);
            btnSelesai.Location = new Point(131, 63);
            btnSelesai.Margin = new Padding(3, 4, 3, 4);
            btnSelesai.Name = "btnSelesai";
            btnSelesai.Size = new Size(91, 40);
            btnSelesai.TabIndex = 1;
            btnSelesai.Text = "Selesai";
            btnSelesai.UseVisualStyleBackColor = false;
            // 
            // btnDiproses
            // 
            btnDiproses.BackColor = Color.White;
            btnDiproses.FlatAppearance.BorderSize = 0;
            btnDiproses.FlatStyle = FlatStyle.Flat;
            btnDiproses.Font = new Font("Segoe UI", 9F);
            btnDiproses.ForeColor = Color.FromArgb(60, 60, 60);
            btnDiproses.Location = new Point(240, 63);
            btnDiproses.Margin = new Padding(3, 4, 3, 4);
            btnDiproses.Name = "btnDiproses";
            btnDiproses.Size = new Size(91, 40);
            btnDiproses.TabIndex = 2;
            btnDiproses.Text = "Diproses";
            btnDiproses.UseVisualStyleBackColor = false;
            // 
            // btnDibatalkan
            // 
            btnDibatalkan.BackColor = Color.White;
            btnDibatalkan.FlatAppearance.BorderSize = 0;
            btnDibatalkan.FlatStyle = FlatStyle.Flat;
            btnDibatalkan.Font = new Font("Segoe UI", 9F);
            btnDibatalkan.ForeColor = Color.FromArgb(60, 60, 60);
            btnDibatalkan.Location = new Point(349, 63);
            btnDibatalkan.Margin = new Padding(3, 4, 3, 4);
            btnDibatalkan.Name = "btnDibatalkan";
            btnDibatalkan.Size = new Size(103, 40);
            btnDibatalkan.TabIndex = 3;
            btnDibatalkan.Text = "Dibatalkan";
            btnDibatalkan.UseVisualStyleBackColor = false;
            // 
            // dgvRiwayat
            // 
            dgvRiwayat.AllowUserToAddRows = false;
            dgvRiwayat.AllowUserToDeleteRows = false;
            dgvRiwayat.AllowUserToResizeRows = false;
            dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayat.BackgroundColor = Color.White;
            dgvRiwayat.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvRiwayat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayat.Columns.AddRange(new DataGridViewColumn[] { colIdTransaksi, colTanggal, colTotal, colStatus, colAksi });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(235, 248, 235);
            dataGridViewCellStyle14.SelectionForeColor = Color.Black;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgvRiwayat.DefaultCellStyle = dataGridViewCellStyle14;
            dgvRiwayat.EnableHeadersVisualStyles = false;
            dgvRiwayat.GridColor = Color.FromArgb(220, 220, 220);
            dgvRiwayat.Location = new Point(23, 123);
            dgvRiwayat.Margin = new Padding(3, 4, 3, 4);
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.ReadOnly = true;
            dgvRiwayat.RowHeadersVisible = false;
            dgvRiwayat.RowHeadersWidth = 51;
            dgvRiwayat.RowTemplate.Height = 38;
            dgvRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayat.Size = new Size(937, 480);
            dgvRiwayat.TabIndex = 4;
            // 
            // colIdTransaksi
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.White;
            colIdTransaksi.DefaultCellStyle = dataGridViewCellStyle9;
            colIdTransaksi.FillWeight = 140F;
            colIdTransaksi.HeaderText = "ID Transaksi";
            colIdTransaksi.MinimumWidth = 6;
            colIdTransaksi.Name = "colIdTransaksi";
            colIdTransaksi.ReadOnly = true;
            // 
            // colTanggal
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colTanggal.DefaultCellStyle = dataGridViewCellStyle10;
            colTanggal.FillWeight = 120F;
            colTanggal.HeaderText = "Tanggal";
            colTanggal.MinimumWidth = 6;
            colTanggal.Name = "colTanggal";
            colTanggal.ReadOnly = true;
            // 
            // colTotal
            // 
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colTotal.DefaultCellStyle = dataGridViewCellStyle11;
            colTotal.FillWeight = 120F;
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // colStatus
            // 
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colStatus.DefaultCellStyle = dataGridViewCellStyle12;
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colAksi
            // 
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.White;
            dataGridViewCellStyle13.ForeColor = Color.FromArgb(40, 40, 40);
            colAksi.DefaultCellStyle = dataGridViewCellStyle13;
            colAksi.FillWeight = 80F;
            colAksi.FlatStyle = FlatStyle.Flat;
            colAksi.HeaderText = "Aksi";
            colAksi.MinimumWidth = 6;
            colAksi.Name = "colAksi";
            colAksi.ReadOnly = true;
            colAksi.Text = "Detail";
            colAksi.UseColumnTextForButtonValue = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(33, 33, 33);
            lblTitle.Location = new Point(23, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(217, 27);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Riwayat Transaksi";
            // 
            // RiwayatTransaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblTitle);
            Controls.Add(btnSemua);
            Controls.Add(btnSelesai);
            Controls.Add(btnDiproses);
            Controls.Add(btnDibatalkan);
            Controls.Add(dgvRiwayat);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RiwayatTransaksi";
            Size = new Size(983, 632);
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSemua;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Button btnDiproses;
        private System.Windows.Forms.Button btnDibatalkan;
        private System.Windows.Forms.DataGridView dgvRiwayat;
        private DataGridViewTextBoxColumn colIdTransaksi;
        private DataGridViewTextBoxColumn colTanggal;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn colAksi;
        private Label lblTitle;
    }
}