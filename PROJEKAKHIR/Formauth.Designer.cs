namespace PROJEKAKHIR
{
    partial class Formauth
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
            panel1 = new Panel();
            panel2 = new Panel();
            registerControl1 = new RegisterControl();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(568, 525);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(registerControl1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(568, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(601, 525);
            panel2.TabIndex = 1;
            // 
            // registerControl1
            // 
            registerControl1.BackColor = Color.White;
            registerControl1.Dock = DockStyle.Fill;
            registerControl1.Location = new Point(0, 0);
            registerControl1.Name = "registerControl1";
            registerControl1.Size = new Size(601, 525);
            registerControl1.TabIndex = 0;
            registerControl1.Load += registerControl1_Load;
            // 
            // Formauth
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 525);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formauth";
            Text = "Formauth";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private RegisterControl registerControl1;
    }
}