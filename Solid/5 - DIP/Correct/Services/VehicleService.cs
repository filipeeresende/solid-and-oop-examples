using Solid.DIP.Correct.Interface;
using Solid.DIP.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.Correct.Services
{
    public class VehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;
        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }
        public IList<Vehicle> GetAllVehicle()
        {
            return _vehicleRepository.GetAllVehicle();
        }
    }
}
