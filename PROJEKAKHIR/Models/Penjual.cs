namespace BibitKu.Models
{
    // ================================================================
    //  Model: Penjual
    //  Menerapkan konsep: Inheritance (extends User)
    //                     Overriding (GetInfo, GetDashboardTitle)
    // ================================================================
    public class Penjual : User
    {
        private string _namaToko;

        public string NamaToko
        {
            get { return _namaToko; }
            set { _namaToko = value; }
        }

        public Penjual() { }

        public Penjual(int id, string nama, string email, string namaToko)
            : base(id, nama, email, "Penjual")
        {
            _namaToko = namaToko;
        }

        // Override abstract method dari User
        public override string GetDashboardTitle()
        {
            return $"Dashboard Penjual — {NamaToko}";
        }

        // Override virtual method dari User
        public override string GetInfo()
        {
            return $"[Penjual] {Nama} | Toko: {_namaToko}";
        }
    }
}