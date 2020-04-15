using Command;
using System;

namespace DesignPatterns.Command
{
    public class CmdPattern
    {

        public static void Main(String[] args)
        {
            RemoteControl remoteControl = new RemoteControl();
           
            Car car = new Car();
            ICommandBase carMoveCommand = new CarMoveCommand(car);
            remoteControl.onButtonPressed(carMoveCommand);
          
            ICommandBase carStopCommand = new CarStopCommand(car);
            remoteControl.offButtonPressed(carStopCommand);
           
            remoteControl.undoButtonPressed();

            RotatingTop top = new RotatingTop();
            ICommandBase topRotateCommand = new TopRotateCommand(top);
            remoteControl.onButtonPressed(topRotateCommand);
            ICommandBase topStopRotateCommand = new TopStopRotateCommand(top);
            remoteControl.offButtonPressed(topStopRotateCommand);
          
            remoteControl.undoButtonPressed();
        }
    }

}
