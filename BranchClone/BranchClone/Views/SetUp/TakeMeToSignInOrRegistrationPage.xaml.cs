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
    public partial class TakeMeToSignInOrRegistrationPage : ContentPage
    {
        public TakeMeToSignInOrRegistrationPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage.Navigation.PushAsync(new ChooseLanguagePage());
            }
            catch (Exception ex)
            {

                
            }
        }
    }
}