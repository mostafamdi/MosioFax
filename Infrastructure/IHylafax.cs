using Atom8.Communications.Fax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSIOFAX_Send.Model
{
     
    public interface IHylafax
    {
        Hylafax  GetHylafax();
        string SendFax(string src, string dst, string host, string filename, Hylafax hylafax);
    }
}
