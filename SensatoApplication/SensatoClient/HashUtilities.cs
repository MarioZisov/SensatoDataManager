using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SensatoClient
{
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
