using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Car
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            VehicleBuilder builder;
            Shop shop = new Shop();

            // Construct and display vehicles

            builder = new Avantte();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new Grandeur();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new Sonata();
            shop.Construct(builder);
            builder.Vehicle.Show();

            // Wait for user

            Console.ReadKey();
        }
    }

    class Shop
    {
        // Builder uses a complex series of steps

        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.Engine();
            vehicleBuilder.MissionCooler();
            vehicleBuilder.Tire();
            vehicleBuilder.Turbo();
        }
    }

    abstract class VehicleBuilder
    {
        protected Vehicle vehicle;

        // Get vehicle instance

        public Vehicle Vehicle
        {
            get { return vehicle; }
        }

        // Abstract build methods

        public abstract void Engine();
        public abstract void MissionCooler();
        public abstract void Tire();
        public abstract void Turbo();

    }

    class Avantte : VehicleBuilder
    {
        public Avantte()
        {
            vehicle = new Vehicle("아반떼");

        }

        public override void Engine()
        {
            vehicle["engine"] = "AType";

        }
        public override void MissionCooler()
        {
            vehicle["missioncooler"] = "유";
        }
        public override void Tire()
        {
            vehicle["tire"] = "금호";
        }
        public override void Turbo()
        {
            vehicle["turbo"] = "무";
        }
        
    }

    class Grandeur : VehicleBuilder
    {
        public Grandeur()
        {
            vehicle = new Vehicle("그랜져");

        }

        public override void Engine()
        {
            vehicle["engine"] = "BType";

        }
        public override void MissionCooler()
        {
            vehicle["missioncooler"] = "유";
        }
        public override void Tire()
        {
            vehicle["tire"] = "미쉐린";
        }
        public override void Turbo()
        {
            vehicle["turbo"] = "유";
        }

    }

    class Sonata : VehicleBuilder
    {
        public Sonata()
        {
            vehicle = new Vehicle("소나타");

        }

        public override void Engine()
        {
            vehicle["engine"] = "CType";

        }
        public override void MissionCooler()
        {
            vehicle["missioncooler"] = "무";
        }
        public override void Tire()
        {
            vehicle["tire"] = "한국";
        }
        public override void Turbo()
        {
            vehicle["turbo"] = "무";
        }

    }

    class Vehicle
    {
        private string _vehicleName;
        private Dictionary<string, string> _part =
            new Dictionary<string, string>();

        // Constructor
        public Vehicle(string vehicleName)
        {
            this._vehicleName = vehicleName;
        }

        // Indexer

        public string this[string key]
        {
            get { return _part[key]; }
            set { _part[key] = value; }
        }

        internal void Show()
        {
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("Vehicle Name: {0}", _vehicleName);
            Console.WriteLine("Engine: {0}", _part["engine"]);
            Console.WriteLine("MissionCooler: {0}", _part["missioncooler"]);
            Console.WriteLine("Tire: {0}", _part["tire"]);
            Console.WriteLine("Turbo: {0}", _part["turbo"]);

        }
    }
}
