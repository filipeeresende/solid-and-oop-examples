using Solid.DIP.Entites;
using Solid.DIP.Incorrect.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.Incorrect.Services
{
    public class VehicleService
    {
        private readonly VehicleRepository _vehicleRepository;
        public VehicleService(VehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }
        public IList<Vehicle> GetAllVehicle()
        {
            return _vehicleRepository.GetAllVehicle();
        }
    }
}
