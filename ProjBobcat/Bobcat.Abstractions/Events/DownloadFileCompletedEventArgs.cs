using System;
using System.Collections.Generic;
using System.Text;

namespace Bobcat.Events
{
    public class DownloadFileCompletedEventArgs : EventArgs
    {
        public DownloadFileCompletedEventArgs(bool success, Exception ex, DownloadFile file)
        {
            Success = success;
            Error = ex;
            File = file;
        }

        public DownloadFile File { get; }
        public bool Success { get; }
        public Exception Error { get; }
    }
}