using APLUS;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APLUS_Guli
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Signin());
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
