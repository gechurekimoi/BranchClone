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
    public partial class ChooseLanguagePage : ContentPage
    {
        public ChooseLanguagePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = DependencyService.Get<ChooseLanguagePageViewModel>();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {

                App.Current.MainPage.Navigation.PushAsync(new SelectCountryPage());

            }
            catch (Exception ex)
            {

                
            }
        }
    }
}