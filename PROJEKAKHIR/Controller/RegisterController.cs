using System;
using Npgsql;
using BibitKu.Helpers;

namespace BibitKu.Controllers
{
    public class RegisterController
    {
        public string RegisterPembeli(
            string nama,
            string email,
            string password,
            string noTelpon,
            string alamat)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // cek email sudah ada atau belum
                    string cekEmail = @"
                        SELECT COUNT(*)
                        FROM ""User""
                        WHERE email = @email";

                    using (var cmd = new NpgsqlCommand(cekEmail, conn))
                    {
                        cmd.Parameters.AddWithValue("email", email);

                        int jumlah =
                            Convert.ToInt32(cmd.ExecuteScalar());

                        if (jumlah > 0)
                            return "Email sudah digunakan.";
                    }

                    string query = @"
                        INSERT INTO ""User""
                        (
                            nama,
                            email,
                            password,
                            no_telpon,
                            alamat,
                            role
                        )
                        VALUES
                        (
                            @nama,
                            @email,
                            @password,
                            @no_telpon,
                            @alamat,
                            'Pembeli'
                        )";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("nama", nama);
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.Parameters.AddWithValue("password", password);
                        cmd.Parameters.AddWithValue("no_telpon", noTelpon);
                        cmd.Parameters.AddWithValue("alamat", alamat);

                        cmd.ExecuteNonQuery();
                    }
                }

                return "SUCCESS";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public string ValidasiInput(
            string nama,
            string email,
            string password,
            string noTelpon,
            string alamat)
        {
            if (string.IsNullOrWhiteSpace(nama))
                return "Nama tidak boleh kosong.";

            if (nama.Length < 3)
                return "Nama minimal 3 karakter.";

            if (string.IsNullOrWhiteSpace(email))
                return "Email tidak boleh kosong.";

            if (!email.Contains("@"))
                return "Format email tidak valid.";

            if (string.IsNullOrWhiteSpace(password))
                return "Password tidak boleh kosong.";

            if (password.Length < 6)
                return "Password minimal 6 karakter.";

            if (string.IsNullOrWhiteSpace(noTelpon))
                return "Nomor telepon tidak boleh kosong.";

            if (!long.TryParse(noTelpon, out _))
                return "Nomor telepon hanya boleh berisi angka.";

            if (noTelpon.Length < 10)
                return "Nomor telepon minimal 10 digit.";

            if (string.IsNullOrWhiteSpace(alamat))
                return "Alamat tidak boleh kosong.";

            return null; // valid
        }
    }
}