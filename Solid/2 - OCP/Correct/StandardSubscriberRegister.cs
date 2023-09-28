using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP.Correct
{
    public class StandardSubscriberRegister : SubscriberRegister
    {
        public override void RegisterSubscribes(string name, string value, string signatureDate)
        {
            //registers the subscriber with the database according to the Standard subscriber business rule
        }
    }
}
