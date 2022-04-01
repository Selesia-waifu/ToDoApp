using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoApp.Models;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace ToDoApp.ViewModels
{
    internal class LoginViewModel : ViewModelBase
    {

        public LoginViewModel()
        {
            SaludarCommand = new Command(Saludar);
            SaludarAsyncCommand = new AsyncCommand<User>((x)=> SaludarAsincronamente(x));
        }

        private string _NickName;
        public string NickName
        {
            get { return _NickName; }
            set
            {
                _NickName = value;
                NotifyPropertyChanged();
            }
        }

        private string _Password;
        public string Password
        {
            get { return _Password; }
            set
            {
                _Password = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Usar Cunado se van a realizar tareas sincronas
        /// </summary>
        public ICommand SaludarCommand { get; set; }

        public IAsyncCommand<User> SaludarAsyncCommand { get; set; }


        private async Task SaludarAsincronamente(User value)
        {

            Thread.Sleep(3000);
            await App.Current.MainPage.DisplayAlert("hey",$"Hola: {Password}","Cancelar");
        }

        private void Saludar()
        {
            App.Current.MainPage.DisplayAlert("hey", $"Hola: {NickName}", "Ok");
        }

    }
}
