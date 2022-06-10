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
    public partial class Voda : ContentPage
    {
        public Voda()
        {
            InitializeComponent();

        }
        protected override void OnAppearing()
        {
            waterList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            Water value = new Water();
            addPage page = new addPage();
            page.BindingContext = value;
            await Navigation.PushAsync(page);
        }
        

        private async void waterList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Water selected = (Water)e.SelectedItem;
            addPage page = new addPage();
            page.BindingContext = selected;
            await Navigation.PushAsync(page);
        }
    }
}