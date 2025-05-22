using Atom8.Communications.Fax;
using MSIOFAX_Send.Sservices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSIOFAX_Send.Model
{
    public class HFax :IHylafax
    {
        private string host, userName, password;
        private int port;
        private ISecureStorage _secureStorage;
        public HFax(string _host, string _userName, string _password , int _port, ISecureStorage secureStorage)
        {
            host = _host;
            userName = _userName;
            password = _password;
            port = _port;
            _secureStorage = secureStorage;

        }
        public Hylafax GetHylafax()
        {
            string pass = _secureStorage.Decrypt(password);
            return new Hylafax("VOTT-FOFS-SESN-TETH", host, port, userName, pass);
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


    }
}
