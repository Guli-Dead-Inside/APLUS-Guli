﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APLUS-Guli
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Projects : ContentPage
{
    public Projects()
    {
        InitializeComponent();
    }
    private void projectList_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        Navigation.PushAsync(new Project1());
    }

}
}