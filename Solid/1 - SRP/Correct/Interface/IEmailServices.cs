using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SRP.Correct.Interface
{
    public interface IEmailServices
    {
        void SendEmail(string from, string to, string subject, string body);
    }
}
