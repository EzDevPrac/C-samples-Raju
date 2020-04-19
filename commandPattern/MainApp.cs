using Command;
using System;

namespace DesignPatterns.Command
{
    public  class CmdPattern
    {

        public static void Main(String[] args)
        {
            RemoteControl remoteControl = new RemoteControl();
           
           
            Car car = new Car();
            ICommandBase carMoveCommand = new CarMoveCommand(car);
            remoteControl.OnButtonPressed(carMoveCommand);
          
            ICommandBase carStopCommand = new CarStopCommand(car);
            remoteControl.OffButtonPressed(carStopCommand);
           
            remoteControl.UndoButtonPressed();

            RotatingTop top = new RotatingTop();
            ICommandBase topRotateCommand = new TopRotateCommand(top);
            remoteControl.OnButtonPressed(topRotateCommand);
            ICommandBase topStopRotateCommand = new TopStopRotateCommand(top);
            remoteControl.OffButtonPressed(topStopRotateCommand);
          
            remoteControl.UndoButtonPressed();
            Console.ReadLine();
        }
    }

}
