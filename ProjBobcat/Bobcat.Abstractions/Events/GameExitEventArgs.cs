using System;
using System.Collections.Generic;
using System.Text;

namespace Bobcat.Events
{
    public class GameExitEventArgs : EventArgs
    {
        public Exception Exception { get; set; }

        public int ExitCode { get; set; }
    }
}