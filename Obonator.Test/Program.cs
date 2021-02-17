using Obonator.Library;
using System;

namespace Obonator.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "(&&@kaask1@#_+zNBan@lakdasdasdasdeDDFA343$(!(@nkadub2";

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
    }
}
