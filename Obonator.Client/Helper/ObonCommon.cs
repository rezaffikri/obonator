using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Obonator.Client.Helper
{
    public class ObonCommon
    {
        public static class AppConstants
        {
#if DEBUG
            public const bool IS_DEBUG = true;
#else
            public const bool IS_DEBUG = false;
#endif
        }

        public class AuthLocal
        {
            public static string CheckLogin(string username, string password)
            {
                string hashPassword = Obonator.Library.ObonCryptography.MD5Hash.Hash(username+password);
                string role = "";
                if (hashPassword.Equals("124e6da995fefd5c31f8ef90366fb55c"))
                {
                    role = "admin";
                }
                return role;
            }

            public static string CheckLogin(string username)
            {
                string role = "";
                if (username.Trim().ToLower().Equals("obon"))
                {
                    role = "admin";
                }
                else if (username.Trim().ToLower().Equals("guest"))
                {
                    role = "guest";
                }
                return role;
            }
        }
    }
}
