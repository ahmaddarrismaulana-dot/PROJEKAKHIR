using BibitKu.Models;

namespace BibitKu.Helpers
{
    public static class Session
    {
        public static User CurrentUser { get; set; }

        // 🔥 TAMBAHAN PENTING
        public static int IdToko { get; set; }

        public static bool IsLogin
        {
            get { return CurrentUser != null; }
        }

        public static void Logout()
        {
            CurrentUser = null;
            IdToko = 0; // reset juga
        }
    }
}