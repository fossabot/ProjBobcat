using System;
using System.Collections.Generic;
using System.Text;

namespace Bobcat.Events
{
    public class ForgeInstallStageChangedEventArgs : EventArgs
    {
        public string CurrentStage { get; set; }
        public double Progress { get; set; }
    }
}