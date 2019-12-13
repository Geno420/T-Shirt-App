using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
namespace TshirtApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MAINPAGE());
        }

        static DATABASEs database;
        public static DATABASEs Database
        {
            get
            {
                if (database == null)
                {
                    database = new DATABASEs(
                      Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DATABASEsSQLite.db3"));
                }
                return database;
            }
        }
        public int ResumeAtPersonName { get; set; }




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
