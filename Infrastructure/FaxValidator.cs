using MSIOFAX_Send.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSIOFAX_Send.Infrastructure
{
    public class FaxValidator
    {
        public Dictionary<string, string> Validate(Fax fax)
        {
            var errors = new Dictionary<string, string>();

            if(string.IsNullOrWhiteSpace(fax.Src))
                errors["Src"] = "Src is required.";

            if(string.IsNullOrWhiteSpace(fax.Dst))
                errors["Dst"] = "Dst is required.";

            if (string.IsNullOrEmpty(fax.File))
                errors["File"] = "File is required.";

            return errors;
        }
    }
}
