using BibitKu.Models;

namespace BibitKu.Views
{
    internal class FormDashboardPembeli
    {
        internal Action<object, object> FormClosed;
        private Pembeli pembeli;

        public FormDashboardPembeli(Pembeli pembeli)
        {
            this.pembeli = pembeli;
        }
    }
}