namespace BibitKu.Views
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        // ── Komponen UI ──────────────────────────────────────────────
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblSubjudul;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkTampilPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblPesan;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Panel pnlHeader;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblSubjudul = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkTampilPassword = new System.Windows.Forms.CheckBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblPesan = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // ── pnlHeader ────────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 53, 117);
            this.pnlHeader.Controls.Add(this.lblSubjudul);
            this.pnlHeader.Controls.Add(this.lblJudul);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Size = new System.Drawing.Size(400, 90);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);

            // ── lblJudul ─────────────────────────────────────────────
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.White;
            this.lblJudul.Location = new System.Drawing.Point(130, 12);
            this.lblJudul.Text = "BibitKu";

            // ── lblSubjudul ──────────────────────────────────────────
            this.lblSubjudul.AutoSize = true;
            this.lblSubjudul.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblSubjudul.ForeColor = System.Drawing.Color.FromArgb(180, 210, 255);
            this.lblSubjudul.Location = new System.Drawing.Point(108, 58);
            this.lblSubjudul.Text = "Marketplace Bibit Buah";

            // ── lblEmail ─────────────────────────────────────────────
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(40, 110);
            this.lblEmail.Text = "Email";

            // ── txtEmail ─────────────────────────────────────────────
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(40, 130);
            this.txtEmail.Size = new System.Drawing.Size(310, 28);
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.PlaceholderText = "Masukkan email anda";

            // ── lblPassword ──────────────────────────────────────────
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(40, 170);
            this.lblPassword.Text = "Password";

            // ── txtPassword ──────────────────────────────────────────
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(40, 190);
            this.txtPassword.Size = new System.Drawing.Size(310, 28);
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.PlaceholderText = "Masukkan password";

            // ── chkTampilPassword ────────────────────────────────────
            this.chkTampilPassword.AutoSize = true;
            this.chkTampilPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkTampilPassword.Location = new System.Drawing.Point(40, 225);
            this.chkTampilPassword.Text = "Tampilkan password";
            this.chkTampilPassword.CheckedChanged += new System.EventHandler(this.chkTampilPassword_CheckedChanged);

            // ── lblRole ──────────────────────────────────────────────
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRole.Location = new System.Drawing.Point(40, 258);
            this.lblRole.Text = "Login sebagai";

            // ── cmbRole ──────────────────────────────────────────────
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRole.Location = new System.Drawing.Point(40, 278);
            this.cmbRole.Size = new System.Drawing.Size(310, 28);
            this.cmbRole.Items.AddRange(new object[] { "Penjual", "Pembeli" });
            this.cmbRole.SelectedIndex = 0;

            // ── lblPesan ─────────────────────────────────────────────
            this.lblPesan.AutoSize = true;
            this.lblPesan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPesan.ForeColor = System.Drawing.Color.Red;
            this.lblPesan.Location = new System.Drawing.Point(40, 318);
            this.lblPesan.Text = "";

            // ── btnLogin ─────────────────────────────────────────────
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(30, 74, 153);
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(40, 345);
            this.btnLogin.Size = new System.Drawing.Size(145, 38);
            this.btnLogin.Text = "Masuk";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // ── btnBatal ─────────────────────────────────────────────
            this.btnBatal.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBatal.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnBatal.Location = new System.Drawing.Point(205, 345);
            this.btnBatal.Size = new System.Drawing.Size(145, 38);
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);

            // ── Form ─────────────────────────────────────────────────
            this.AcceptButton = this.btnLogin;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 410);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BibitKu — Login";

            this.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                this.pnlHeader,
                this.lblEmail,
                this.txtEmail,
                this.lblPassword,
                this.txtPassword,
                this.chkTampilPassword,
                this.lblRole,
                this.cmbRole,
                this.lblPesan,
                this.btnLogin,
                this.btnBatal
            });

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}