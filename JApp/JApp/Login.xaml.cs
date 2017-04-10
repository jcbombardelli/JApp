using System;

using Xamarin.Forms;

namespace JApp
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void nav(Object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
            //Navigation.PushAsync(new NavigationPage(new MainPage())); 
        }
    }
}
