﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text.Json;

namespace Obonator.Library
{
    public class ObonEmail
    {
        private static string MailBody = "";
        private static string MailTo = "";
        private static string Subject = "";
        private static string SmtpServer = "";
        private static int SmtpPort = 0;
        private static string SmtpUsername = "";
        private static string SmtpName = "";
        private static string SmtpPassword = "";
        private static string LastErrorMsg = "";
        private static bool IsSetEmailParam;
        private static bool IsSetEmailSettings;

        public static void SetEmailParam(string mailBody, string mailTo, string subject)
        {
            MailBody = mailBody;
            MailTo = mailTo;
            Subject = subject;
            IsSetEmailParam = true;
        }

        public static void SetEmailSettings(string smtpServer, int smtpPort, string smptUsername,
            string smptName, string smtpPassword)
        {
            SmtpServer = smtpServer;
            SmtpPort = smtpPort;
            SmtpUsername = smptUsername;
            SmtpName = smptName;
            SmtpPassword = smtpPassword;
            IsSetEmailSettings = true;
        }

        public static void SetEmailSettingsDefault()
        {
            if (string.IsNullOrEmpty(SmtpName))
            {
                SmtpName = "Obonator";
            }
            if (string.IsNullOrEmpty(SmtpPassword))
            {
                SmtpPassword = "P@ssw0rd1!Obon";
            }
            if (SmtpPort <= 0)
            {
                SmtpPort = 587;
            }
            if (string.IsNullOrEmpty(SmtpServer))
            {
                SmtpServer = "smtp.gmail.com";
            }
            if (string.IsNullOrEmpty(SmtpUsername))
            {
                SmtpUsername = "obonzilla@gmail.com";
            }
            IsSetEmailSettings = true;
        }

        public string GetLastErrorMsg()
        {
            return LastErrorMsg;
        }

        public static bool SendEmail()
        {
            if (!IsSetEmailParam)
            {
                LastErrorMsg = "Email param not set";
                return false;
            }
            if (!IsSetEmailSettings)
            {
                LastErrorMsg = "Email settings not set";
                return false;
            }

            bool isSuccess = false;
            string remark = string.Empty;
            try
            {
                using (var message = new MailMessage())
                {
                    message.From = new MailAddress(SmtpUsername, SmtpName);
                    message.To.Add(MailTo);
                    message.Subject = Subject;
                    message.IsBodyHtml = true; //to make message body as html  
                    message.Body = MailBody;
                    using (var smtp = new SmtpClient())
                    {
                        smtp.Port = SmtpPort;
                        smtp.Host = SmtpServer;
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential(SmtpUsername, SmtpPassword);
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                        int tryAgain = 4;
                        bool failed = false;
                        //kirim email dan ulang sebanyak 3x jika gagal, total 4x
                        do
                        {
                            try
                            {
                                //gedein timeout tiap gagal, total waktu pengulangan 295 detik
                                if (tryAgain == 4)
                                {
                                    smtp.Timeout = 30000;
                                }
                                else if (tryAgain == 3)
                                {
                                    smtp.Timeout = 60000;
                                }
                                else if (tryAgain == 2)
                                {
                                    smtp.Timeout = 90000;
                                }
                                else if (tryAgain == 1)
                                {
                                    smtp.Timeout = 115000;
                                }
                                failed = false;
                                remark = "";
                                smtp.Send(message);
                                isSuccess = true;
                            }
                            catch (SmtpException ex)
                            {
                                isSuccess = false;
                                failed = true;
                                tryAgain--;
                                switch (ex.StatusCode)
                                {
                                    case SmtpStatusCode.GeneralFailure:
                                        remark = $"SMTP service Server {SmtpServer} tidak ditemukan, StatusCode: {SmtpStatusCode.GeneralFailure}";
                                        tryAgain = 0;
                                        break;
                                    case SmtpStatusCode.ServiceNotAvailable:
                                        remark = $"SMTP service di Server {SmtpServer} tidak tersedia, StatusCode: {SmtpStatusCode.ServiceNotAvailable}";
                                        tryAgain = 0;
                                        break;
                                    case SmtpStatusCode.MailboxBusy:
                                        remark = $"Mailbox penerima sedang penuh, StatusCode: {SmtpStatusCode.MailboxBusy}";
                                        tryAgain = 0;
                                        break;
                                    case SmtpStatusCode.InsufficientStorage:
                                        remark = $"Storage host penerima penuh, StatusCode: {SmtpStatusCode.InsufficientStorage}";
                                        tryAgain = 0;
                                        break;
                                    case SmtpStatusCode.ClientNotPermitted:
                                        remark = $"Gagal autentikasi atau tidak diperbolehkan untuk mengirim email dengan Server {SmtpServer}, StatusCode: {SmtpStatusCode.ClientNotPermitted}";
                                        break;
                                    case SmtpStatusCode.MailboxUnavailable:
                                        remark = $"Mailbox penerima tidak tersedia, StatusCode: {SmtpStatusCode.MailboxUnavailable}";
                                        tryAgain = 0;
                                        break;
                                    case SmtpStatusCode.UserNotLocalTryAlternatePath:
                                        remark = $"Mailbox tidak ada di server, StatusCode: {SmtpStatusCode.UserNotLocalTryAlternatePath}";
                                        tryAgain = 0;
                                        break;
                                    case SmtpStatusCode.ExceededStorageAllocation:
                                        remark = $"Storage penerima penuh, StatusCode: {SmtpStatusCode.ExceededStorageAllocation}";
                                        break;
                                    case SmtpStatusCode.TransactionFailed:
                                        remark = $"Gagal, StatusCode: {SmtpStatusCode.TransactionFailed}";
                                        break;
                                    default:
                                        remark = $"Terjadi kesalahan";
                                        break;
                                }
                            }
                        } while (failed && tryAgain != 0);
                    }
                }
            }
            catch (Exception ex)
            {
                remark = ex.ToString();
            }
            LastErrorMsg = remark;
            return isSuccess;
        }
    }
}
