using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    public class VehicleRepository : BaseRepository
    {
        public override void GetById()
        {
            //new implementation with another validation to search by id
        }
    }
}
// This way we can rewrite the method by placing validations that are not implemented in the BaseRepository class