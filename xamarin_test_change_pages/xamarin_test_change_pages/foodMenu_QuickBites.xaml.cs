using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin_test_change_pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class foodMenu_QuickBites : ContentPage
    {
        public foodMenu_QuickBites()
        {
            InitializeComponent();
        }
        private void menuBackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}