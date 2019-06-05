using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ArconClientPort.Services;
using ArconClientPort.Views;
using ArconClientPort.ViewModels;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ArconClientPort
{
    public partial class App : Application
    {
        //TODO: Replace with *.azurewebsites.net url after deploying backend to Azure
        public static string AzureBackendUrl = "http://localhost:5000";
        public static bool UseMockDataStore = true;

        public App()
        {
            InitializeComponent();

            DateSelected.DateRange = DateTime.Now;
       
            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<AzureDataStore>();

            DateSelected.datechosen = DateTime.Now;
            MainPage =  new LoginPage();
            //MainPage = new NotificationsPage();
            //MainPage = new DashboardPage();
            //Navigation{ new LoginPage() };
            //DateSelected.DateRange = DateTime.Now;
            //MainPage = new NavigationPage (new TestINotifyPage());
            
         
          
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
