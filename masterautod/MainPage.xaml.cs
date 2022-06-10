using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace masterautod
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            foto.Source = ImageSource.FromFile("foto.jpg");
            informasija.ItemsSource = GetMenuList();
            var homepage = typeof(View.sport);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homepage));
            IsPresented = false;
        }

        private List<menuitems> GetMenuList()
        {
            var list = new List<menuitems>();

            list.Add(new menuitems()
            {
                Text = "Главная",
                Detail = "Все о нас",
                ImagePath = "home.jpg",
                TargetPage = typeof(View.sport)
            });
            
            list.Add(new menuitems()
            {
                Text = "Отжимания",
                ImagePath = "otsimanija.jpg",
                TargetPage = typeof(View.Otsimanija)
            });
            
            list.Add(new menuitems()
            {
                Text = "Планка",
                ImagePath = "planka.jpg",
                TargetPage = typeof(View.Planka)
            });
            
            
            
            list.Add(new menuitems()
            {
                Text = "Скручивания",
                ImagePath = "skrus.jpg",
                TargetPage = typeof(View.Skruv)
            });
            
            list.Add(new menuitems()
            {
                Text = "Подъем ног лежа",
                ImagePath = "podemnog.jpg",
                TargetPage = typeof(View.Pdemnog)
            });
            
            list.Add(new menuitems()
            {
                Text = "Приседания",
                ImagePath = "prised.jpg",
                TargetPage = typeof(View.Prisedanie)
            });
            
            list.Add(new menuitems()
            {
                Text = "Вода",
                ImagePath = "voda.png",
                TargetPage = typeof(View.Voda)
            });
         
            
            return list;
        }

        private void informasija_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selected = (menuitems)e.SelectedItem;
            Type selectedpage = selected.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedpage));
            IsPresented = false;
        }
    }
}
