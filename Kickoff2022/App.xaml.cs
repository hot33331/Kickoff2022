using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Kickoff2022.Services;
using Kickoff2022.Views;

namespace Kickoff2022
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
