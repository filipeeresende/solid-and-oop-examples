using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SRP.Correct.Dto
{
    public class Email
    {
        public string EmailAddress { get; set; }

        public bool Validar()
        {
            return EmailAddress.Contains("@");
        }
    }
}
