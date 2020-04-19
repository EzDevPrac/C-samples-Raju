using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class RemoteControl
    {
        public ICommandBase onCommand, offCommand, undoCommand;
        public string OnButtonPressed(ICommandBase onCommand)
        {
            this.onCommand = onCommand;
            onCommand.Execute();
             undoCommand = onCommand;
            return Convert.ToString(undoCommand);
        }
        public string OffButtonPressed(ICommandBase offCommand)
        {
            this.offCommand = offCommand;
            offCommand.Execute();
            undoCommand = offCommand;
            return Convert.ToString(undoCommand);
        }
        public string UndoButtonPressed()
        { 
            return undoCommand.Undo();
        }
    }
}
