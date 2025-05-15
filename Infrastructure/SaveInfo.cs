using MSIOFAX_Send.Sservices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSIOFAX_Send.Infrastructure
{
    public class SaveInfo
    {
        private string UserName { get; set; }
        private string Password { get; set; }
        private ISecureStorage SecureStorage;

        public SaveInfo(string username, string password, ISecureStorage secureStorage)
        {
            UserName = username;
            Password = password;
            SecureStorage = secureStorage;
        }


    }
}
