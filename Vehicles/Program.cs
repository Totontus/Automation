using System;
using VehiclesClassSystem;
using VehiclesClassSystem.VehicleParts;


namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine[] engines = new Engine[]
            {
                new Engine("Petrol", "df-3628", 300, 60),
                new Engine("Diesel", "nd-2719", 500, 70),
                new Engine("Petrol", "ri-2033", 400, 90),
                new Engine("Petrol", "ug-4891", 300, 40),
            };

            RollingChassis[] rollingChasses = new RollingChassis[]
            {
                new RollingChassis(4, "be-2745", 3_000),
                new RollingChassis(12, "gf-9981", 30_000),
                new RollingChassis(8, "sd-0615", 12_000),
                new RollingChassis(2, "is-2390", 1_000),
            };

            Transmission[] transmissions = new Transmission[]
            {
                new Transmission("Automatic", 5, "Japan"),
                new Transmission("Automatic", 6, "Germany"),
                new Transmission("Manual", 5, "Russia"),
                new Transmission("Manual", 5, "China"),
            };

            Car car = new Car(engines[0], rollingChasses[0], transmissions[0], true);
            Console.WriteLine($"----------\nCar:\n----------\n{car}");
            Truck truck = new Truck(engines[1], rollingChasses[1], transmissions[1], "Wood");
            Console.WriteLine($"----------\nTruck:\n----------\n{truck}");
            Bus bus = new Bus(engines[2], rollingChasses[2], transmissions[2], 40);
            Console.WriteLine($"----------\nBus:\n----------\n{bus}");
            Scooter scooter = new Scooter(engines[3], rollingChasses[3], transmissions[3], true);
            Console.WriteLine($"----------\nScooter:\n----------\n{scooter}");
        }
    }
}
