using System;
using System.Collections.Generic;
using System.Text;

namespace Bobcat.GameResources
{
    public interface IResourceInfoResolver
    {
        string BasePath { get; set; }
        VersionInfo VersionInfo { get; set; }

        Task<IEnumerable<IGameResource>> ResolveResourceTaskAsync();

        IEnumerable<IGameResource> ResolveResource();

        event EventHandler<GameResourceInfoResolveEventArgs> GameResourceInfoResolveEvent;
    }
}