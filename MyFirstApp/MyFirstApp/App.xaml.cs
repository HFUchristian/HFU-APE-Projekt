using MyFirstApp.Services;
using MyFirstApp.Views;
using System;
using Albums.Core;
using MyFirstApp.Models;
using SimpleInjector;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            var dataStore = Services.GetInstance<IDataStore<Item>>();

            dataStore.Initialize();

            MainPage = new AppShell();
        }
        public static Container Services { get; private set; }
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
