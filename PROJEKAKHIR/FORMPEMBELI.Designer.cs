namespace PROJEKAKHIR
{
    partial class FORMPEMBELI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORMPEMBELI));
            KATALOG = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // KATALOG
            // 
            KATALOG.BackColor = Color.DarkGreen;
            KATALOG.FlatAppearance.BorderSize = 0;
            KATALOG.FlatStyle = FlatStyle.Flat;
            KATALOG.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KATALOG.ForeColor = Color.White;
            KATALOG.Image = (Image)resources.GetObject("KATALOG.Image");
            KATALOG.ImageAlign = ContentAlignment.MiddleLeft;
            KATALOG.Location = new Point(-2, 125);
            KATALOG.Name = "KATALOG";
            KATALOG.Size = new Size(264, 79);
            KATALOG.TabIndex = 0;
            KATALOG.Text = "KATALOG";
            KATALOG.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-2, 206);
            button1.Name = "button1";
            button1.Size = new Size(264, 79);
            button1.TabIndex = 1;
            button1.Text = "KERANJANG";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-2, 288);
            button2.Name = "button2";
            button2.Size = new Size(264, 79);
            button2.TabIndex = 2;
            button2.Text = "CHECHKOUT";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGreen;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-2, 373);
            button3.Name = "button3";
            button3.Size = new Size(264, 79);
            button3.TabIndex = 3;
            button3.Text = "RIWAYAT TRANSAKSI";
            button3.UseVisualStyleBackColor = false;
            // 
            // FORMPEMBELI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1173, 574);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(KATALOG);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FORMPEMBELI";
            Text = "FORMPEMBELI";
            ResumeLayout(false);
        }

        #endregion

        private Button KATALOG;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}