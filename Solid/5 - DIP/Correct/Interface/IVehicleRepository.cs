using Solid.DIP.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.Correct.Interface
{
    public interface IVehicleRepository
    {
        IList<Vehicle> GetAllVehicle();
    }
}
