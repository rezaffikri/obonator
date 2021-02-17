using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Obonator.Library
{
    public class ObonString
    {
        private static int _seedCount = 0;
        private static ThreadLocal<Random> _tlRng = new ThreadLocal<Random>(() => new Random(GenerateSeed()));
        private static ThreadLocal<Random> _tlRngCry = new ThreadLocal<Random>(() => new Random(GenerateSeedCry()));

        private static int GenerateSeed()
        {
            // note the usage of Interlocked, remember that in a shared context we can't just "_seedCount++"
            return (int)((DateTime.Now.Ticks << 4) + Interlocked.Increment(ref _seedCount));
        }

        private static int GenerateSeedCry()
        {
            // Because we cannot use the default randomizer, which is based on the current time 
            // (it will produce the same "random" number within a second), we will use a random number 
            // generator to seed the randomizer. Use a 4-byte array to fill it with random bytes and convert
            // it then to an integer value.
            var randomBytes = new byte[4];

            // Generate 4 random bytes.
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(randomBytes);

            // Convert 4 bytes into a 32-bit integer value.
            var seed = (randomBytes[0] & 0x7f) << 24 |
                       randomBytes[1] << 16 |
                       randomBytes[2] << 8 |
                       randomBytes[3];

            return seed;
        }

        /// <summary>
        /// Get random string number with a length of (length)
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string GenerateRandomStringNumber(int length)
        {
            char[] chArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            StringBuilder str = new StringBuilder();
            for (int i = 1; i <= length; i++)
            {
                int index = _tlRng.Value.Next(10);
                str.Append(Convert.ToString(chArray[index]));
            }
            return str.ToString();
        }

        /// <summary>
        /// Get random string hex with a length of (length)
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string GenerateRandomStringHex(int length)
        {
            char[] chArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            StringBuilder str = new StringBuilder();
            for (int i = 1; i <= length; i++)
            {
                int index = _tlRng.Value.Next(16);
                str.Append(Convert.ToString(chArray[index]));
            }
            return str.ToString();
        }

        /// <summary>
        /// Get random string AN + S(!@#$) with a length of (length)
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string GenerateRandomStringANS(int length)
        {
            char[] chArray = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
                'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 
                'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '!', '@', '#', '$' };
            StringBuilder str = new StringBuilder();
            for (int i = 1; i <= length; i++)
            {
                int index = _tlRng.Value.Next(16);
                str.Append(Convert.ToString(chArray[index]));
            }
            return str.ToString();
        }

        /// <summary>
        /// Get crypto random string number with a length of (length)
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string GenerateCryRandomStringNumber(int length)
        {
            char[] chArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            StringBuilder str = new StringBuilder();
            for (int i = 1; i <= length; i++)
            {
                int index = _tlRngCry.Value.Next(10);
                str.Append(Convert.ToString(chArray[index]));
            }
            return str.ToString();
        }

        /// <summary>
        /// Get crypto random string hex with a length of (length)
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string GenerateCryRandomStringHex(int length)
        {
            char[] chArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            StringBuilder str = new StringBuilder();
            for (int i = 1; i <= length; i++)
            {
                int index = _tlRngCry.Value.Next(16);
                str.Append(Convert.ToString(chArray[index]));
            }
            return str.ToString();
        }

        /// <summary>
        /// Get crypto random string AN + S(!@#$) with a length of (length)
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string GenerateCryRandomStringANS(int length)
        {
            const string globalChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$";
            string a = "";
            StringBuilder res = new StringBuilder();
            int i = length;
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];
                while (i > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(globalChar[(int)(num % (uint)globalChar.Length)]);
                    i--;
                }
            }
            a = res.ToString();
            return a;
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public class AutoSubstring
        {
            public string Str { get; set; }
            private int SubBefore { get; set; }

            public AutoSubstring(string s)
            {
                Str = s;
                SubBefore = 0;
            }

            /// <summary>
            /// First sub string start from start index (0) to end index (stringLength) and
            /// Next sub string start from start index (last start Index + last end index) + to end index (stringLength)
            /// </summary>
            /// <param name="sub"></param>
            /// <returns></returns>
            public string Substring(int stringLength)
            {
                try
                {
                    string result = Str.Substring(SubBefore, stringLength);
                    SubBefore += stringLength;
                    return result;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
    }
}
