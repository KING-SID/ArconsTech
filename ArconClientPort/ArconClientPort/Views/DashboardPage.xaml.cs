using ArconClientPort.Models;
using ArconClientPort.ViewModels;
using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArconClientPort.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DashboardPage : ContentPage
	{


        public DashboardPage ()
		{
			InitializeComponent ();
            //NavigationPage.SetHasNavigationBar(this, false);  // Hide nav bar
            // mktvaldatelbl.SetBinding(Label.TextProperty, "Date");
            //mktvaldatelbl.BindingContext = DateSelected.DateRange;
            //ACtivityInPeriodCard.BindingContext = new ActivityInPeriodViewModel();

            //BindingContext = new ActivityInPeriodViewModel();

            //ActivityInPeriodCarouselView.AddLogicalChild(new ItemsPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
           
        }



        private void DatePickerDashboard_DateSelected(object sender, DateChangedEventArgs e)
        {
           // mktvaldatelbl.Text = intdivdatelbl.Text = e.NewDate.ToShortDateString();
            //DateSelected.DateRange = e.NewDate;
            //portvalenddatelbl.Text = "Portfolio value on " + e.NewDate.ToShortDateString();

        }

        private async void NotificationBellBtn_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NotificationsPage());
        }
    }
}