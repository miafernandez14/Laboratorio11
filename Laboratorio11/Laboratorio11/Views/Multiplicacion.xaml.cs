﻿using Laboratorio11.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio11.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Multiplicacion : ContentPage
    {
        public Multiplicacion()
        {
            InitializeComponent();
            this.BindingContext = new ViewModelOperaciones();
        }
    }
}