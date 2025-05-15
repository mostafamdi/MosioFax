using Atom8.Communications.Fax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSIOFAX_Send.Model
{
    public class FaxSender
    {

        private IHylafaxConnection _hylafaxConnection;
        private string _dst, _src, _filename, _serverIP;
        public FaxSender(string src, string dst, string filename,string serverIP, IHylafaxConnection hylafaxConnection)
        {
            _src = src;
            _dst = dst;
            _filename = filename;
            _serverIP = serverIP;
            _hylafaxConnection = hylafaxConnection;
        }
        public string SendFax()
        {
            HylafaxModem modem1 = new HylafaxModem();
            modem1.ModemName = _src;
            modem1.PhoneNumber = _src;
            modem1.IsActive = true;
            modem1.ServerName =_serverIP;
            
            ////////////
            var hylafaxConnection = _hylafaxConnection.GetHylafaxConnection();
            hylafaxConnection.Modems.Add(modem1);
            ///////////
            HylafaxJobSettings hylaFaxSetting = new HylafaxJobSettings();
            hylaFaxSetting.FaxNumber = _dst;
            hylaFaxSetting.FromUser = _src;
            string faxId = hylafaxConnection.SendFax(_filename, _filename, hylaFaxSetting);
            return faxId;
        }
    }
}
