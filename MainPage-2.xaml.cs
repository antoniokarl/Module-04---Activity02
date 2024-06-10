using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module04Activity02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Btn_GoTo_Page(object sender, EventArgs e)
        {
            if (sender == Btn_GoTo_TabbedPage)
            {
                await Navigation.PushAsync(new TabbedPage1());
            }

            else if (sender == Btn_GoTo_CarouselPage)
            {
                await Navigation.PushAsync(new CarouselPage1());
            }
        }
    }
}
