using dblist.Data;
using dblist.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace dblist
{
    public partial class App : Application
    {
        static JokeItemDatabase database;

        public App()
        {
            InitializeComponent();

            var nav = new NavigationPage(new JokeListPage());
            nav.BarBackgroundColor = (Color)App.Current.Resources["primaryGreen"];
            nav.BarTextColor = Color.White;

            MainPage = nav;
        }

        public static JokeItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new JokeItemDatabase();
                }
                return database;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
