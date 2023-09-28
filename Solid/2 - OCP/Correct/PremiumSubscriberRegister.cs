using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP.Correct
{
    public class PremiumSubscriberRegister : SubscriberRegister
    {
        public override void RegisterSubscribes(string name, string value, string signatureDate)
        {
            //registers the subscriber with the database according to the premium subscriber business rule
        }
    }
}
