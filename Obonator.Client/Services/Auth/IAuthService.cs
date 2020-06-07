using Obonator.Shared.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Obonator.Client.Services.Auth
{
    public interface IAuthService
    {
        Task<LoginResult> LocalLogin(LoginModel loginModel);
        Task LocalLogout();
        Task<LoginResult> Login(LoginModel loginModel); 
        Task Logout(); 
        Task<RegisterResult> Register(RegisterModel registerModel);
    }
}
