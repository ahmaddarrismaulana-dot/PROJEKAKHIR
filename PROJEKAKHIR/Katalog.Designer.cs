namespace PROJEKAKHIR
{
    partial class Katalog
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
            this.txtCari = new System.Windows.Forms.TextBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.cmbHarga = new System.Windows.Forms.ComboBox();
            this.btnTambah = new System.Windows.Forms.Button();

            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();

            this.pic1 = new System.Windows.Forms.PictureBox();
            this.lblNama1 = new System.Windows.Forms.Label();
            this.lblUmur1 = new System.Windows.Forms.Label();
            this.lblHarga1 = new System.Windows.Forms.Label();
            this.lblStok1 = new System.Windows.Forms.Label();
            this.btnBeli1 = new System.Windows.Forms.Button();

            this.pic2 = new System.Windows.Forms.PictureBox();
            this.lblNama2 = new System.Windows.Forms.Label();
            this.lblUmur2 = new System.Windows.Forms.Label();
            this.lblHarga2 = new System.Windows.Forms.Label();
            this.lblStok2 = new System.Windows.Forms.Label();
            this.btnBeli2 = new System.Windows.Forms.Button();

            this.pic3 = new System.Windows.Forms.PictureBox();
            this.lblNama3 = new System.Windows.Forms.Label();
            this.lblUmur3 = new System.Windows.Forms.Label();
            this.lblHarga3 = new System.Windows.Forms.Label();
            this.lblStok3 = new System.Windows.Forms.Label();
            this.btnBeli3 = new System.Windows.Forms.Button();

            this.pic4 = new System.Windows.Forms.PictureBox();
            this.lblNama4 = new System.Windows.Forms.Label();
            this.lblUmur4 = new System.Windows.Forms.Label();
            this.lblHarga4 = new System.Windows.Forms.Label();
            this.lblStok4 = new System.Windows.Forms.Label();
            this.btnBeli4 = new System.Windows.Forms.Button();

            this.pic5 = new System.Windows.Forms.PictureBox();
            this.lblNama5 = new System.Windows.Forms.Label();
            this.lblUmur5 = new System.Windows.Forms.Label();
            this.lblHarga5 = new System.Windows.Forms.Label();
            this.lblStok5 = new System.Windows.Forms.Label();
            this.btnBeli5 = new System.Windows.Forms.Button();

            this.pic6 = new System.Windows.Forms.PictureBox();
            this.lblNama6 = new System.Windows.Forms.Label();
            this.lblUmur6 = new System.Windows.Forms.Label();
            this.lblHarga6 = new System.Windows.Forms.Label();
            this.lblStok6 = new System.Windows.Forms.Label();
            this.btnBeli6 = new System.Windows.Forms.Button();

            this.pic7 = new System.Windows.Forms.PictureBox();
            this.lblNama7 = new System.Windows.Forms.Label();
            this.lblUmur7 = new System.Windows.Forms.Label();
            this.lblHarga7 = new System.Windows.Forms.Label();
            this.lblStok7 = new System.Windows.Forms.Label();
            this.btnBeli7 = new System.Windows.Forms.Button();

            this.pic8 = new System.Windows.Forms.PictureBox();
            this.lblNama8 = new System.Windows.Forms.Label();
            this.lblUmur8 = new System.Windows.Forms.Label();
            this.lblHarga8 = new System.Windows.Forms.Label();
            this.lblStok8 = new System.Windows.Forms.Label();
            this.btnBeli8 = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();

            // ════════════════════════════════════════════════════════════
            // FILTER BAR  (Y=10)
            // col1=10  col2=210  col3=400  btnTambah=660
            // ════════════════════════════════════════════════════════════
            this.txtCari.Location = new System.Drawing.Point(10, 10);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(190, 23);
            this.txtCari.PlaceholderText = "Cari bibit atau kategori...";

            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.Location = new System.Drawing.Point(210, 10);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(180, 23);
            this.cmbKategori.Items.AddRange(new object[] {
                "Semua Kategori","Mangga","Jeruk","Durian","Alpukat","Jambu","Rambutan","Strawberry","Anggur"
            });
            this.cmbKategori.SelectedIndex = 0;

            this.cmbHarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHarga.Location = new System.Drawing.Point(400, 10);
            this.cmbHarga.Name = "cmbHarga";
            this.cmbHarga.Size = new System.Drawing.Size(180, 23);
            this.cmbHarga.Items.AddRange(new object[] {
                "Semua Harga","< Rp 25.000","Rp 25.000 - Rp 50.000","> Rp 50.000"
            });
            this.cmbHarga.SelectedIndex = 0;

            this.btnTambah.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(660, 8);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(190, 27);
            this.btnTambah.Text = "Tambah";

            // ════════════════════════════════════════════════════════════
            // Grid posisi (hardcoded):
            // Kartu lebar=195 tinggi=270
            // Kolom X: col1=10  col2=217  col3=424  col4=631
            // Baris Y: row1=50  row2=335
            // ════════════════════════════════════════════════════════════

            // ── KARTU 1 — Bibit Mangga Arumanis  X=10  Y=50 ────────────
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(10, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 270);

            this.pic1.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.pic1.Location = new System.Drawing.Point(0, 0);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(193, 100);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabStop = false;

            this.lblNama1.AutoSize = true;
            this.lblNama1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNama1.Location = new System.Drawing.Point(5, 108);
            this.lblNama1.Text = "Bibit Mangga Arumanis";

            this.lblUmur1.AutoSize = true;
            this.lblUmur1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUmur1.Location = new System.Drawing.Point(5, 130);
            this.lblUmur1.Text = "2 Bulan";

            this.lblHarga1.AutoSize = true;
            this.lblHarga1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHarga1.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHarga1.Location = new System.Drawing.Point(5, 150);
            this.lblHarga1.Text = "Rp 25.000";

            this.lblStok1.AutoSize = true;
            this.lblStok1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStok1.Location = new System.Drawing.Point(5, 173);
            this.lblStok1.Text = "Stok: 178";

            this.btnBeli1.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBeli1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeli1.FlatAppearance.BorderSize = 0;
            this.btnBeli1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnBeli1.ForeColor = System.Drawing.Color.White;
            this.btnBeli1.Location = new System.Drawing.Point(5, 230);
            this.btnBeli1.Name = "btnBeli1";
            this.btnBeli1.Size = new System.Drawing.Size(183, 30);
            this.btnBeli1.Text = "Tambah ke keranjang";

            this.panel1.Controls.Add(this.pic1);
            this.panel1.Controls.Add(this.lblNama1);
            this.panel1.Controls.Add(this.lblUmur1);
            this.panel1.Controls.Add(this.lblHarga1);
            this.panel1.Controls.Add(this.lblStok1);
            this.panel1.Controls.Add(this.btnBeli1);

            // ── KARTU 2 — Bibit Jeruk Siam  X=217  Y=50 ────────────────
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(217, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 270);

            this.pic2.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.pic2.Location = new System.Drawing.Point(0, 0);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(193, 100);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabStop = false;

            this.lblNama2.AutoSize = true;
            this.lblNama2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNama2.Location = new System.Drawing.Point(5, 108);
            this.lblNama2.Text = "Bibit Jeruk Siam";

            this.lblUmur2.AutoSize = true;
            this.lblUmur2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUmur2.Location = new System.Drawing.Point(5, 130);
            this.lblUmur2.Text = "3 Bulan";

            this.lblHarga2.AutoSize = true;
            this.lblHarga2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHarga2.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHarga2.Location = new System.Drawing.Point(5, 150);
            this.lblHarga2.Text = "Rp 20.000";

            this.lblStok2.AutoSize = true;
            this.lblStok2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStok2.Location = new System.Drawing.Point(5, 173);
            this.lblStok2.Text = "Stok: 213";

            this.btnBeli2.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBeli2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeli2.FlatAppearance.BorderSize = 0;
            this.btnBeli2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnBeli2.ForeColor = System.Drawing.Color.White;
            this.btnBeli2.Location = new System.Drawing.Point(5, 230);
            this.btnBeli2.Name = "btnBeli2";
            this.btnBeli2.Size = new System.Drawing.Size(183, 30);
            this.btnBeli2.Text = "Tambah ke keranjang";

            this.panel2.Controls.Add(this.pic2);
            this.panel2.Controls.Add(this.lblNama2);
            this.panel2.Controls.Add(this.lblUmur2);
            this.panel2.Controls.Add(this.lblHarga2);
            this.panel2.Controls.Add(this.lblStok2);
            this.panel2.Controls.Add(this.btnBeli2);

            // ── KARTU 3 — Bibit Durian Montong  X=424  Y=50 ────────────
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(424, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 270);

            this.pic3.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.pic3.Location = new System.Drawing.Point(0, 0);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(193, 100);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabStop = false;

            this.lblNama3.AutoSize = true;
            this.lblNama3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNama3.Location = new System.Drawing.Point(5, 108);
            this.lblNama3.Text = "Bibit Durian Montong";

            this.lblUmur3.AutoSize = true;
            this.lblUmur3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUmur3.Location = new System.Drawing.Point(5, 130);
            this.lblUmur3.Text = "2 Bulan";

            this.lblHarga3.AutoSize = true;
            this.lblHarga3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHarga3.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHarga3.Location = new System.Drawing.Point(5, 150);
            this.lblHarga3.Text = "Rp 45.000";

            this.lblStok3.AutoSize = true;
            this.lblStok3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStok3.Location = new System.Drawing.Point(5, 173);
            this.lblStok3.Text = "Stok: 228";

            this.btnBeli3.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBeli3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeli3.FlatAppearance.BorderSize = 0;
            this.btnBeli3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnBeli3.ForeColor = System.Drawing.Color.White;
            this.btnBeli3.Location = new System.Drawing.Point(5, 230);
            this.btnBeli3.Name = "btnBeli3";
            this.btnBeli3.Size = new System.Drawing.Size(183, 30);
            this.btnBeli3.Text = "Tambah ke keranjang";

            this.panel3.Controls.Add(this.pic3);
            this.panel3.Controls.Add(this.lblNama3);
            this.panel3.Controls.Add(this.lblUmur3);
            this.panel3.Controls.Add(this.lblHarga3);
            this.panel3.Controls.Add(this.lblStok3);
            this.panel3.Controls.Add(this.btnBeli3);

            // ── KARTU 4 — Bibit Alpukat Mentega  X=631  Y=50 ───────────
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(631, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(195, 270);

            this.pic4.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.pic4.Location = new System.Drawing.Point(0, 0);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(193, 100);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic4.TabStop = false;

            this.lblNama4.AutoSize = true;
            this.lblNama4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNama4.Location = new System.Drawing.Point(5, 108);
            this.lblNama4.Text = "Bibit Alpukat Mentega";

            this.lblUmur4.AutoSize = true;
            this.lblUmur4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUmur4.Location = new System.Drawing.Point(5, 130);
            this.lblUmur4.Text = "2 Bulan";

            this.lblHarga4.AutoSize = true;
            this.lblHarga4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHarga4.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHarga4.Location = new System.Drawing.Point(5, 150);
            this.lblHarga4.Text = "Rp 30.000";

            this.lblStok4.AutoSize = true;
            this.lblStok4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStok4.Location = new System.Drawing.Point(5, 173);
            this.lblStok4.Text = "Stok: 372";

            this.btnBeli4.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBeli4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeli4.FlatAppearance.BorderSize = 0;
            this.btnBeli4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnBeli4.ForeColor = System.Drawing.Color.White;
            this.btnBeli4.Location = new System.Drawing.Point(5, 230);
            this.btnBeli4.Name = "btnBeli4";
            this.btnBeli4.Size = new System.Drawing.Size(183, 30);
            this.btnBeli4.Text = "Tambah ke keranjang";

            this.panel4.Controls.Add(this.pic4);
            this.panel4.Controls.Add(this.lblNama4);
            this.panel4.Controls.Add(this.lblUmur4);
            this.panel4.Controls.Add(this.lblHarga4);
            this.panel4.Controls.Add(this.lblStok4);
            this.panel4.Controls.Add(this.btnBeli4);

            // ── KARTU 5 — Bibit Jambu Air  X=10  Y=335 ─────────────────
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(10, 335);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(195, 270);

            this.pic5.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.pic5.Location = new System.Drawing.Point(0, 0);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(193, 100);
            this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic5.TabStop = false;

            this.lblNama5.AutoSize = true;
            this.lblNama5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNama5.Location = new System.Drawing.Point(5, 108);
            this.lblNama5.Text = "Bibit Jambu Air";

            this.lblUmur5.AutoSize = true;
            this.lblUmur5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUmur5.Location = new System.Drawing.Point(5, 130);
            this.lblUmur5.Text = "2 Bulan";

            this.lblHarga5.AutoSize = true;
            this.lblHarga5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHarga5.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHarga5.Location = new System.Drawing.Point(5, 150);
            this.lblHarga5.Text = "Rp 25.000";

            this.lblStok5.AutoSize = true;
            this.lblStok5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStok5.Location = new System.Drawing.Point(5, 173);
            this.lblStok5.Text = "Stok: 221";

            this.btnBeli5.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBeli5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeli5.FlatAppearance.BorderSize = 0;
            this.btnBeli5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnBeli5.ForeColor = System.Drawing.Color.White;
            this.btnBeli5.Location = new System.Drawing.Point(5, 230);
            this.btnBeli5.Name = "btnBeli5";
            this.btnBeli5.Size = new System.Drawing.Size(183, 30);
            this.btnBeli5.Text = "Tambah ke keranjang";

            this.panel5.Controls.Add(this.pic5);
            this.panel5.Controls.Add(this.lblNama5);
            this.panel5.Controls.Add(this.lblUmur5);
            this.panel5.Controls.Add(this.lblHarga5);
            this.panel5.Controls.Add(this.lblStok5);
            this.panel5.Controls.Add(this.btnBeli5);

            // ── KARTU 6 — Bibit Rambutan Binjai  X=217  Y=335 ──────────
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(217, 335);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(195, 270);

            this.pic6.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.pic6.Location = new System.Drawing.Point(0, 0);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(193, 100);
            this.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic6.TabStop = false;

            this.lblNama6.AutoSize = true;
            this.lblNama6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNama6.Location = new System.Drawing.Point(5, 108);
            this.lblNama6.Text = "Bibit Rambutan Binjai";

            this.lblUmur6.AutoSize = true;
            this.lblUmur6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUmur6.Location = new System.Drawing.Point(5, 130);
            this.lblUmur6.Text = "2 Bulan";

            this.lblHarga6.AutoSize = true;
            this.lblHarga6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHarga6.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHarga6.Location = new System.Drawing.Point(5, 150);
            this.lblHarga6.Text = "Rp 20.000";

            this.lblStok6.AutoSize = true;
            this.lblStok6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStok6.Location = new System.Drawing.Point(5, 173);
            this.lblStok6.Text = "Stok: 117";

            this.btnBeli6.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBeli6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeli6.FlatAppearance.BorderSize = 0;
            this.btnBeli6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnBeli6.ForeColor = System.Drawing.Color.White;
            this.btnBeli6.Location = new System.Drawing.Point(5, 230);
            this.btnBeli6.Name = "btnBeli6";
            this.btnBeli6.Size = new System.Drawing.Size(183, 30);
            this.btnBeli6.Text = "Tambah ke keranjang";

            this.panel6.Controls.Add(this.pic6);
            this.panel6.Controls.Add(this.lblNama6);
            this.panel6.Controls.Add(this.lblUmur6);
            this.panel6.Controls.Add(this.lblHarga6);
            this.panel6.Controls.Add(this.lblStok6);
            this.panel6.Controls.Add(this.btnBeli6);

            // ── KARTU 7 — Bibit Strawberry Jewel  X=424  Y=335 ─────────
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(424, 335);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(195, 270);

            this.pic7.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.pic7.Location = new System.Drawing.Point(0, 0);
            this.pic7.Name = "pic7";
            this.pic7.Size = new System.Drawing.Size(193, 100);
            this.pic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic7.TabStop = false;

            this.lblNama7.AutoSize = true;
            this.lblNama7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNama7.Location = new System.Drawing.Point(5, 108);
            this.lblNama7.Text = "Bibit Strawberry Jewel";

            this.lblUmur7.AutoSize = true;
            this.lblUmur7.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUmur7.Location = new System.Drawing.Point(5, 130);
            this.lblUmur7.Text = "3 Bulan";

            this.lblHarga7.AutoSize = true;
            this.lblHarga7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHarga7.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHarga7.Location = new System.Drawing.Point(5, 150);
            this.lblHarga7.Text = "Rp 35.000";

            this.lblStok7.AutoSize = true;
            this.lblStok7.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStok7.Location = new System.Drawing.Point(5, 173);
            this.lblStok7.Text = "Stok: 316";

            this.btnBeli7.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBeli7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeli7.FlatAppearance.BorderSize = 0;
            this.btnBeli7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnBeli7.ForeColor = System.Drawing.Color.White;
            this.btnBeli7.Location = new System.Drawing.Point(5, 230);
            this.btnBeli7.Name = "btnBeli7";
            this.btnBeli7.Size = new System.Drawing.Size(183, 30);
            this.btnBeli7.Text = "Tambah ke keranjang";

            this.panel7.Controls.Add(this.pic7);
            this.panel7.Controls.Add(this.lblNama7);
            this.panel7.Controls.Add(this.lblUmur7);
            this.panel7.Controls.Add(this.lblHarga7);
            this.panel7.Controls.Add(this.lblStok7);
            this.panel7.Controls.Add(this.btnBeli7);

            // ── KARTU 8 — Bibit Anggur Muscat  X=631  Y=335 ────────────
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(631, 335);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(195, 270);

            this.pic8.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.pic8.Location = new System.Drawing.Point(0, 0);
            this.pic8.Name = "pic8";
            this.pic8.Size = new System.Drawing.Size(193, 100);
            this.pic8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic8.TabStop = false;

            this.lblNama8.AutoSize = true;
            this.lblNama8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNama8.Location = new System.Drawing.Point(5, 108);
            this.lblNama8.Text = "Bibit Anggur Muscat";

            this.lblUmur8.AutoSize = true;
            this.lblUmur8.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUmur8.Location = new System.Drawing.Point(5, 130);
            this.lblUmur8.Text = "2 Bulan";

            this.lblHarga8.AutoSize = true;
            this.lblHarga8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHarga8.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHarga8.Location = new System.Drawing.Point(5, 150);
            this.lblHarga8.Text = "Rp 40.000";

            this.lblStok8.AutoSize = true;
            this.lblStok8.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStok8.Location = new System.Drawing.Point(5, 173);
            this.lblStok8.Text = "Stok: 214";

            this.btnBeli8.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBeli8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeli8.FlatAppearance.BorderSize = 0;
            this.btnBeli8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnBeli8.ForeColor = System.Drawing.Color.White;
            this.btnBeli8.Location = new System.Drawing.Point(5, 230);
            this.btnBeli8.Name = "btnBeli8";
            this.btnBeli8.Size = new System.Drawing.Size(183, 30);
            this.btnBeli8.Text = "Tambah ke keranjang";

            this.panel8.Controls.Add(this.pic8);
            this.panel8.Controls.Add(this.lblNama8);
            this.panel8.Controls.Add(this.lblUmur8);
            this.panel8.Controls.Add(this.lblHarga8);
            this.panel8.Controls.Add(this.lblStok8);
            this.panel8.Controls.Add(this.btnBeli8);

            // ════════════════════════════════════════════════════════════
            // UserControl
            // ════════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Name = "KatalogBibit";
            this.Size = new System.Drawing.Size(860, 620);

            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.cmbHarga);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);

            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).EndInit();

            this.panel1.ResumeLayout(false); this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false); this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false); this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false); this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false); this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false); this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false); this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false); this.panel8.PerformLayout();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ComboBox cmbHarga;
        private System.Windows.Forms.Button btnTambah;

        private System.Windows.Forms.Panel panel1, panel2, panel3, panel4;
        private System.Windows.Forms.Panel panel5, panel6, panel7, panel8;

        private System.Windows.Forms.PictureBox pic1, pic2, pic3, pic4;
        private System.Windows.Forms.PictureBox pic5, pic6, pic7, pic8;

        private System.Windows.Forms.Label lblNama1, lblNama2, lblNama3, lblNama4;
        private System.Windows.Forms.Label lblNama5, lblNama6, lblNama7, lblNama8;
        private System.Windows.Forms.Label lblUmur1, lblUmur2, lblUmur3, lblUmur4;
        private System.Windows.Forms.Label lblUmur5, lblUmur6, lblUmur7, lblUmur8;
        private System.Windows.Forms.Label lblHarga1, lblHarga2, lblHarga3, lblHarga4;
        private System.Windows.Forms.Label lblHarga5, lblHarga6, lblHarga7, lblHarga8;
        private System.Windows.Forms.Label lblStok1, lblStok2, lblStok3, lblStok4;
        private System.Windows.Forms.Label lblStok5, lblStok6, lblStok7, lblStok8;

        private System.Windows.Forms.Button btnBeli1, btnBeli2, btnBeli3, btnBeli4;
        private System.Windows.Forms.Button btnBeli5, btnBeli6, btnBeli7, btnBeli8;
    }
}