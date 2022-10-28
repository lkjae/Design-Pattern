using DesignPattern.Command.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command.Invokers
{
    public class SimpleRemoteControl
    {
        private ICommand _slot;

        public void SetCommand(ICommand command) => _slot = command;

        public void ButtonWasPressed() => _slot.Execute();

    }
}
