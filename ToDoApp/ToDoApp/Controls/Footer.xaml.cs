﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDoApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Footer : ContentView
    {
        public Footer()
        {
            InitializeComponent();
        }
    }
}