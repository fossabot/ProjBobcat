using System;
using System.Collections.Generic;
using System.Text;

namespace Bobcat.ForgeInstallers
{
    public interface IForgeInstaller
    {
        string ForgeExecutablePath { get; set; }
        string ForgeInstallPath { get; set; }

        ForgeInstallResult InstallForge();

        Task<ForgeInstallResult> InstallForgeTaskAsync();

        event EventHandler<ForgeInstallStageChangedEventArgs> StageChangedEventDelegate;
    }
}