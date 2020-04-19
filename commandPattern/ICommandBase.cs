using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public interface ICommandBase
    {
        public string Execute();
        public string Undo();

    }
}
