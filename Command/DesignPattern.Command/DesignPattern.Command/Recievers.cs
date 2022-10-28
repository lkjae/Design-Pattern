using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command.Receivers
{
    public class GarageDoor
    {
        public void Up() => Console.WriteLine("Garage Door is Open");
        public void Down() => Console.WriteLine("Garage Door is Closed");
        public void Stop() => Console.WriteLine("Garage Door is Stopped");
        public void LightOn() => Console.WriteLine("Garage Light is On");
        public void LightOff() => Console.WriteLine("Garage Light is Off");

    }

    public class Light
    {
        public void On() => Console.WriteLine("Light is on");
        public void Off() => Console.WriteLine("Light is off");
    }
}
