using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class CarMoveCommand: ICommandBase
    {
        private Car car;
        public CarMoveCommand(Car car)
        {
            this.car = car;
        }

        public void execute()
        {
            Console.WriteLine("CarMoveCommand.execute(): Invoking move() on Car");
            car.Move();
        }

        public void undo()
        {
            Console.WriteLine("CarMoveCommand.undo():  Undoing previous action->Invoking stop() on Car");
            car.Stop();
        }
    }
}
