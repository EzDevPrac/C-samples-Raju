using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class RemoteControl
    {
        public ICommandBase onCommand, offCommand, undoCommand;
        public void onButtonPressed(ICommandBase onCommand)
        {
            this.onCommand = onCommand;
            onCommand.execute();
            undoCommand = onCommand;
        }
        public void offButtonPressed(ICommandBase offCommand)
        {
            this.offCommand = offCommand;
            offCommand.execute();
            undoCommand = offCommand;
        }
        public void undoButtonPressed()
        {
            undoCommand.undo();
        }
    }
}
