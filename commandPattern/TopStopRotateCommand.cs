using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class TopStopRotateCommand :ICommandBase
    {
        RotatingTop rotatingTop;
        public TopStopRotateCommand(RotatingTop rotatingTop)
        {
            this.rotatingTop = rotatingTop;
        }

        public void execute()
        {
            Console.WriteLine("TopStopRotateCommand.execute(): Invoking stopRotating() on RotatingTop");
            rotatingTop.StopRotating();
        }

        public void undo()
        {
            Console.WriteLine("TopStopRotateCommand.undo(): Undoing previous action->Invoking startRotating() on RotatingTop");
            rotatingTop.StartRotating();
        }
    }
}
