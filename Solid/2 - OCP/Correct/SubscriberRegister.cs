using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP.Correct
{
    public abstract class SubscriberRegister
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public DateTime SignatureDate { get; set; }

        public abstract void RegisterSubscribes(string name, string value, string signatureDate);
    }
}
