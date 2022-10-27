﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks.Models.Ducks
{
    public class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("Quack");
        }

        public void Quack()
        {
            Console.WriteLine("I`m flying");
        }
    }
}
