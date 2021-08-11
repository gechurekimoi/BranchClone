using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BranchClone.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoanOfferConfirmPage : ContentPage
	{
		public LoanOfferConfirmPage ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {

                await App.Current.MainPage.Navigation.PushAsync(new ConfirmDepositAccountPage());

            }
            catch (Exception ex)
            {

                
            }
        }
    }
}