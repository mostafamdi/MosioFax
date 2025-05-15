using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSIOFAX_Send.Sservices
{
    public static class GetInfo
    {
        public static Dictionary<string, string> GetInformation()
        {
            var info = new Dictionary<string, string>();
            info["serverip"] = Properties.Settings.Default.ServerIP;
            info["faxuser"] = Properties.Settings.Default.FaxUsername;
            info["faxpass"] = Properties.Settings.Default.FaxPassword;
            return info;
        }
    }
}
