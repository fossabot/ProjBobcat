using System;
using System.Collections.Generic;
using System.Text;

namespace Bobcat.Events
{
    public class LaunchLogEventArgs : EventArgs
    {
        public string Item { get; set; }
        public TimeSpan ItemRunTime { get; set; }
    }
}