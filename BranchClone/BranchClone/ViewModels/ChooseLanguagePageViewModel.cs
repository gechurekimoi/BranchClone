using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Extensions;
using BranchClone.Views.PopUps;

namespace BranchClone.ViewModels
{
    public class ChooseLanguagePageViewModel : BaseViewModel
    {

        public ICommand ShowLanguagePopupPageCommand { get; set; }

      

        public ChooseLanguagePageViewModel()
        {
            ShowLanguagePopupPageCommand = new Command(async () => await ShowLanguagePopupPage());

          
        }


        public async Task ShowLanguagePopupPage()
        {
            try
            {
               await App.Current.MainPage.Navigation.PushPopupAsync(new SelectLanguageOptionsPage());
            }
            catch (Exception ex)
            {

            }
        } 
        
        
       


    }
}
