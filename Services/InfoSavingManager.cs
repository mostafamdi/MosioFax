using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace MSIOFAX_Send.Sservices
{
    public  static class InfoSavingManager
    {
       
        public static string SaveInfo(string host, string username, string password, string productkey)
        {
            try
            {
                Properties.Settings.Default.FaxPassword = Encrypt(password);
                Properties.Settings.Default.FaxUsername = username;
                Properties.Settings.Default.Host = host;
                Properties.Settings.Default.Product_Key = productkey;
                Properties.Settings.Default.Save();
                return "";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public static Dictionary<string, string> GetInformation()
        {
            var info = new Dictionary<string, string>();
            info["host"] = Properties.Settings.Default.Host;
            info["faxuser"] = Properties.Settings.Default.FaxUsername;
            info["faxpass"] = Properties.Settings.Default.FaxPassword;
            return info;
        }
        public static string Encrypt(string data)
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            byte[] encryptedData = ProtectedData.Protect(dataBytes, null, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encryptedData);
        }
        public static string Decrypt(string encryptedData)
        {
            byte[] dataBytes = Convert.FromBase64String(encryptedData);
            byte[] decryptedBytes = ProtectedData.Unprotect(dataBytes, null, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(decryptedBytes);
        }
    }
}
