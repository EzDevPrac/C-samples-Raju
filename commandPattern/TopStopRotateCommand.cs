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

       

        public string Execute()
        {
            rotatingTop.StopRotating();
            return "TopStopRotateCommand.execute(): Invoking stopRotating() on RotatingTop";
          
            
        }

      
        public string Undo()
        {
            rotatingTop.StartRotating();
            return "TopStopRotateCommand.undo(): Undoing previous action->Invoking startRotating() on RotatingTop";
           
            
        }
    }
}
