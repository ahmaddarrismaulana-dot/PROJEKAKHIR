namespace BibitKu.Models
{
    public abstract class User
    {
        // Fields private Enkapsulasi
        private int _id;
        private string _nama;
        private string _email;
        private string _password;
        private string _noTelpon;
        private string _alamat;
        private string _role;

        // Properties getter & setter
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string NoTelpon
        {
            get { return _noTelpon; }
            set { _noTelpon = value; }
        }

        public string Alamat
        {
            get { return _alamat; }
            set { _alamat = value; }
        }

        public string Role
        {
            get { return _role; }
            set { _role = value; }
        }

        //Constructor
        public User() { }

        public User(int id, string nama, string email, string role)
        {
            _id = id;
            _nama = nama;
            _email = email;
            _role = role;
        }
        public abstract string GetDashboardTitle();
        public virtual string GetInfo()
        {
            return $"[{_role}] {_nama} — {_email}";
        }
    }
}