using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin_test_change_pages
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class aboutPage : ContentPage
    {
        public aboutPage()
        {
            InitializeComponent();
        }

        private void menuButton_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Text)
            {
                case "Menu":
                    Navigation.PushAsync(new MainPage()); //move to Menu page
                    break;
                case "About":
                    Navigation.PushAsync(new aboutPage()); //move to About page
                    break;
                case "Map":
                    Navigation.PushAsync(new mapPage()); //move to Map page
                    break;
            }
        }
    }
}