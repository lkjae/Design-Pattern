using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks.Models.Turkeys
{
    internal class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("I1m flying a short distance");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble gobble");
        }
    }
}
