using Ducks.Models.Ducks;
using Ducks.Models.Turkeys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks.Adapters
{
    public class DuckAdapter :ITurkey //Target Interface
    {
        //adaptee interface
        private readonly IDuck _duck;
        private readonly Random _random;

        public DuckAdapter(IDuck duck)
        {
            _duck = duck;
            _random = new Random();
        }

        public void Gobble()
        {
            _duck.Quack();
        }

        public void Fly()
        {
            if(_random.Next(5) == 0)
            {
                _duck.Fly();
            }
        }
    }
}
