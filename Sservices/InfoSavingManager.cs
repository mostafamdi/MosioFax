using System;
namespace MSIOFAX_Send.Sservices
{
    public class InfoSavingManager
    {
        private string UserName { get; set; }
        private string Password { get; set; }
        private string ServerIP { get; set; }
        private string ProductKey { get; set; }
        private ISecureStorage SecureStorage;
        public InfoSavingManager(string username, string password, string serverIP, string productKey, ISecureStorage secureStorage)
        {
            UserName = username;
            Password = password;
            ServerIP = serverIP;
            SecureStorage = secureStorage;
        }
        public string SaveInfo()
        {
            try
            {
                Properties.Settings.Default.FaxPassword = SecureStorage.Encrypt(Password);
                Properties.Settings.Default.FaxUsername = UserName;
                Properties.Settings.Default.ServerIP = ServerIP;
                Properties.Settings.Default.Product_Key = ProductKey;
                Properties.Settings.Default.Save();
                return "";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string GetPassword(string password)
        {
            return SecureStorage.Decrypt(password);
        }
    }
}
