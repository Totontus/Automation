using System;
using VehiclesClassSystem;
using VehiclesClassSystem.VehicleParts;
using System.Collections.Generic;

namespace VehicleFleet
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine[] engines = new Engine[]
            {
                new Engine("Petrol", "4242-zx", 200, 60),
                new Engine("Petrol", "5112-wq", 200, 40),
                new Engine("Petrol", "4851-sc", 180, 30),
                new Engine("Diesel", "4613-gq", 80, 1.2),
                new Engine("Petrol", "1241-sd", 100, 2),
                new Engine("Petrol", "4242-zx", 200, 60),
            };

            RollingChassis[] rollingChasses = new RollingChassis[]
            {
                new RollingChassis(4, "8989-as", 3_000),
                new RollingChassis(12, "1487-nv", 5_000),
                new RollingChassis(4, "1313-wq", 2_000),
                new RollingChassis(2, "9745-jy", 1_000),
                new RollingChassis(2, "6588-py", 1_000),
                new RollingChassis(4, "4363-jk", 5_000),
            };

            Transmission[] transmissions = new Transmission[]
            {
                new Transmission("Automatic", 4, "Japan"),
                new Transmission("Manual", 5, "Japan"),
                new Transmission("Automatic", 3, "Germany"),
                new Transmission("Automatic", 2, "China"),
                new Transmission("Manual", 2, "Russia"),
                new Transmission("Manual", 5, "USA"),
            };

            Car car = new Car(engines[0], rollingChasses[0], transmissions[0], false);
            Car car1 = new Car(engines[5], rollingChasses[5], transmissions[5], true);
            Truck truck = new Truck(engines[1], rollingChasses[1], transmissions[1], "Wood");
            Bus bus = new Bus(engines[2], rollingChasses[2], transmissions[2], 40);
            Scooter scooter = new Scooter(engines[3], rollingChasses[3], transmissions[3], true);
            Scooter scooter1 = new Scooter(engines[4], rollingChasses[4], transmissions[4], false);

            VehicleFleet park = new VehicleFleet(new List<Vehicle> { car, car1, truck, bus, scooter, scooter1 });
            Console.Write(park.ToString());

            Serializer<VehicleFleet>.Serialize("../../../XMLFiles/CollectionOfAllVehicles.xml", park);
            Serializer<Vehicle>.Serialize("../../../XMLFiles/VehiclesWithEngineVolumeGreaterThan1.5.xml", park.GetVehiclesWithEngineVolumeGreaterThan(1.5));
            Serializer<Engine>.Serialize("../../../XMLFiles/EnginesOfBussesAndTrucks.xml", park.GetEnginesOfBussesAndTrucks());
            Serializer<Vehicle>.Serialize("../../../XMLFiles/VehiclesGroupedByTransmission.xml", park.GroupByTransmission());
        }
    }
}