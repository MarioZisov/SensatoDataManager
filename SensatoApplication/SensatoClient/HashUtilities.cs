namespace SensatoClient
{
    using System;
    using System.Security.Cryptography;
    using System.Text;

    public static class HashUtilities
    {
        public static string HashPassword(string password)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            var sha512 = SHA512.Create();
            byte[] hashBytes = sha512.ComputeHash(bytes);
            string hashPassword = Convert.ToBase64String(hashBytes);

            return hashPassword;
        }
    }
}
