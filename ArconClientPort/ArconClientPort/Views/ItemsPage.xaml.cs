using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ArconClientPort.Models;
using ArconClientPort.Views;
using ArconClientPort.ViewModels;

namespace ArconClientPort.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : TabbedPage
    {
        ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();
            //DatePickerDashboard.BindingContext = DateSelected.DateRange;
            //DatePickerDashboard.SetBinding(DatePicker.DateProperty, "Date");
            NavigationPage.SetHasNavigationBar(this, false);
           
        }

       

        

        protected override void OnAppearing()
        {
            base.OnAppearing();
           // DatePickerDashboard.Date = DateSelected.DateRange;

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }

         async void NotificationBellBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NotificationsPage());
        }

        public async void DatePickerDashboard_DateSelected(object sender, DateChangedEventArgs e)
        {
            DateSelected.DateRange = e.NewDate;
            await Task.Delay(300);
            Application.Current.MainPage = new MainPage();
        }
    }
}