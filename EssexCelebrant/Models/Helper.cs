using System;
using System.Configuration;
using System.Net.Mail;

namespace EssexCelebrant.Models
{
    public class Helper
    {
        public static string AppSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        /// <summary>
        /// Sends the requested email.
        /// </summary>
        /// <param name="toAddress"></param>
        /// <param name="subject"></param>
        /// <param name="emailBodyText"></param>
        public static string SendEmail(string toAddress, string subject, string emailBodyText, string customerEmail)
        {
            SmtpClient client = null;
            try
            {
                // Extract all of the required settings
                string fromMailAddress = AppSetting("Email.FromAddress");
                string emailServer = AppSetting("Email.Server");
                int portNumber = AppSetting("Email.Port") == string.Empty ? 0 : Convert.ToInt32(AppSetting("Email.Port"));

                MailAddress fromMail = new MailAddress(fromMailAddress);
                MailAddress toMail = new MailAddress(toAddress);

                MailMessage msgDetails = new MailMessage(fromMail, toMail);

                #region Add the CC mail addresses
                if (string.Empty != customerEmail)
                    msgDetails.CC.Add(customerEmail);

                string ccEmail = AppSetting("Email.CCMailAddress");
                if (ccEmail.Contains(";"))
                {
                    string[] ccMailAddresses = ccEmail.Split(';');
                    foreach (string c in ccMailAddresses)
                        if (!string.IsNullOrEmpty(c))
                            msgDetails.CC.Add(c);
                }
                else if (string.Empty != ccEmail)
                    msgDetails.CC.Add(ccEmail);
                #endregion Add the CC mail addresses

                #region Add the BCC mail addresses
                string bccEmail = AppSetting("Email.BCCMailAddress");
                if (bccEmail.Contains(";"))
                {
                    string[] bccMailAddresses = bccEmail.Split(';');
                    foreach (string b in bccMailAddresses)
                    {
                        if (!string.IsNullOrEmpty(b))
                            msgDetails.Bcc.Add(b);
                    }
                }
                else if (string.Empty != bccEmail)
                    msgDetails.Bcc.Add(bccEmail);
                #endregion Add the BCC mail addresses

                msgDetails.Body = emailBodyText;
                msgDetails.IsBodyHtml = true;
                msgDetails.Subject = subject;

                // Send the email.
                client = new SmtpClient(emailServer, portNumber)
                {
                    EnableSsl = Convert.ToBoolean(AppSetting("Email.Encryption")),
                    Credentials = new System.Net.NetworkCredential("hello@rsstudios.co.uk", "}k>+FBvsQTvJs6xx.y&qVq,+?nEFaa0f1Ss!Qs}_Hg3+=VZp]L21*b&G}AZB@IY4")
                };
                client.Send(msgDetails);
            }
            catch (Exception ex)
            {
                //throw new ApplicationException("Email not sent.  Message: " + ex.Message + ".  InnerEx: " + ex.InnerException);
                return "Email not sent.  Message: " + ex.Message + ".  InnerEx: " + ex.InnerException;
            }
            finally
            {
                if (null != client)
                    client = null;
            }

            return string.Empty;
        }
    }
}