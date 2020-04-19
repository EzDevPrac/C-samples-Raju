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

        public string Execute()
        {
            car.Move();
            return "CarMoveCommand.execute(): Invoking move() on Car";
        }

       
        public string Undo()
        {
            car.Stop();
            return "CarMoveCommand.undo():  Undoing previous action->Invoking stop() on Car";
            
            
        }
    }
}
