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

      

        public string Execute()
        {
            rotatingTop.StartRotating();
            return "TopRotateCommand.execute(): Invoking startRotating() on RotatingTop";
           
         
        }

       
        public string Undo()
        {
            rotatingTop.StopRotating();
            return "TopRotateCommand.undo(): Undoing previous action->Invoking stopRotating() on RotatingTop";
            
           
        }
    }
}
