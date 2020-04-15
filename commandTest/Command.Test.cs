
using DesignPatterns.Command;
using System;
using Xunit;

namespace DesignPatterns.Command.Test
{
    public class cmdPattern
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }
        [Fact]
        public void move()
        {
            RemoteControl remoteControl = new RemoteControl();
            Console.WriteLine("-----Testing onButtonPressed on RemoteControl for Car-----");
            Car car = new Car();
            ICommandBase carMoveCommand = new CarMoveCommand(car);
            remoteControl.onButtonPressed(carMoveCommand);


            Console.WriteLine("-----Testing offButtonPressed on RemoteControl for Car-----");
            ICommandBase carStopCommand = new CarStopCommand(car);
            remoteControl.offButtonPressed(carStopCommand);
            Console.WriteLine("-----Testing undoButtonPressed() on RemoteControl for Car-----");
            remoteControl.undoButtonPressed();
            Console.WriteLine("-----Testing onButtonPressed on RemoteControl for RotatingTop-----");
            RotatingTop top = new RotatingTop();
            ICommandBase topRotateCommand = new TopRotateCommand(top);
            remoteControl.onButtonPressed(topRotateCommand);
            Console.WriteLine("-----Testing offButtonPressed on RemoteControl for RotatingTop-----");
            ICommandBase topStopRotateCommand = new TopStopRotateCommand(top);
            remoteControl.offButtonPressed(topStopRotateCommand);
            Console.WriteLine("-----Testing undoButtonPressed on RemoteControl for RotatingTop-----");
            remoteControl.undoButtonPressed();

        }
    }
}
