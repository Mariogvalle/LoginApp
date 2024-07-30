namespace LoginApp
{
    public partial class App : Application
    {
        public static string GoogleClientId = "YOUR_GOOGLE_CLIENT_ID";
        public static string GoogleClientSecret = "YOUR_GOOGLE_CLIENT_SECRET";
        public static string RedirectUri = "com.yourcompany.loginapp:/oauth2redirect";
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.LoginPage());
        }
    }
}
