using ArconClientPort.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArconClientPort.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Split;

            //MenuPages.Add((int)MenuItemType.Profile, (NavigationPage)Detail);
            

        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    /*case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;*/

                    case (int)MenuItemType.Dashboard:
                        MenuPages.Add (id, new NavigationPage(new DashboardPage()));
                        break;

                    case (int)MenuItemType.Profile:
                        MenuPages.Add(id, new NavigationPage(new ProfilePage()));
                        break;

                    case (int)MenuItemType.ChangePassword:
                        MenuPages.Add(id, new NavigationPage(new ChangePasswordPage()));
                        break;

                    case (int)MenuItemType.LayoutSettings:
                        MenuPages.Add(id, new NavigationPage(new LayoutSettingsPage()));
                        break;

                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}