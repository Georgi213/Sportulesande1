using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace masterautod.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(false)]
    public partial class Otsimanija : ContentPage
    {
        bool running = true;
        public Otsimanija()
        {
            InitializeComponent();
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
    }
}