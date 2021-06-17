using CoreApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppMovil
{
    public partial class MainPage : ContentPage
    {
        CoreApp.Main main = new CoreApp.Main();
        public MainPage()
        {
            InitializeComponent();
            LoadInfo();
        }

        public async void LoadInfo() 
        {
            var slowTask = Task<CoreApp.Models.Tercero>.Factory.StartNew(() => main.LoadTercero());
            await slowTask;
            if (slowTask.IsCompleted)
            {
                this.BindingContext = slowTask.Result;
            }            
        }




    }
}
