using System;
using Npgsql;
using BibitKu.Models;
using BibitKu.Helpers;

namespace BibitKu.Controllers
{
    public class LoginController
    {
        public User Login(string email, string password)
        {
            return CariUser(email, password, null);
        }

        public User Login(string email, string password, string role)
        {
            return CariUser(email, password, role);
        }

        private User CariUser(string email, string password, string role)
        {
            User user = null;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT u.id, u.nama, u.email, u.password,
                               u.no_telpon, u.alamat, u.role,
                               t.id_toko, t.nama_toko
                        FROM ""User"" u
                        LEFT JOIN ""Toko"" t ON t.id_user = u.id
                        WHERE u.email = @email
                          AND u.password = @password";

                    if (!string.IsNullOrEmpty(role))
                        query += " AND u.role = @role";

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

                                string namaToko = reader.IsDBNull(8) ? "-" : reader.GetString(8);

                                // ✔ PENJUAL
                                if (roleDb == "Penjual")
                                {
                                    user = new Penjual(id, nama, em, namaToko)
                                    {
                                        NoTelpon = noTelpon,
                                        Alamat = alamat
                                    };
                                }
                                // ✔ PEMBELI
                                else if (roleDb == "Pembeli")
                                {
                                    user = new Pembeli(id, nama, em)
                                    {
                                        NoTelpon = noTelpon,
                                        Alamat = alamat
                                    };
                                }

                                // 🔥 TAMBAHAN PENTING: SIMPAN ID TOKO KE SESSION
                                if (roleDb == "Penjual" && !reader.IsDBNull(7))
                                {
                                    Session.IdToko = reader.GetInt32(7);
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

            return user;
        }

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

            return null;
        }
    }
}