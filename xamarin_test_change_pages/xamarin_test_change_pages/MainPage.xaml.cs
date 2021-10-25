using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xamarin_test_change_pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ImageSource myImageSource = ImageSource.FromFile("/Assets/cafe_logo.png");
        }

        private void menuButton_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch(button.Text)
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

        private void foodMenuButton_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Text)
            {
                case "Espresso":
                    Navigation.PushAsync(new foodMenu_Espresso()); //move to Menu page
                    break;
                case "Hot Drinks":
                    Navigation.PushAsync(new foodMenu_HotDrinks()); //move to About page
                    break;
                case "Cold Drinks":
                    Navigation.PushAsync(new foodMenu_ColdDrinks()); //move to Map page
                    break;
                case "Quick Bites":
                    Navigation.PushAsync(new foodMenu_QuickBites()); //move to Map page
                    break;
            }
        }
    }
}
