using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public class VehicleClient
    {
        readonly IBike bike;
        readonly IScooter scooter;

        public VehicleClient(IVehicleFactory factory, VehicleType type)
        {
            bike = factory.GetBike(type);
            scooter = factory.GetScooter(type);
        }

        public string GetBikeName(string name)
        {
            return bike.GetBikeName(name);
        }

        public string GetScooterName(string name)
        {
            return scooter.GetScooterName(name);
        }
    }
}
