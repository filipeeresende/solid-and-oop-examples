﻿using Solid.DIP.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.Incorrect.Repository
{
    public class VehicleRepository
    {
        public IList<Vehicle> GetAllVehicle()
        {
            //search the database for all vehicles
            return new List<Vehicle>();
        }
    }
}
