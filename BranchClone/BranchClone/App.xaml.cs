using BranchClone.Services;
using BranchClone.ViewModels;
using BranchClone.Views;
using BranchClone.Views.SetUp;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BranchClone
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDA2ODI4QDMxMzgyZTM0MmUzME5KMU5rUXEvMkV2R2JkT1VVd3VkWUJTWThZR2hxSUhFUUYzd2xEbS9VekU9");

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<ChooseLanguagePageViewModel>();
            DependencyService.Register<SelectCountryPageViewModel>();

            MainPage = new NavigationPage(new TakeMeToSignInOrRegistrationPage());
            //MainPage = new NavigationPage(new DashboardPage());
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
