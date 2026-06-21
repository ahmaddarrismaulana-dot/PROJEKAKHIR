
namespace PROJEKAKHIR
{
    partial class FormPembeli
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPembeli));
            panel1 = new Panel();
            button2 = new Button();
            buttonCheckout = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            SidePanel = new Panel();
            button3 = new Button();
            buttonRiwayat = new Button();
            buttonKeranjang = new Button();
            button1 = new Button();
            katalog1 = new Katalog();
            keranjang1 = new Keranjang();
            riwayatTransaksi1 = new RiwayatTransaksi();
            checkout1 = new Checkout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(button2);
            panel1.Controls.Add(buttonCheckout);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(SidePanel);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(buttonRiwayat);
            panel1.Controls.Add(buttonKeranjang);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 742);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(60, 676);
            button2.Name = "button2";
            button2.Size = new Size(116, 45);
            button2.TabIndex = 6;
            button2.Text = "LOGOUT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // buttonCheckout
            // 
            buttonCheckout.FlatAppearance.BorderSize = 0;
            buttonCheckout.FlatStyle = FlatStyle.Flat;
            buttonCheckout.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCheckout.ForeColor = Color.White;
            buttonCheckout.Image = (Image)resources.GetObject("buttonCheckout.Image");
            buttonCheckout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCheckout.Location = new Point(10, 282);
            buttonCheckout.Name = "buttonCheckout";
            buttonCheckout.Size = new Size(237, 58);
            buttonCheckout.TabIndex = 5;
            buttonCheckout.Text = "   Checkout";
            buttonCheckout.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCheckout.UseVisualStyleBackColor = true;
            buttonCheckout.Click += buttonCheckout_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(-5, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(225, 94);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(80, 75);
            label2.Name = "label2";
            label2.Size = new Size(131, 16);
            label2.TabIndex = 3;
            label2.Text = "Toko Bibit Terpercaya";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(80, 47);
            label1.Name = "label1";
            label1.Size = new Size(81, 23);
            label1.TabIndex = 2;
            label1.Text = "BibitKu";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(28, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.White;
            SidePanel.Location = new Point(0, 154);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(10, 58);
            SidePanel.TabIndex = 2;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(12, 748);
            button3.Name = "button3";
            button3.Size = new Size(237, 58);
            button3.TabIndex = 2;
            button3.Text = "   Checkout";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            // 
            // buttonRiwayat
            // 
            buttonRiwayat.FlatAppearance.BorderSize = 0;
            buttonRiwayat.FlatStyle = FlatStyle.Flat;
            buttonRiwayat.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRiwayat.ForeColor = Color.White;
            buttonRiwayat.Image = (Image)resources.GetObject("buttonRiwayat.Image");
            buttonRiwayat.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRiwayat.Location = new Point(12, 347);
            buttonRiwayat.Name = "buttonRiwayat";
            buttonRiwayat.Size = new Size(237, 58);
            buttonRiwayat.TabIndex = 2;
            buttonRiwayat.Text = "   RIwayat Transaksi";
            buttonRiwayat.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRiwayat.UseVisualStyleBackColor = true;
            buttonRiwayat.Click += buttonRiwayat_Click_1;
            // 
            // buttonKeranjang
            // 
            buttonKeranjang.FlatAppearance.BorderSize = 0;
            buttonKeranjang.FlatStyle = FlatStyle.Flat;
            buttonKeranjang.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonKeranjang.ForeColor = Color.White;
            buttonKeranjang.Image = (Image)resources.GetObject("buttonKeranjang.Image");
            buttonKeranjang.ImageAlign = ContentAlignment.MiddleLeft;
            buttonKeranjang.Location = new Point(12, 218);
            buttonKeranjang.Name = "buttonKeranjang";
            buttonKeranjang.Size = new Size(237, 58);
            buttonKeranjang.TabIndex = 2;
            buttonKeranjang.Text = "   Keranjang";
            buttonKeranjang.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonKeranjang.UseVisualStyleBackColor = true;
            buttonKeranjang.Click += buttonKeranjang_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 154);
            button1.Name = "button1";
            button1.Size = new Size(237, 58);
            button1.TabIndex = 2;
            button1.Text = "   Katalog";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // katalog1
            // 
            katalog1.BackColor = Color.White;
            katalog1.Location = new Point(251, 0);
            katalog1.Margin = new Padding(3, 4, 3, 4);
            katalog1.Name = "katalog1";
            katalog1.Size = new Size(1229, 1034);
            katalog1.TabIndex = 1;
            // 
            // keranjang1
            // 
            keranjang1.BackColor = Color.White;
            keranjang1.Location = new Point(251, 0);
            keranjang1.Margin = new Padding(3, 4, 3, 4);
            keranjang1.Name = "keranjang1";
            keranjang1.Size = new Size(1182, 1034);
            keranjang1.TabIndex = 2;
            // 
            // riwayatTransaksi1
            // 
            riwayatTransaksi1.BackColor = Color.White;
            riwayatTransaksi1.Location = new Point(250, 0);
            riwayatTransaksi1.Margin = new Padding(3, 4, 3, 4);
            riwayatTransaksi1.Name = "riwayatTransaksi1";
            riwayatTransaksi1.Size = new Size(1229, 790);
            riwayatTransaksi1.TabIndex = 3;
            // 
            // checkout1
            // 
            checkout1.BackColor = Color.White;
            checkout1.Location = new Point(251, 3);
            checkout1.Margin = new Padding(3, 4, 3, 4);
            checkout1.Name = "checkout1";
            checkout1.Size = new Size(1418, 1070);
            checkout1.TabIndex = 6;
            checkout1.Load += checkout1_Load;
            // 
            // FormPembeli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1415, 742);
            Controls.Add(checkout1);
            Controls.Add(riwayatTransaksi1);
            Controls.Add(keranjang1);
            Controls.Add(katalog1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPembeli";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPembeli";
            Load += FormPembeli_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button3;
        private Panel SidePanel;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button buttonKeranjang;
        private PictureBox pictureBox2;
        private Button buttonRiwayat;
        private Katalog katalog1;
        private Keranjang keranjang1;
        private RiwayatTransaksi riwayatTransaksi1;
        private Button buttonCheckout;
        private Checkout checkout1;
        private Button button2;
    }
}