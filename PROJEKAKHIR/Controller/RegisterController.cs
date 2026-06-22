using System;
using Npgsql;
using BibitKu.Helpers;
using BibitKu.Models;

namespace BibitKu.Controllers
{
    public class RegisterController
    {
        /// <summary>
        /// Memvalidasi data Pembeli sebelum didaftarkan.
        /// Mengembalikan pesan error jika tidak valid, null jika valid.
        /// </summary>
        public string ValidasiInput(Pembeli pembeli)
        {
            if (pembeli == null)
                return "Data registrasi tidak boleh kosong.";

            if (string.IsNullOrWhiteSpace(pembeli.Nama))
                return "Nama tidak boleh kosong.";

            if (pembeli.Nama.Length < 3)
                return "Nama minimal 3 karakter.";

            if (string.IsNullOrWhiteSpace(pembeli.Email))
                return "Email tidak boleh kosong.";

            if (!pembeli.Email.Contains("@") || !pembeli.Email.Contains("."))
                return "Format email tidak valid.";

            if (string.IsNullOrWhiteSpace(pembeli.Password))
                return "Password tidak boleh kosong.";

            if (pembeli.Password.Length < 6)
                return "Password minimal 6 karakter.";

            if (string.IsNullOrWhiteSpace(pembeli.NoTelpon))
                return "Nomor telepon tidak boleh kosong.";

            if (!long.TryParse(pembeli.NoTelpon, out _))
                return "Nomor telepon hanya boleh berisi angka.";

            if (pembeli.NoTelpon.Length < 10)
                return "Nomor telepon minimal 10 digit.";

            if (string.IsNullOrWhiteSpace(pembeli.Alamat))
                return "Alamat tidak boleh kosong.";

            return null; // semua valid
        }

        /// <summary>
        /// Mendaftarkan Pembeli baru ke database.
        /// Mengembalikan "SUCCESS" jika berhasil, atau pesan error jika gagal.
        /// </summary>
        public string RegisterPembeli(Pembeli pembeli)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    if (EmailSudahTerdaftar(conn, pembeli.Email))
                        return "Email sudah digunakan.";

                    InsertPembeli(conn, pembeli);
                }

                return "SUCCESS";
            }
            catch (Exception ex)
            {
                return $"Terjadi kesalahan: {ex.Message}";
            }
        }

        // ----------------------------------------------------------------
        // Private helpers
        // ----------------------------------------------------------------

        private bool EmailSudahTerdaftar(NpgsqlConnection conn, string email)
        {
            const string sql = @"
                SELECT COUNT(*)
                FROM ""User""
                WHERE email = @email";

            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("email", email);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private void InsertPembeli(NpgsqlConnection conn, Pembeli pembeli)
        {
            const string sql = @"
                INSERT INTO ""User""
                    (nama, email, password, no_telpon, alamat, role)
                VALUES
                    (@nama, @email, @password, @no_telpon, @alamat, 'Pembeli')";

            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("nama",      pembeli.Nama);
                cmd.Parameters.AddWithValue("email",     pembeli.Email);
                cmd.Parameters.AddWithValue("password",  pembeli.Password);
                cmd.Parameters.AddWithValue("no_telpon", pembeli.NoTelpon);
                cmd.Parameters.AddWithValue("alamat",    pembeli.Alamat);

                cmd.ExecuteNonQuery();
            }
        }
    }
}