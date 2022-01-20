using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APLUS-Guli
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Signup : ContentPage
{
    public Signup()
    {
        InitializeComponent();
    }

    private async void SignIntn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Signup());
    }
}
}