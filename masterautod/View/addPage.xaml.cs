using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace masterautod.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class addPage : ContentPage
    {
        public addPage()
        {
            InitializeComponent();
            date.MaximumDate = DateTime.Now.AddDays(5);
            date.MinimumDate = DateTime.Now.AddDays(-5);
        }
        private void save_Clicked(object sender, EventArgs e)
        {
            var water = (Water)BindingContext;
            if (!String.IsNullOrEmpty(water.waterValue))
            {
                App.Database.SaveItem(water);
            }
            this.Navigation.PopAsync();
        }

        private void delete_Clicked(object sender, EventArgs e)
        {
            var table = (Water)BindingContext;
            App.Database.DeleteItem(table.Id);
            this.Navigation.PopAsync();
        }

        private void cancel_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            sliderTxt.Text = String.Format("Выбрано: {0:F1}", e.NewValue);
        }
    }
}