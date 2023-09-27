using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation
{
    public class Execute
    {
        public void ExecuteProduct()
        {
            ProductService.InsertProduct();
        }
    }
}

// we can see that when calling the ProductService class we can only see
// the insertProduct method, so we are encapsulating the other methods that
// we do not want this class to see