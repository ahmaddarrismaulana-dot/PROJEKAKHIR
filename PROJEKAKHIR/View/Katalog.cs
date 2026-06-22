using Bibitku.Controllers;
using PROJEKAKHIR.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PROJEKAKHIR
{
    public partial class Katalog : UserControl
    {
        private BibitController controller = new BibitController();

        public Katalog()
        {
            InitializeComponent();

            this.Load += Katalog_Load;
            txtCari.TextChanged += txtCari_TextChanged;
        }

        private void Katalog_Load(object sender, EventArgs e)
        {
            List<Bibit> data = controller.GetAllBibit();

            MessageBox.Show(
                "Jumlah Bibit : " + data.Count
            );

            LoadProduk();
        }

        private void LoadProduk()
        {
            try
            {
                flpProduk.Controls.Clear();

                List<Bibit> daftarBibit = controller.GetAllBibit();

                foreach (Bibit bibit in daftarBibit)
                {
                    CardBibit card = new CardBibit();

                    card.Width = 230;
                    card.Height = 380;

                    card.SetData(bibit);

                    flpProduk.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                flpProduk.Controls.Clear();

                List<Bibit> hasil =
                    controller.CariBibit(txtCari.Text);

                foreach (Bibit bibit in hasil)
                {
                    CardBibit card = new CardBibit();

                    card.Width = 230;
                    card.Height = 380;

                    card.SetData(bibit);

                    flpProduk.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}