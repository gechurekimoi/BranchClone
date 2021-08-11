using BranchClone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BranchClone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardPage : ContentPage
    {
        private List<Loan> loanAmounts;
        public List<Loan> LoanAmounts
        {
            get { return loanAmounts; }
            set { loanAmounts = value; OnPropertyChanged(); }
        }

        public ICommand SelectLoanAmountCommand { get; set; }

        public DashboardPage()
        {
            InitializeComponent();


            SelectLoanAmountCommand = new Command<string>(x => SelectLoanAmount(x));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            AddLoanAmounts();

            BindingContext = this;
        }

        void AddLoanAmounts()
        {
            try
            {
                LoanAmounts = new List<Loan>()
                {
                    new Loan(){  Amount = "10,000", IsSelected=true },
                    new Loan(){  Amount = "7,000", IsSelected=false },
                    new Loan(){  Amount = "5,000", IsSelected=false },
                    new Loan(){  Amount = "3,000", IsSelected=false },
                    new Loan(){  Amount = "2,000", IsSelected=false },
                    new Loan(){  Amount = "1,000", IsSelected=false },
                    new Loan(){  Amount = "500", IsSelected=false }

                };
            }
            catch (Exception ex)
            {

            }
        }

        public void SelectLoanAmount(string Amount)
        {
            try
            {
                LoanAmounts.Select(p => { p.IsSelected = false; return p; }).ToList();

                LoanAmounts.Where(p=>p.Amount == Amount).Select(p => { p.IsSelected = true; return p; }).ToList();

                var l = LoanAmounts;

                LoanAmounts = null;

                LoanAmounts = l;


                int elementPosition = LoanAmounts.IndexOf( LoanAmounts.Where(p => p.Amount == Amount).FirstOrDefault());
                collectionView.ScrollTo(elementPosition);
            }
            catch (Exception ex)
            {

            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                await App.Current.MainPage.Navigation.PushAsync(new LoanOfferConfirmPage());
            }
            catch (Exception ex)
            {

            }
        }
    }
}