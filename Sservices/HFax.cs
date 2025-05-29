using Atom8.Communications.Fax;
using MSIOFAX_Send.Sservices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MSIOFAX_Send.Model
{
    public class HFax  
    {
      
        private static HFax _instance;
        public Hylafax hyalafax { get; private set; }

        private HFax(string _host, string _userName, string _password , int _port )
        {
            //string password = Decrypt(_password);
            hyalafax =new Hylafax("VOTT-FOFS-SESN-TETH", _host, _port, _userName, _password);
        }
        public static HFax GetInstance(string _host, string _userName, string _password, int _port)
        {
            if (_instance == null)
            {
                string pass = Decrypt(_password);
                _instance = new HFax(_host, _userName, pass, _port);
            }
            return _instance;
        }
         
        public string SendFax(string src, string dst, string host, string filename, Hylafax hylafax)
        {
            HylafaxModem modem1 = new HylafaxModem();
            modem1.ModemName = src;
            modem1.PhoneNumber = src;
            modem1.IsActive = true;
            modem1.ServerName = host;

            ////////////
            hylafax.Modems.Add(modem1);
            ///////////
            HylafaxJobSettings hylaFaxSetting = new HylafaxJobSettings();
            hylaFaxSetting.FaxNumber = dst;
            hylaFaxSetting.FromUser = src;
            string faxId = hylafax.SendFax(filename, filename, hylaFaxSetting);
            return faxId;
        }
        public static string Decrypt(string encryptedData)
        {
            byte[] dataBytes = Convert.FromBase64String(encryptedData);
            byte[] decryptedBytes = ProtectedData.Unprotect(dataBytes, null, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(decryptedBytes);
        }

    }
}
