using IdentityModel.OidcClient;
using LoginApp.Config;
namespace LoginApp.Views
{
    public partial class LoginPage : ContentPage
    {
        private readonly GoogleAuthService _authService;

        public LoginPage()
        {
            InitializeComponent();
            _authService = new GoogleAuthService();
        }

        private async void OnLoginWithGoogleClicked(object sender, EventArgs e)
        {
            await _authService.LoginAsync();
        }
    }
}