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
	public partial class ConfirmDepositAccountPage : ContentPage
	{
		public ConfirmDepositAccountPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {

                App.Current.MainPage = new NavigationPage(new DashboardPage());
            }
            catch (Exception)
            {

                
            }
        }
    }
}