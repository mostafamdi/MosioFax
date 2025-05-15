using System;
using System.Security.Cryptography;
using System.Text;
using static System.Net.WebRequestMethods;
namespace MSIOFAX_Send.Sservices
{
    public class SecureStorage: ISecureStorage
    {
        public   string Encrypt(string data)
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            byte[] encryptedData = ProtectedData.Protect(dataBytes, null, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encryptedData);
        }

       
        public   string Decrypt(string encryptedData)
        {
            byte[] dataBytes = Convert.FromBase64String(encryptedData);
            byte[] decryptedBytes = ProtectedData.Unprotect(dataBytes, null, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(decryptedBytes);
        }
    }
}
