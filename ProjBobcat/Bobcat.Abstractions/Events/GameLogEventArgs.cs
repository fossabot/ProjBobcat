using System;
using System.Collections.Generic;
using System.Text;

namespace Bobcat.Events
{
    public class GameLogEventArgs : EventArgs
    {
        public string LogType { get; set; }
        public string Content { get; set; }
    }
}