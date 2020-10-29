using System;
using System.Text;

namespace Obonator.Library
{
    public class ObonNumber
    {
        private static Random mRandom = new Random();
        public static string GenerateRandomNumber(int length)
        {
            char[] chArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            StringBuilder str = new StringBuilder();
            for (int i = 1; i <= length; i++)
            {
                int index = mRandom.Next(10);
                str.Append(Convert.ToString(chArray[index]));
            }
            return Convert.ToString(str);
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
