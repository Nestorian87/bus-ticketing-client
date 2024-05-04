﻿namespace BusTicketingSystem.Managers
{
    public static class PasswordHashingManager
    {

        public static string HashPasword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool VerifyPassword(string password, string passwordHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, passwordHash);
        }

    }
}
