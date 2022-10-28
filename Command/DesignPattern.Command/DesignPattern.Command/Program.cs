﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Command.Commands;
using DesignPattern.Command.Receivers;

namespace DesignPattern.Command
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var remote = new Invokers.SimpleRemoteControl();

            var light = new Light();
            var garageDoor = new GarageDoor();

            var lightOn = new LightOnCommand(light);
            var garageOpen = new GarageDoorOpenCommand(garageDoor);

            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();

            remote.SetCommand(garageOpen);
            remote.ButtonWasPressed();
        }
    }
}
