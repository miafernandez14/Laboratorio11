using Laboratorio11.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Laboratorio11
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Sumar());
            };

            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Resta());
            };

            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Multiplicacion());
            };

            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Division());
            };
        }
    }
}
