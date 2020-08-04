using System;

namespace Bobcat.Events
{
    public class DownloadFileChangedEventArgs : EventArgs
    {
        public double ProgressPercentage { get; set; }
    }
}