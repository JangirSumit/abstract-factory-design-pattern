using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public interface IVehicleFactory
    {
        IBike GetBike(VehicleType Bike);
        IScooter GetScooter(VehicleType Scooter);
    }
}
