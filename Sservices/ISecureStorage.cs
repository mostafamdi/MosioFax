using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSIOFAX_Send.Sservices
{
    public   interface ISecureStorage
    {
          string Encrypt(string data);
          string Decrypt(string encryptedData);
    }
}
