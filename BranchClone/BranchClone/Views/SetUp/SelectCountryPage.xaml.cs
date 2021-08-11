using BranchClone.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BranchClone.Views.SetUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectCountryPage : ContentPage
    {
        public SelectCountryPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = DependencyService.Get<SelectCountryPageViewModel>();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                await App.Current.MainPage.Navigation.PushAsync(new EnterPhoneNumberPage());
            }
            catch (Exception ex)
            {

                
            }
        }
    }
}