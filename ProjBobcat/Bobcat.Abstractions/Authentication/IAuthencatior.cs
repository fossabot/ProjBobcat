using System;
using System.Collections.Generic;
using System.Text;

namespace Bobcat.Authentication
{
    /// <summary>
    /// 表示一个验证器。
    /// </summary>
    public interface IAuthenticator
    {
        ILauncherProfileParser LauncherProfileParser { get; set; }

        AuthResult Auth(bool userField);

        Task<AuthResult> AuthTaskAsync(bool userField);

        AuthResult GetLastAuthResult();
    }
}