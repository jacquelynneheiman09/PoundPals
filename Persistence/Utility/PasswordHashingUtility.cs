using BCrypt.Net;

namespace Persistence.Utility
{
    public static class PasswordHashingUtility
    {
        public static string HashPassword(string password) 
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}