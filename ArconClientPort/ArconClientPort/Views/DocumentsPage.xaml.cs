﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArconClientPort.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DocumentsPage : ContentPage
	{
		public DocumentsPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);  // Hide nav bar
        }
	}
}