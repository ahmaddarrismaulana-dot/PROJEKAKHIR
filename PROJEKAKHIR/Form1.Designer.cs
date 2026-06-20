namespace PROJEKAKHIR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            SidePanel = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            kelolaBibit2 = new KelolaBibit();
            manajemenStok1 = new ManajemenStok();
            transaksiMasuk1 = new TransaksiMasuk();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(SidePanel);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 742);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            SidePanel.Paint += SidePanel_Paint;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(12, 282);
            button3.Name = "button3";
            button3.Size = new Size(237, 58);
            button3.TabIndex = 2;
            button3.Text = "   Transaksi Masuk";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(12, 218);
            button2.Name = "button2";
            button2.Size = new Size(237, 58);
            button2.TabIndex = 2;
            button2.Text = "   Manajemen Stok";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            button1.Text = "   Kelola Bibit";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // kelolaBibit2
            // 
            kelolaBibit2.BackColor = Color.White;
            kelolaBibit2.Location = new Point(255, 0);
            kelolaBibit2.Margin = new Padding(3, 4, 3, 4);
            kelolaBibit2.Name = "kelolaBibit2";
            kelolaBibit2.Size = new Size(1286, 1066);
            kelolaBibit2.TabIndex = 1;
            // 
            // manajemenStok1
            // 
            manajemenStok1.BackColor = Color.FromArgb(245, 245, 245);
            manajemenStok1.Location = new Point(255, 0);
            manajemenStok1.Margin = new Padding(3, 4, 3, 4);
            manajemenStok1.Name = "manajemenStok1";
            manajemenStok1.Size = new Size(1258, 1000);
            manajemenStok1.TabIndex = 2;
            // 
            // transaksiMasuk1
            // 
            transaksiMasuk1.BackColor = Color.White;
            transaksiMasuk1.Location = new Point(255, 0);
            transaksiMasuk1.Margin = new Padding(3, 4, 3, 4);
            transaksiMasuk1.Name = "transaksiMasuk1";
            transaksiMasuk1.Size = new Size(1229, 900);
            transaksiMasuk1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1415, 742);
            Controls.Add(transaksiMasuk1);
            Controls.Add(manajemenStok1);
            Controls.Add(kelolaBibit2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
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
        private Button button2;
        private PictureBox pictureBox2;
        private KelolaBibit kelolaBibit1;
        private KelolaBibit kelolaBibit2;
        private ManajemenStok manajemenStok1;
        private TransaksiMasuk transaksiMasuk1;
    }
}
