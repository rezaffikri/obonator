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

        public class StrUtil
        {
            public string Str { get; set; }
            private int SubBefore { get; set; }

            public StrUtil(string s)
            {
                Str = s;
                SubBefore = 0;
            }

            public string getString(int sub)
            {
                try
                {
                    string result = Str.Substring(SubBefore, sub);
                    SubBefore = SubBefore + sub;
                    return result;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        public class AuthLocal
        {
            public static string CheckLogin(string username, string password)
            {
                string role = "";
                if (username.Trim().ToLower().Equals("admin") && password.Trim().Equals("Passobon1!"))
                {
                    role = "admin";
                }
                else if (username.Trim().ToLower().Equals("qa") && password.Trim().Equals("qa123!"))
                {
                    role = "qa";
                }
                else if (username.Trim().ToLower().Equals("se") && password.Trim().Equals("se321!"))
                {
                    role = "se";
                }
                return role;
            }

            public static string CheckLogin(string username)
            {
                string role = "";
                if (username.Trim().ToLower().Equals("admin"))
                {
                    role = "admin";
                }
                else if (username.Trim().ToLower().Equals("qa"))
                {
                    role = "qa";
                }
                else if (username.Trim().ToLower().Equals("se"))
                {
                    role = "se";
                }
                return role;
            }
        }
    }
}
