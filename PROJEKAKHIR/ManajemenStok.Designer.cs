namespace bibitku_app
{
    partial class ManajemenStok
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblJudul = new Label();
            lblSubJudul = new Label();
            panelTotalStok = new Panel();
            lblIconTotal = new Label();
            lblTotalStokTitle = new Label();
            lblTotalStokVal = new Label();
            panelMenipis = new Panel();
            lblIconMenipis = new Label();
            lblMenipisTitle = new Label();
            lblMenipisVal = new Label();
            lblMenipisSub = new Label();
            panelHabis = new Panel();
            lblIconHabis = new Label();
            lblHabisTitle = new Label();
            lblHabisVal = new Label();
            panelPenyesuaian = new Panel();
            lblPenyesuaian = new Label();
            lblPilihBibit = new Label();
            cmbPilihBibit = new ComboBox();
            lblTipePenyesuaian = new Label();
            rbStokMasuk = new RadioButton();
            rbStokKeluar = new RadioButton();
            rbSetManual = new RadioButton();
            lblJumlah = new Label();
            numJumlah = new NumericUpDown();
            btnSimpan = new Button();
            panelStatus = new Panel();
            lblStatusTitle = new Label();
            dgvStok = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colKategori = new DataGridViewTextBoxColumn();
            colStok = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            panelTotalStok.SuspendLayout();
            panelMenipis.SuspendLayout();
            panelHabis.SuspendLayout();
            panelPenyesuaian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlah).BeginInit();
            panelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStok).BeginInit();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.FromArgb(30, 30, 30);
            lblJudul.Location = new Point(23, 20);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(170, 23);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Manajemen Stok";
            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubJudul.ForeColor = Color.Black;
            lblSubJudul.Location = new Point(23, 48);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(232, 16);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Kelola stok bibit dan pantau perubahan";
            // 
            // panelTotalStok
            // 
            panelTotalStok.BackColor = Color.White;
            panelTotalStok.BorderStyle = BorderStyle.FixedSingle;
            panelTotalStok.Controls.Add(lblIconTotal);
            panelTotalStok.Controls.Add(lblTotalStokTitle);
            panelTotalStok.Controls.Add(lblTotalStokVal);
            panelTotalStok.Location = new Point(23, 80);
            panelTotalStok.Margin = new Padding(3, 4, 3, 4);
            panelTotalStok.Name = "panelTotalStok";
            panelTotalStok.Size = new Size(297, 159);
            panelTotalStok.TabIndex = 2;
            // 
            // lblIconTotal
            // 
            lblIconTotal.AutoSize = true;
            lblIconTotal.Font = new Font("Segoe UI", 18F);
            lblIconTotal.ForeColor = Color.FromArgb(40, 167, 69);
            lblIconTotal.Location = new Point(14, 20);
            lblIconTotal.Name = "lblIconTotal";
            lblIconTotal.Size = new Size(59, 41);
            lblIconTotal.TabIndex = 0;
            lblIconTotal.Text = "📦";
            // 
            // lblTotalStokTitle
            // 
            lblTotalStokTitle.AutoSize = true;
            lblTotalStokTitle.Font = new Font("Segoe UI", 9F);
            lblTotalStokTitle.ForeColor = Color.FromArgb(100, 100, 100);
            lblTotalStokTitle.Location = new Point(14, 77);
            lblTotalStokTitle.Name = "lblTotalStokTitle";
            lblTotalStokTitle.Size = new Size(75, 20);
            lblTotalStokTitle.TabIndex = 1;
            lblTotalStokTitle.Text = "Total Stok";
            // 
            // lblTotalStokVal
            // 
            lblTotalStokVal.AutoSize = true;
            lblTotalStokVal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalStokVal.ForeColor = Color.FromArgb(40, 167, 69);
            lblTotalStokVal.Location = new Point(11, 100);
            lblTotalStokVal.Name = "lblTotalStokVal";
            lblTotalStokVal.Size = new Size(73, 32);
            lblTotalStokVal.TabIndex = 2;
            lblTotalStokVal.Text = "0 pcs";
            // 
            // panelMenipis
            // 
            panelMenipis.BackColor = Color.White;
            panelMenipis.BorderStyle = BorderStyle.FixedSingle;
            panelMenipis.Controls.Add(lblIconMenipis);
            panelMenipis.Controls.Add(lblMenipisTitle);
            panelMenipis.Controls.Add(lblMenipisVal);
            panelMenipis.Controls.Add(lblMenipisSub);
            panelMenipis.Location = new Point(343, 80);
            panelMenipis.Margin = new Padding(3, 4, 3, 4);
            panelMenipis.Name = "panelMenipis";
            panelMenipis.Size = new Size(297, 159);
            panelMenipis.TabIndex = 3;
            // 
            // lblIconMenipis
            // 
            lblIconMenipis.AutoSize = true;
            lblIconMenipis.Font = new Font("Segoe UI", 18F);
            lblIconMenipis.ForeColor = Color.FromArgb(255, 153, 0);
            lblIconMenipis.Location = new Point(14, 20);
            lblIconMenipis.Name = "lblIconMenipis";
            lblIconMenipis.Size = new Size(59, 41);
            lblIconMenipis.TabIndex = 0;
            lblIconMenipis.Text = "⚠️";
            // 
            // lblMenipisTitle
            // 
            lblMenipisTitle.AutoSize = true;
            lblMenipisTitle.Font = new Font("Segoe UI", 9F);
            lblMenipisTitle.ForeColor = Color.FromArgb(100, 100, 100);
            lblMenipisTitle.Location = new Point(14, 77);
            lblMenipisTitle.Name = "lblMenipisTitle";
            lblMenipisTitle.Size = new Size(94, 20);
            lblMenipisTitle.TabIndex = 1;
            lblMenipisTitle.Text = "Stok Menipis";
            lblMenipisTitle.Click += lblMenipisTitle_Click;
            // 
            // lblMenipisVal
            // 
            lblMenipisVal.AutoSize = true;
            lblMenipisVal.BackColor = Color.Transparent;
            lblMenipisVal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblMenipisVal.ForeColor = Color.FromArgb(255, 153, 0);
            lblMenipisVal.Location = new Point(11, 100);
            lblMenipisVal.Name = "lblMenipisVal";
            lblMenipisVal.Size = new Size(86, 32);
            lblMenipisVal.TabIndex = 2;
            lblMenipisVal.Text = "0 item";
            // 
            // lblMenipisSub
            // 
            lblMenipisSub.AutoSize = true;
            lblMenipisSub.Font = new Font("Segoe UI", 8F);
            lblMenipisSub.ForeColor = Color.FromArgb(150, 150, 150);
            lblMenipisSub.Location = new Point(14, 131);
            lblMenipisSub.Name = "lblMenipisSub";
            lblMenipisSub.Size = new Size(63, 19);
            lblMenipisSub.TabIndex = 3;
            lblMenipisSub.Text = "< 20 pcs";
            // 
            // panelHabis
            // 
            panelHabis.BackColor = Color.White;
            panelHabis.BorderStyle = BorderStyle.FixedSingle;
            panelHabis.Controls.Add(lblIconHabis);
            panelHabis.Controls.Add(lblHabisTitle);
            panelHabis.Controls.Add(lblHabisVal);
            panelHabis.Location = new Point(663, 80);
            panelHabis.Margin = new Padding(3, 4, 3, 4);
            panelHabis.Name = "panelHabis";
            panelHabis.Size = new Size(297, 159);
            panelHabis.TabIndex = 4;
            // 
            // lblIconHabis
            // 
            lblIconHabis.AutoSize = true;
            lblIconHabis.Font = new Font("Segoe UI", 18F);
            lblIconHabis.ForeColor = Color.FromArgb(220, 53, 69);
            lblIconHabis.Location = new Point(14, 20);
            lblIconHabis.Name = "lblIconHabis";
            lblIconHabis.Size = new Size(59, 41);
            lblIconHabis.TabIndex = 0;
            lblIconHabis.Text = "📦";
            // 
            // lblHabisTitle
            // 
            lblHabisTitle.AutoSize = true;
            lblHabisTitle.Font = new Font("Segoe UI", 9F);
            lblHabisTitle.ForeColor = Color.FromArgb(100, 100, 100);
            lblHabisTitle.Location = new Point(14, 77);
            lblHabisTitle.Name = "lblHabisTitle";
            lblHabisTitle.Size = new Size(80, 20);
            lblHabisTitle.TabIndex = 1;
            lblHabisTitle.Text = "Stok Habis";
            // 
            // lblHabisVal
            // 
            lblHabisVal.AutoSize = true;
            lblHabisVal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHabisVal.ForeColor = Color.FromArgb(220, 53, 69);
            lblHabisVal.Location = new Point(11, 100);
            lblHabisVal.Name = "lblHabisVal";
            lblHabisVal.Size = new Size(86, 32);
            lblHabisVal.TabIndex = 2;
            lblHabisVal.Text = "0 item";
            // 
            // panelPenyesuaian
            // 
            panelPenyesuaian.BackColor = Color.White;
            panelPenyesuaian.BorderStyle = BorderStyle.FixedSingle;
            panelPenyesuaian.Controls.Add(lblPenyesuaian);
            panelPenyesuaian.Controls.Add(lblPilihBibit);
            panelPenyesuaian.Controls.Add(cmbPilihBibit);
            panelPenyesuaian.Controls.Add(lblTipePenyesuaian);
            panelPenyesuaian.Controls.Add(rbStokMasuk);
            panelPenyesuaian.Controls.Add(rbStokKeluar);
            panelPenyesuaian.Controls.Add(rbSetManual);
            panelPenyesuaian.Controls.Add(lblJumlah);
            panelPenyesuaian.Controls.Add(numJumlah);
            panelPenyesuaian.Controls.Add(btnSimpan);
            panelPenyesuaian.Location = new Point(23, 254);
            panelPenyesuaian.Margin = new Padding(3, 4, 3, 4);
            panelPenyesuaian.Name = "panelPenyesuaian";
            panelPenyesuaian.Size = new Size(365, 461);
            panelPenyesuaian.TabIndex = 5;
            // 
            // lblPenyesuaian
            // 
            lblPenyesuaian.AutoSize = true;
            lblPenyesuaian.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPenyesuaian.ForeColor = Color.FromArgb(30, 30, 30);
            lblPenyesuaian.Location = new Point(17, 14);
            lblPenyesuaian.Name = "lblPenyesuaian";
            lblPenyesuaian.Size = new Size(168, 25);
            lblPenyesuaian.TabIndex = 0;
            lblPenyesuaian.Text = "Penyesuaian Stok";
            // 
            // lblPilihBibit
            // 
            lblPilihBibit.AutoSize = true;
            lblPilihBibit.Font = new Font("Segoe UI", 9F);
            lblPilihBibit.Location = new Point(17, 43);
            lblPilihBibit.Name = "lblPilihBibit";
            lblPilihBibit.Size = new Size(82, 20);
            lblPilihBibit.TabIndex = 1;
            lblPilihBibit.Text = "Pilih Bibit *";
            // 
            // cmbPilihBibit
            // 
            cmbPilihBibit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPilihBibit.Location = new Point(17, 70);
            cmbPilihBibit.Margin = new Padding(3, 4, 3, 4);
            cmbPilihBibit.Name = "cmbPilihBibit";
            cmbPilihBibit.Size = new Size(325, 28);
            cmbPilihBibit.TabIndex = 2;
            cmbPilihBibit.SelectedIndexChanged += cmbPilihBibit_SelectedIndexChanged;
            // 
            // lblTipePenyesuaian
            // 
            lblTipePenyesuaian.AutoSize = true;
            lblTipePenyesuaian.Font = new Font("Segoe UI", 9F);
            lblTipePenyesuaian.Location = new Point(17, 110);
            lblTipePenyesuaian.Name = "lblTipePenyesuaian";
            lblTipePenyesuaian.Size = new Size(132, 20);
            lblTipePenyesuaian.TabIndex = 3;
            lblTipePenyesuaian.Text = "Tipe Penyesuaian *";
            // 
            // rbStokMasuk
            // 
            rbStokMasuk.Appearance = Appearance.Button;
            rbStokMasuk.BackColor = Color.White;
            rbStokMasuk.Checked = true;
            rbStokMasuk.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            rbStokMasuk.FlatAppearance.CheckedBackColor = Color.White;
            rbStokMasuk.FlatStyle = FlatStyle.Flat;
            rbStokMasuk.Font = new Font("Segoe UI", 9F);
            rbStokMasuk.ForeColor = Color.FromArgb(40, 40, 40);
            rbStokMasuk.Location = new Point(17, 144);
            rbStokMasuk.Margin = new Padding(3, 4, 3, 4);
            rbStokMasuk.Name = "rbStokMasuk";
            rbStokMasuk.Size = new Size(326, 48);
            rbStokMasuk.TabIndex = 4;
            rbStokMasuk.TabStop = true;
            rbStokMasuk.Text = "  ⬤  +  Stok Masuk";
            rbStokMasuk.UseVisualStyleBackColor = false;
            rbStokMasuk.CheckedChanged += rbStokMasuk_CheckedChanged;
            // 
            // rbStokKeluar
            // 
            rbStokKeluar.Appearance = Appearance.Button;
            rbStokKeluar.BackColor = Color.White;
            rbStokKeluar.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            rbStokKeluar.FlatAppearance.CheckedBackColor = Color.White;
            rbStokKeluar.FlatStyle = FlatStyle.Flat;
            rbStokKeluar.Font = new Font("Segoe UI", 9F);
            rbStokKeluar.ForeColor = Color.FromArgb(40, 40, 40);
            rbStokKeluar.Location = new Point(17, 204);
            rbStokKeluar.Margin = new Padding(3, 4, 3, 4);
            rbStokKeluar.Name = "rbStokKeluar";
            rbStokKeluar.Size = new Size(326, 48);
            rbStokKeluar.TabIndex = 5;
            rbStokKeluar.Text = "  ⬤  -  Stok Keluar";
            rbStokKeluar.UseVisualStyleBackColor = false;
            rbStokKeluar.CheckedChanged += rbStokKeluar_CheckedChanged;
            // 
            // rbSetManual
            // 
            rbSetManual.Appearance = Appearance.Button;
            rbSetManual.BackColor = Color.White;
            rbSetManual.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            rbSetManual.FlatAppearance.CheckedBackColor = Color.White;
            rbSetManual.FlatStyle = FlatStyle.Flat;
            rbSetManual.Font = new Font("Segoe UI", 9F);
            rbSetManual.ForeColor = Color.FromArgb(40, 40, 40);
            rbSetManual.Location = new Point(17, 264);
            rbSetManual.Margin = new Padding(3, 4, 3, 4);
            rbSetManual.Name = "rbSetManual";
            rbSetManual.Size = new Size(326, 48);
            rbSetManual.TabIndex = 6;
            rbSetManual.Text = "  ⬤  ✏  Set Manual";
            rbSetManual.UseVisualStyleBackColor = false;
            rbSetManual.CheckedChanged += rbSetManual_CheckedChanged;
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Font = new Font("Segoe UI", 9F);
            lblJumlah.Location = new Point(17, 330);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(65, 20);
            lblJumlah.TabIndex = 7;
            lblJumlah.Text = "Jumlah *";
            // 
            // numJumlah
            // 
            numJumlah.Location = new Point(17, 357);
            numJumlah.Margin = new Padding(3, 4, 3, 4);
            numJumlah.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numJumlah.Name = "numJumlah";
            numJumlah.Size = new Size(326, 27);
            numJumlah.TabIndex = 8;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(40, 167, 69);
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(17, 404);
            btnSimpan.Margin = new Padding(3, 4, 3, 4);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(326, 41);
            btnSimpan.TabIndex = 9;
            btnSimpan.Text = "Simpan Penyesuaian";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // panelStatus
            // 
            panelStatus.BackColor = Color.White;
            panelStatus.BorderStyle = BorderStyle.FixedSingle;
            panelStatus.Controls.Add(lblStatusTitle);
            panelStatus.Controls.Add(dgvStok);
            panelStatus.Location = new Point(411, 254);
            panelStatus.Margin = new Padding(3, 4, 3, 4);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(548, 461);
            panelStatus.TabIndex = 6;
            // 
            // lblStatusTitle
            // 
            lblStatusTitle.AutoSize = true;
            lblStatusTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStatusTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblStatusTitle.Location = new Point(17, 14);
            lblStatusTitle.Name = "lblStatusTitle";
            lblStatusTitle.Size = new Size(159, 25);
            lblStatusTitle.TabIndex = 0;
            lblStatusTitle.Text = "Status Stok Bibit";
            // 
            // dgvStok
            // 
            dgvStok.AllowUserToAddRows = false;
            dgvStok.AllowUserToDeleteRows = false;
            dgvStok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStok.BackgroundColor = Color.White;
            dgvStok.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 250, 245);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStok.Columns.AddRange(new DataGridViewColumn[] { colId, colNama, colKategori, colStok, colStatus });
            dgvStok.EnableHeadersVisualStyles = false;
            dgvStok.GridColor = Color.FromArgb(230, 230, 230);
            dgvStok.Location = new Point(0, 63);
            dgvStok.Margin = new Padding(3, 4, 3, 4);
            dgvStok.Name = "dgvStok";
            dgvStok.ReadOnly = true;
            dgvStok.RowHeadersVisible = false;
            dgvStok.RowHeadersWidth = 51;
            dgvStok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStok.Size = new Size(546, 393);
            dgvStok.TabIndex = 1;
            dgvStok.CellContentClick += dgvStok_CellContentClick;
            dgvStok.CellDoubleClick += dgvStok_CellDoubleClick;
            // 
            // colId
            // 
            colId.FillWeight = 60F;
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colNama
            // 
            colNama.FillWeight = 200F;
            colNama.HeaderText = "Nama Bibit";
            colNama.MinimumWidth = 6;
            colNama.Name = "colNama";
            colNama.ReadOnly = true;
            // 
            // colKategori
            // 
            colKategori.FillWeight = 120F;
            colKategori.HeaderText = "Kategori";
            colKategori.MinimumWidth = 6;
            colKategori.Name = "colKategori";
            colKategori.ReadOnly = true;
            // 
            // colStok
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            colStok.DefaultCellStyle = dataGridViewCellStyle2;
            colStok.FillWeight = 80F;
            colStok.HeaderText = "Stok";
            colStok.MinimumWidth = 6;
            colStok.Name = "colStok";
            colStok.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // ManajemenStok
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            Controls.Add(lblJudul);
            Controls.Add(lblSubJudul);
            Controls.Add(panelTotalStok);
            Controls.Add(panelMenipis);
            Controls.Add(panelHabis);
            Controls.Add(panelPenyesuaian);
            Controls.Add(panelStatus);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManajemenStok";
            Size = new Size(1006, 800);
            Load += ManajemenStok_Load;
            panelTotalStok.ResumeLayout(false);
            panelTotalStok.PerformLayout();
            panelMenipis.ResumeLayout(false);
            panelMenipis.PerformLayout();
            panelHabis.ResumeLayout(false);
            panelHabis.PerformLayout();
            panelPenyesuaian.ResumeLayout(false);
            panelPenyesuaian.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlah).EndInit();
            panelStatus.ResumeLayout(false);
            panelStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblSubJudul;
        private System.Windows.Forms.Panel panelTotalStok;
        private System.Windows.Forms.Label lblIconTotal;
        private System.Windows.Forms.Label lblTotalStokTitle;
        private System.Windows.Forms.Label lblTotalStokVal;
        private System.Windows.Forms.Panel panelMenipis;
        private System.Windows.Forms.Label lblIconMenipis;
        private System.Windows.Forms.Label lblMenipisTitle;
        private System.Windows.Forms.Label lblMenipisVal;
        private System.Windows.Forms.Label lblMenipisSub;
        private System.Windows.Forms.Panel panelHabis;
        private System.Windows.Forms.Label lblIconHabis;
        private System.Windows.Forms.Label lblHabisTitle;
        private System.Windows.Forms.Label lblHabisVal;
        private System.Windows.Forms.Panel panelPenyesuaian;
        private System.Windows.Forms.Label lblPenyesuaian;
        private System.Windows.Forms.Label lblPilihBibit;
        private System.Windows.Forms.ComboBox cmbPilihBibit;
        private System.Windows.Forms.Label lblTipePenyesuaian;
        private System.Windows.Forms.RadioButton rbStokMasuk;
        private System.Windows.Forms.RadioButton rbStokKeluar;
        private System.Windows.Forms.RadioButton rbSetManual;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.NumericUpDown numJumlah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.DataGridView dgvStok;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNama;
        private DataGridViewTextBoxColumn colKategori;
        private DataGridViewTextBoxColumn colStok;
        private DataGridViewTextBoxColumn colStatus;
    }
}