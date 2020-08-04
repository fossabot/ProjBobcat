using System;
using System.Collections.Generic;
using System.Text;

namespace Bobcat.Events
{
    public class GameResourceInfoResolveEventArgs : EventArgs
    {
        public string CurrentProgress { get; set; }
        public LogType LogType { get; set; }
    }
}