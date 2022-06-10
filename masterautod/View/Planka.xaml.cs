using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace masterautod.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Planka : ContentPage
    {
        bool running = true;
        public Planka()
        {
            InitializeComponent();
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
        }
        private void startTimer_Clicked(object sender, EventArgs e)
        {
            lbl1.Opacity = 1;
            lbl2.Opacity = 1;
            if (running == true)
            {
                BindingContext = new StopWatchViewModel(running);
                running = false;
            }
            else
            {
                BindingContext = new StopWatchViewModel(running);
                running = true;
            }
        }
        private async void Tap_Tapped(object sender, EventArgs e)
        {
            var wiki = await DisplayAlert("Tähelepanu", "avalda wikipedia?", "Jah", "Ei");
            if (wiki == true)
            {
                await Browser.OpenAsync("https://ru.wikipedia.org/wiki/Бишон-фризе", BrowserLaunchMode.SystemPreferred);
            }
        }
    }
}