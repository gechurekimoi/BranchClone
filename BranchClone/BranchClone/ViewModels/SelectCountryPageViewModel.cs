using BranchClone.Views.PopUps;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BranchClone.ViewModels
{
    public class SelectCountryPageViewModel : BaseViewModel
    {

        public ICommand GoBackCommand { get; set; }

        public ICommand ShowSelectCountryPageCommand { get; set; }

        public SelectCountryPageViewModel()
        {
            GoBackCommand = new Command(async () => await GoBack());
            ShowSelectCountryPageCommand = new Command(async () => await ShowSelectCountryPage());
        }

        public async Task GoBack()
        {
            try
            {
                await App.Current.MainPage.Navigation.PopAsync();
            }
            catch (Exception ex)
            {

                
            }
        }


        public async Task ShowSelectCountryPage()
        {
            try
            {
                await App.Current.MainPage.Navigation.PushPopupAsync(new SelectCountryOptionsPage());
            }
            catch (Exception ex)
            {

                
            }
        }

    }
}
