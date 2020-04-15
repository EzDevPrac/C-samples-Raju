using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class TopRotateCommand:ICommandBase
    {
        RotatingTop rotatingTop;
        public TopRotateCommand(RotatingTop rotatingTop)
        {
            this.rotatingTop = rotatingTop;
        }

        public void execute()
        {
            Console.WriteLine("TopRotateCommand.execute(): Invoking startRotating() on RotatingTop");
            rotatingTop.StartRotating();
        }

        public void undo()
        {
            Console.WriteLine("TopRotateCommand.undo(): Undoing previous action->Invoking stopRotating() on RotatingTop");
            rotatingTop.StopRotating();
        }
    }
}
