using System;

namespace commandPattern
{
    public class cmdPattern
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

    public class Car
    {
        public void move()
        {
            Console.WriteLine("Car is moving");
        }
        public void stop()
        {
            Console.WriteLine("Car has stopped");
        }
    }


    public interface ICommandBase
    {
        void execute();
        void undo();
    }




    public class RotatingTop
    {
        public void startRotating()
        {
            Console.WriteLine("Top has start rotating");
        }
        public void stopRotating()
        {
            Console.WriteLine("Top has stopped rotating");
        }
    }




    public class CarMoveCommand : ICommandBase
    {
        private Car car;
        public CarMoveCommand(Car car)
        {
            this.car = car;
        }

        public void execute()
        {
            Console.WriteLine("CarMoveCommand.execute(): Invoking move() on Car");
            car.move();
        }

        public void undo()
        {
            Console.WriteLine("CarMoveCommand.undo():  Undoing previous action->Invoking stop() on Car");
            car.stop();
        }
    }


    public class CarStopCommand : ICommandBase
    {
        private Car car;
        public CarStopCommand(Car car)
        {
            this.car = car;
        }

        public void execute()
        {
            Console.WriteLine("CarStopCommand.execute(): Invoking stop() on Car");
            car.stop();
        }

        public void undo()
        {
            Console.WriteLine("CarStopCommand.undo(): Undoing previous action-> Invoking move() on Car");
            car.move();
        }
    }


    public class TopRotateCommand : ICommandBase
    {
        RotatingTop rotatingTop;
        public TopRotateCommand(RotatingTop rotatingTop)
        {
            this.rotatingTop = rotatingTop;
        }

        public void execute()
        {
            Console.WriteLine("TopRotateCommand.execute(): Invoking startRotating() on RotatingTop");
            rotatingTop.startRotating();
        }

        public void undo()
        {
            Console.WriteLine("TopRotateCommand.undo(): Undoing previous action->Invoking stopRotating() on RotatingTop");
            rotatingTop.stopRotating();
        }
    }


    public class TopStopRotateCommand : ICommandBase
    {
        RotatingTop rotatingTop;
        public TopStopRotateCommand(RotatingTop rotatingTop)
        {
            this.rotatingTop = rotatingTop;
        }

        public void execute()
        {
            Console.WriteLine("TopStopRotateCommand.execute(): Invoking stopRotating() on RotatingTop");
            rotatingTop.stopRotating();
        }

        public void undo()
        {
            Console.WriteLine("TopStopRotateCommand.undo(): Undoing previous action->Invoking startRotating() on RotatingTop");
            rotatingTop.startRotating();
        }
    }


    public class RemoteControl
    {
        ICommandBase onCommand, offCommand, undoCommand;
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
