using Atom8.Communications.Fax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSIOFAX_Send.Model
{
    public class HylafaxConnection :IHylafaxConnection
    {
        private string _host, _userName, _password, _productKey;
        private int _port;
        public   HylafaxConnection(string productKey,string host, string userName, string password , int port)
        {
            _host = host;
            _userName = userName;
            _password = password;
            _productKey = productKey;
            _port = port;
        }
        public Hylafax GetHylafaxConnection()
        {
            return new Hylafax(_productKey, _host, _port, _userName, _password);
        }


    }
}
