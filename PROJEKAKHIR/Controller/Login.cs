using System;
using Npgsql;
using BibitKu.Models;
using BibitKu.Helpers;

namespace BibitKu.Controllers
{
    // ================================================================
    //  Controller: LoginController
    //  Menghubungkan View (FormLogin) dengan Model (User)
    //  Menerapkan konsep: Enkapsulasi, Polymorphism
    // ================================================================
    public class LoginController
    {
        // ── LOGIN ────────────────────────────────────────────────────
        // Overloading: Login(email, password) dan Login(email, password, role)
        // Menerapkan konsep: Method Overloading

        /// <summary>
        /// Login tanpa filter role — cari user berdasarkan email & password saja.
        /// </summary>
        public User Login(string email, string password)
        {
            return CariUser(email, password, null);
        }

        /// <summary>
        /// Login dengan filter role — validasi email, password, DAN role sekaligus.
        /// </summary>
        public User Login(string email, string password, string role)
        {
            return CariUser(email, password, role);
        }

        // ── Private: Query ke database ───────────────────────────────
        private User CariUser(string email, string password, string role)
        {
            User user = null;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Susun query — jika role disertakan, tambahkan filter role
                    string query = @"
                        SELECT u.id, u.nama, u.email, u.password,
                               u.no_telpon, u.alamat, u.role,
                               t.nama_toko
                        FROM ""User"" u
                        LEFT JOIN ""Toko"" t ON t.id_user = u.id
                        WHERE u.email    = @email
                          AND u.password = @password";

                    if (!string.IsNullOrEmpty(role))
                        query += @" AND u.role = @role";

                    query += " LIMIT 1";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.Parameters.AddWithValue("password", password);

                        if (!string.IsNullOrEmpty(role))
                            cmd.Parameters.AddWithValue("role", role);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string nama = reader.GetString(1);
                                string em = reader.GetString(2);
                                string noTelpon = reader.GetString(4);
                                string alamat = reader.GetString(5);
                                string roleDb = reader.GetString(6);

                                // Polymorphism: bentuk objek berbeda tergantung role
                                if (roleDb == "Penjual")
                                {
                                    string namaToko = reader.IsDBNull(7)
                                        ? "-" : reader.GetString(7);

                                    user = new Penjual(id, nama, em, namaToko)
                                    {
                                        NoTelpon = noTelpon,
                                        Alamat = alamat
                                    };
                                }
                                else if (roleDb == "Pembeli")
                                {
                                    user = new Pembeli(id, nama, em)
                                    {
                                        NoTelpon = noTelpon,
                                        Alamat = alamat
                                    };
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal terhubung ke database: " + ex.Message);
            }

            return user; // null = login gagal
        }

        // ── VALIDASI INPUT ───────────────────────────────────────────
        public string ValidasiInput(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email))
                return "Email tidak boleh kosong.";

            if (!email.Contains("@"))
                return "Format email tidak valid.";

            if (string.IsNullOrWhiteSpace(password))
                return "Password tidak boleh kosong.";

            if (password.Length < 6)
                return "Password minimal 6 karakter.";

            return null; // null = valid
        }
    }
}
