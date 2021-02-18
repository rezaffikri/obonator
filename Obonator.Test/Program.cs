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
                string password = "P@ssw0rd1!123Hg%&dasar632FA$#das$%@ffs&3!f%";

                string saltClient = ObonPassword.Hasher.GenerateSaltString(128 / 8, "rezaffikri12345");
                ObonPassword.Hasher.SetHashSettings(new ObonPassword.Hasher.HashSettings
                {
                    IterCount = 210000,
                    Prf = Microsoft.AspNetCore.Cryptography.KeyDerivation.KeyDerivationPrf.HMACSHA256,
                    SaltSize = 256 / 8,
                    NumBytesRequested = 256 / 8,
                    SaltValue = saltClient,
                    FixedSalt = "078FCCAA754100FE7E175449A9FD208A7C"
                });
                string passwordRegisHash = ObonPassword.Hasher.HashPasswordV1(password);

                ObonPassword.Hasher.SetHashSettings(new ObonPassword.Hasher.HashSettings
                {
                    IterCount = 210000,
                    Prf = Microsoft.AspNetCore.Cryptography.KeyDerivation.KeyDerivationPrf.HMACSHA256,
                    SaltSize = 256 / 8,
                    NumBytesRequested = 256 / 8,
                    FixedSalt = "073F2C4FBAE8D9C139351BD0E5D8972B8A",
                });
                string serverHashServer = ObonPassword.Hasher.HashPasswordV2(passwordRegisHash);

                ObonPassword.Hasher.SetHashSettings(new ObonPassword.Hasher.HashSettings
                {
                    IterCount = 210000,
                    Prf = Microsoft.AspNetCore.Cryptography.KeyDerivation.KeyDerivationPrf.HMACSHA256,
                    SaltSize = 256 / 8,
                    NumBytesRequested = 256 / 8,
                    SaltValue = saltClient,
                    FixedSalt = "078FCCAA754100FE7E175449A9FD208A7C"
                });
                string clientHash = ObonPassword.Hasher.HashPasswordV1(password);

                ObonPassword.Hasher.SetHashSettings(new ObonPassword.Hasher.HashSettings
                {
                    IterCount = 210000,
                    Prf = Microsoft.AspNetCore.Cryptography.KeyDerivation.KeyDerivationPrf.HMACSHA256,
                    SaltSize = 192 / 8,
                    NumBytesRequested = 256 / 8,
                    FixedSalt = "073F2C4FBAE8D9C139351BD0E5D8972B8A",
                });

                bool valid = ObonPassword.Hasher.VerifyHashedPasswordV2(serverHashServer, clientHash);
            }
            catch (Exception ex)
            {
                var e = ex.ToString();
                throw;
            }
        }
    }
}
