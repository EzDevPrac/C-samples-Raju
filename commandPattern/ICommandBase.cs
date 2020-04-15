using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public interface ICommandBase
    {
        void execute();
        void undo();
    }
}
