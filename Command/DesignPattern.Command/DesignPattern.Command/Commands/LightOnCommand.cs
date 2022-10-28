using DesignPattern.Command.Commands;
using DesignPattern.Command.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command.Commands
{
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;
        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();                      
        }
    }
}
