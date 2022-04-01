using Microsoft.Extensions.DependencyInjection;
using System;
using ToDoApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDoApp
{
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            LoadDependencies();
        }

        private void LoadDependencies()
        {
            var services = new ServiceCollection();

            services.AddTransient<LoginViewModel>();


            ServiceProvider = services.BuildServiceProvider();

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
