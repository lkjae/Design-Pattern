using DesignPattern.Command.Commands;
using DesignPattern.Command.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command.Commands
{
    public class GarageDoorOpenCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Up();
        }
    }
}
