using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class Favourites : ContentPage
    {
        public Favourites()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            MyListView1.ItemsSource = App.Database.GetItems1();
            base.OnAppearing();
        }
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            FavouritesCarCard selectedFavouritesCarCard = (FavouritesCarCard)e.SelectedItem;
            CardPage cardpage = new CardPage();
            cardpage.BindingContext = selectedFavouritesCarCard;
            await Navigation.PushAsync(cardpage);
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            VehicleData vd = new VehicleData();

            /*Избавляемся от кнопки перехода назад, т.к. она нам не нужна*/
            NavigationPage.SetHasBackButton(vd, false);

            await Navigation.PushAsync(vd);
        }

        private async void Button2_Click(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync(); /*Возврат на главную страницу*/
        }
    }
}