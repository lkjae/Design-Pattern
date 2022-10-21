using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_House
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            HouseBuilder builder;

            Shop shop = new Shop();
            
            builder = new house_01();
            shop.Construct(builder);
            builder.House.Show();
        }
    }

    class Shop
    {
        public void Construct(HouseBuilder housebuilder)
        {
            housebuilder.GarageParts();
            housebuilder.SwimmingPoolParts();
            housebuilder.FancyStatuesParts();
            housebuilder.GardenParts();

        }

    }

    abstract class HouseBuilder
    {
        protected House house;

        public House House
        {
            get { return house; }
        }

        // Abstract build methods

        public abstract void GarageParts();
        public abstract void SwimmingPoolParts();
        public abstract void FancyStatuesParts();
        public abstract void GardenParts();

    }

    class house_01 : HouseBuilder
    {
        public house_01()
        {
            house = new House("house_01");
        }
        public override void GarageParts()
        {
            house["garage"] = "유";
        }
        public override void SwimmingPoolParts()
        {
            house["pool"] = "유";
        }
        public override void FancyStatuesParts()
        {
            house["statues"] = "무";
        }
        public override void GardenParts()
        {
            house["garden"] = "무";
        }
    }



    internal class House
    {
        private string _housename;
        private Dictionary<string, string> _parts =
            new Dictionary<string, string>();

        public House(string housename)
        {
            this._housename = housename;
        }

        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        internal void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine(" HouseName : {0}", _housename);
            Console.WriteLine(" GarageParts : {0}", _parts["garage"]);
            Console.WriteLine(" SwimmingPoolParts : {0}", _parts["pool"]);
            Console.WriteLine(" FancyStatuesParts: {0}", _parts["statues"]);
            Console.WriteLine(" GardenParts : {0}", _parts["garden"]);
        }
    }
}
