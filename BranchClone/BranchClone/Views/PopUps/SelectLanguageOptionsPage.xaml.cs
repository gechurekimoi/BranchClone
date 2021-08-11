using BranchClone.ViewModels;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BranchClone.Views.PopUps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectLanguageOptionsPage : PopupPage
    {
        public SelectLanguageOptionsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = DependencyService.Get<ChooseLanguagePageViewModel>();
        }
    }
}