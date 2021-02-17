using Obonator.Library;
using System;
using System.Security.Cryptography;

namespace Obonator.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string password = "P@ssw0rd1!123Hg%&";

                ObonPassword.Hasher.SetHashSettings(new ObonPassword.Hasher.HashSettings
                {
                    IterCount = 100000,
                    Prf = Microsoft.AspNetCore.Cryptography.KeyDerivation.KeyDerivationPrf.HMACSHA256,
                    SaltSize = 256 / 8,
                    NumBytesRequested = 256 / 8,
                });
                string hashPassword = ObonPassword.Hasher.HashPasswordV2(password);
                bool valid = ObonPassword.Hasher.VerifyHashedPasswordV2(hashPassword, password);
            }
            catch (Exception ex)
            {
                var e = ex.ToString();
                throw;
            }
        }
    }
}
