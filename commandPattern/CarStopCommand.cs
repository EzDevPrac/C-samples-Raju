using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class CarStopCommand:ICommandBase
    {
        private Car car;
        public CarStopCommand(Car car)
        {
            this.car = car;
        }

        public void execute()
        {
            Console.WriteLine("CarStopCommand.execute(): Invoking stop() on Car");
            car.Stop();
        }

        public void undo()
        {
            Console.WriteLine("CarStopCommand.undo(): Undoing previous action-> Invoking move() on Car");
            car.Move();
        }
    }
}
