using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP.Incorrect
{
    public class SubscriberRegister
    {
        public void RegisterSubscribes(string name, string value, SubscriberType signatureType)
        {
            if (signatureType == SubscriberType.StandardSubscriber)
            {
                //registers the subscriber with the database according to the Standard subscriber business rule
            }
            if (signatureType == SubscriberType.PremiumSubscriber)
            {
                //registers the subscriber with the database according to the premium subscriber business rule
            }
        }
    }
}
