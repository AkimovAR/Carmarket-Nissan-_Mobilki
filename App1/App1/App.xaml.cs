using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace App1
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "NissanMotors.db";
        public static CarCardModel database;
        public static CarCardModel Database
        {
            get
            {
                if (database == null)
                {
                    database = new CarCardModel(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new App1.MainPage())
            {
                BarBackgroundColor = Color.FromHex("b0aeae") /*Цвет панельки сверху*/
            };
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
