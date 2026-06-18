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
            lblJudul = new Label();
            lblSubjudul = new Label();
            pnlHeader = new Panel();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkTampilPassword = new CheckBox();
            lblPesan = new Label();
            btnLogin = new Button();
            btnBatal = new Button();
            label1 = new Label();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            linkLabel1 = new LinkLabel();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(130, 12);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(139, 46);
            lblJudul.TabIndex = 1;
            lblJudul.Text = "BibitKu";
            // 
            // lblSubjudul
            // 
            lblSubjudul.AutoSize = true;
            lblSubjudul.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblSubjudul.ForeColor = Color.FromArgb(180, 210, 255);
            lblSubjudul.Location = new Point(108, 58);
            lblSubjudul.Name = "lblSubjudul";
            lblSubjudul.Size = new Size(158, 20);
            lblSubjudul.TabIndex = 0;
            lblSubjudul.Text = "Marketplace Bibit Buah";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(26, 53, 117);
            pnlHeader.Controls.Add(lblSubjudul);
            pnlHeader.Controls.Add(lblJudul);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(400, 90);
            pnlHeader.TabIndex = 0;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(40, 110);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(40, 130);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Masukkan email anda";
            txtEmail.Size = new Size(310, 30);
            txtEmail.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassword.Location = new Point(40, 170);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(40, 190);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "Masukkan password";
            txtPassword.Size = new Size(310, 30);
            txtPassword.TabIndex = 4;
            // 
            // chkTampilPassword
            // 
            chkTampilPassword.AutoSize = true;
            chkTampilPassword.Font = new Font("Segoe UI", 9F);
            chkTampilPassword.Location = new Point(40, 225);
            chkTampilPassword.Name = "chkTampilPassword";
            chkTampilPassword.Size = new Size(165, 24);
            chkTampilPassword.TabIndex = 5;
            chkTampilPassword.Text = "Tampilkan password";
            chkTampilPassword.CheckedChanged += chkTampilPassword_CheckedChanged;
            // 
            // lblRole
            // 
 
            // cmbRole
            //
            // 
            // lblPesan
            // 
            lblPesan.AutoSize = true;
            lblPesan.Font = new Font("Segoe UI", 9F);
            lblPesan.ForeColor = Color.Red;
            lblPesan.Location = new Point(40, 318);
            lblPesan.Name = "lblPesan";
            lblPesan.Size = new Size(0, 20);
            lblPesan.TabIndex = 8;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(30, 74, 153);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(40, 326);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(145, 38);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Masuk";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.FromArgb(240, 240, 240);
            btnBatal.FlatAppearance.BorderColor = Color.Silver;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Segoe UI", 10F);
            btnBatal.ForeColor = Color.FromArgb(60, 60, 60);
            btnBatal.Location = new Point(205, 327);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(145, 38);
            btnBatal.TabIndex = 10;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 368);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 11;
            label1.Text = "Belum punya akun?";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(106, 376);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(3, 2);
            guna2HtmlLabel1.TabIndex = 12;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(230, 368);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(51, 20);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Daftar";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FormLogin
            // 
            AcceptButton = btnLogin;
            BackColor = Color.White;
            ClientSize = new Size(400, 410);
            Controls.Add(linkLabel1);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(label1);
            Controls.Add(pnlHeader);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(chkTampilPassword);
            Controls.Add(lblPesan);
            Controls.Add(btnLogin);
            Controls.Add(btnBatal);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BibitKu — Login";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private LinkLabel linkLabel1;
    }
}