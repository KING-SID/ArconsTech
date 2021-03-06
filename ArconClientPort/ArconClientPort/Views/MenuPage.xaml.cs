﻿using ArconClientPort.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArconClientPort.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems=null;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Dashboard, Title= "Dashboard"},
                new HomeMenuItem {Id = MenuItemType.About, Title="About"},
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }

        async void LgOutBtn_Clicked(object sender, EventArgs e)
        {
            bool LogOutPrompt = await DisplayAlert("Session Sign Out", "", "Log Out", "Cancel");
            if (LogOutPrompt)
            {
                Application.Current.MainPage = new LoginPage();
            }


        }
    }
}