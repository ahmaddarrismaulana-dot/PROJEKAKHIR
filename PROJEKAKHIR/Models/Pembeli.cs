namespace BibitKu.Models
{
    
    public class Pembeli : User
    {
        public Pembeli() { }

        public Pembeli(int id, string nama, string email)
            : base(id, nama, email, "Pembeli") { }

        public override string GetDashboardTitle()
        {
            return $"Dashboard Pembeli — Halo, {Nama}";
        }
        public override string GetInfo()
        {
            return $"[Pembeli] {Nama} | {Alamat}";
        }
    }
}