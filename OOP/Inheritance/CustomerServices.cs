using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class CustomerServices
    {
        public static Customer GetClient()
        {
            return new Customer
            {
                Name = "Filipe",
                Address = "Rua Brasil",
                Age = 24,
                Email = "filipe.dev@teste.com"
            };
        }
    }
}
// the client class is inheriting from the person class,
// so in the example above we can see that the client class
// can obtain all the states and behaviors of the parent class.