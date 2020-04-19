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

        public string Execute()
        {
            car.Stop();
            return "CarStopCommand.execute(): Invoking stop() on Car";
        }

       

        public string Undo()
        {
            car.Move();
            return "CarStopCommand.undo(): Undoing previous action-> Invoking move() on Car";
        }
    }
}
