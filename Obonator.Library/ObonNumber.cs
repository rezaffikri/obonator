using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Obonator.Library
{
    public class ObonNumber
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
        /// Get one random number between 0-9999
        /// </summary>
        /// <returns></returns>
        public static long GenerateRandomNumber()
        {
            return _tlRng.Value.Next(9999);
        }

        /// <summary>
        /// Get random number between 0-(lenght)
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static int GenerateRandomNumber(int length)
        {
            return _tlRng.Value.Next(length);
        }

        /// <summary>
        /// Get crypto one random number between 0-9999
        /// </summary>
        /// <returns></returns>
        public static long GenerateCryptoRandomNumber()
        {
            return _tlRngCry.Value.Next(9999);
        }

        /// <summary>
        /// Get crypto random number between 0-(lenght)
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static int GenerateCryptoRandomNumber(int length)
        {
            return _tlRngCry.Value.Next(length);
        }

        public static int HexToInt(string hex)
        {
            int ret = -1;

            try
            {
                ret = Convert.ToInt32(hex, 16);
            }
            catch { }

            return ret;
        }

        public static string IntToHex(int num)
        {
            string ret = "";

            try
            {
                ret = Convert.ToString(num, 16);
            }
            catch { }

            return ret;
        }

        public static DateTime ToDateTime(object strdate)
        {
            DateTime ret = new DateTime();

            try
            {
                ret = Convert.ToDateTime(strdate);
            }

            catch { }

            return ret;
        }

        public static DateTime ToDateTime(string strdate)
        {
            DateTime ret = new DateTime();

            try
            {
                ret = Convert.ToDateTime(strdate);
            }

            catch { }

            return ret;
        }

        public static int ToInt(string strnum)
        {
            int i = 0;

            try
            {
                double d = Convert.ToDouble(strnum);
                i = Convert.ToInt32(d);
            }
            catch
            { }

            return i;
        }

        public static long ToLong(string strnum)
        {
            long i = 0;

            try
            {
                double d = Convert.ToDouble(strnum);
                i = Convert.ToInt64(d);
            }
            catch
            { }

            return i;
        }

        public static double ToDouble(string strnum)
        {
            double ret = 0;

            try
            {
                ret = Convert.ToDouble(strnum);
            }
            catch { }

            return ret;
        }

        public static string FormatAmount(int amt)
        {
            return FormatAmount(amt.ToString());
        }

        public static string FormatAmount(long amt)
        {
            return FormatAmount(amt.ToString());
        }

        public static string FormatAmount(string amt)
        {
            amt = amt.Replace(",", "");
            amt = amt.Replace(".", "");

            long iamt = ToLong(amt);
            string ret = iamt.ToString("##,##");

            if (ret == "")
                ret = "0";

            return ret;
        }
    }
}
