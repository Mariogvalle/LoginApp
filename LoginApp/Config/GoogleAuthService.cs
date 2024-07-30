using IdentityModel.OidcClient;
using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace LoginApp.Config
{
    public class GoogleAuthService
    {
        private readonly OidcClient _oidcClient;

        public GoogleAuthService()
        {
            var options = new OidcClientOptions
            {
                Authority = "https://accounts.google.com",
                ClientId = App.GoogleClientId,
                RedirectUri = App.RedirectUri,
                Scope = "openid profile email",
                ClientSecret = App.GoogleClientSecret
            };

            _oidcClient = new OidcClient(options);
        }

        public async Task LoginAsync()
        {
            var result = await _oidcClient.LoginAsync();

            if (result.IsError)
            {
                await Application.Current.MainPage.DisplayAlert("Error", result.Error, "OK");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Aviso", $"Bienvenido, {result.User.Identity.Name}!", "OK");
            }
        }
    }
}
