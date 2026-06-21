namespace PROJEKAKHIR
{
    partial class CardBibit
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnKeranjang = new Button();
            lblStok = new Label();
            lblHarga = new Label();
            lblUmur = new Label();
            lblNama = new Label();
            picBibit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBibit).BeginInit();
            SuspendLayout();
            // 
            // btnKeranjang
            // 
            btnKeranjang.BackColor = Color.ForestGreen;
            btnKeranjang.FlatAppearance.BorderSize = 0;
            btnKeranjang.FlatStyle = FlatStyle.Flat;
            btnKeranjang.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnKeranjang.ForeColor = Color.White;
            btnKeranjang.Location = new Point(8, 336);
            btnKeranjang.Margin = new Padding(3, 4, 3, 4);
            btnKeranjang.Name = "btnKeranjang";
            btnKeranjang.Size = new Size(209, 40);
            btnKeranjang.TabIndex = 5;
            btnKeranjang.Text = "Tambah ke keranjang";
            btnKeranjang.UseVisualStyleBackColor = false;
            btnKeranjang.Click += btnKeranjang_Click;
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.Font = new Font("Segoe UI", 8F);
            lblStok.Location = new Point(3, 260);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(67, 19);
            lblStok.TabIndex = 4;
            lblStok.Text = "Stok: 372";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHarga.ForeColor = Color.DarkGreen;
            lblHarga.Location = new Point(3, 229);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(81, 20);
            lblHarga.TabIndex = 3;
            lblHarga.Text = "Rp 30.000";
            // 
            // lblUmur
            // 
            lblUmur.AutoSize = true;
            lblUmur.Font = new Font("Segoe UI", 8F);
            lblUmur.Location = new Point(3, 202);
            lblUmur.Name = "lblUmur";
            lblUmur.Size = new Size(55, 19);
            lblUmur.TabIndex = 2;
            lblUmur.Text = "2 Bulan";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNama.Location = new Point(5, 166);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(167, 20);
            lblNama.TabIndex = 1;
            lblNama.Text = "Bibit Alpukat Mentega";
            lblNama.Click += lblNama_Click;
            // 
            // picBibit
            // 
            picBibit.BackColor = Color.FromArgb(230, 230, 230);
            picBibit.Location = new Point(3, 5);
            picBibit.Margin = new Padding(3, 4, 3, 4);
            picBibit.Name = "picBibit";
            picBibit.Size = new Size(221, 133);
            picBibit.SizeMode = PictureBoxSizeMode.StretchImage;
            picBibit.TabIndex = 0;
            picBibit.TabStop = false;
            picBibit.Click += picBibit_Click;
            // 
            // CardBibit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblUmur);
            Controls.Add(picBibit);
            Controls.Add(lblHarga);
            Controls.Add(lblStok);
            Controls.Add(lblNama);
            Controls.Add(btnKeranjang);
            Name = "CardBibit";
            Size = new Size(228, 384);
            ((System.ComponentModel.ISupportInitialize)picBibit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKeranjang;
        private Label lblStok;
        private Label lblHarga;
        private Label lblUmur;
        private Label lblNama;
        private PictureBox picBibit;
    }
}
