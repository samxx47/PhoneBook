using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhoneBook
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public App(string databaseLocation)
        {
            InitializeComponent();

            MainPage = new MainPage();
            DatabaseLocation = databaseLocation;

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
