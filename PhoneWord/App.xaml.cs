using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PhoneWord
{
    public partial class App : Application
    {

        public static IList<string> PhoneNumbers { get; set; }

        public App()
        {
            InitializeComponent();
            // the PhoneNumbers collection will be used to store a list of each translated phone number called by the app
            PhoneNumbers = new List<string>();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
