using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Obonator.Client.Helper;
using Obonator.Shared.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Obonator.Client.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorage;

        public AuthService(HttpClient httpClient,
                           AuthenticationStateProvider authenticationStateProvider,
                           ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
            _localStorage = localStorage;
        }

        public async Task<RegisterResult> Register(RegisterModel registerModel)
        {
            var result = await _httpClient.PostJsonAsync<RegisterResult>("api/accounts", registerModel);

            return result;
        }

        public async Task<LoginResult> LocalLogin(LoginModel loginModel)
        {
            LoginResult loginResult = new LoginResult();
#if DEBUG
            loginResult.IsDebug = true;
#endif

            string role = ObonCommon.AuthLocal.CheckLogin(loginModel.Email, loginModel.Password);
            if (!string.IsNullOrEmpty(role))
            {
                loginResult.Successful = true;
            }
            else
            {
                loginResult.Successful = false;
                loginResult.Error = "User atau Password salah";
            }

            if (loginResult.Successful)
            {
                ((ApiAuthenticationStateProvider)_authenticationStateProvider).LocalMarkUserAsAuthenticated(loginModel.Email, role);
                await _localStorage.SetItemAsync("authToken", loginModel.Email);
                if (loginModel.RememberMe)
                {
                    await _localStorage.SetItemAsync("authUser", loginModel.Email);
                }
            }

            return loginResult;
        }

        public async Task<LoginResult> LocalLogout()
        {
            LoginResult loginResult = new LoginResult();
#if DEBUG
            loginResult.IsDebug = true;
#endif
            await _localStorage.RemoveItemAsync("authToken");
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            loginResult.Successful = true;
            return loginResult;
        }

        public async Task<LoginResult> Login(LoginModel loginModel)
        {
            var result = await _httpClient.PostJsonAsync<LoginResult>("api/Login", loginModel);

            if (result.Successful)
            {
                await _localStorage.SetItemAsync("authToken", result.Token);
                ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(result.Token);
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", result.Token);

                return result;
            }

            return result;
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }
    }
}
