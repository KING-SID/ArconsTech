using System;
using System.Collections.Generic;
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
            NavigationPage.SetHasNavigationBar(this, false);  // Hide nav bar
        }

        private void DatePickerDashboard_DateSelected(object sender, DateChangedEventArgs e)
        {
            
        }

        async void NotificationBellBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NotificationsPage());
        }

        //private async void SummaryWidgetPortfolio_Clicked(object sender, EventArgs e)
        //{
        //   await Navigation.PushAsync(new PortfolioPage());
        //}

    }
}