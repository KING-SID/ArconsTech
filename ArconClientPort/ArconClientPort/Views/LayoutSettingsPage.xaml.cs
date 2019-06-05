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
	public partial class LayoutSettingsPage : ContentPage
	{
		public LayoutSettingsPage ()
		{
			InitializeComponent ();
		}

        private void LayoutStPgBackBtnNotificationsPage_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }
    }
}