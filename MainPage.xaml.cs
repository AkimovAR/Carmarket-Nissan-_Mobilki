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

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            MyListView.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            CarCard selectedCarCard = (CarCard)e.SelectedItem;
            CardPage cardpage = new CardPage();
            cardpage.BindingContext = selectedCarCard;
            await Navigation.PushAsync(cardpage);
        }
        private async void CreateAuto(object sender, EventArgs e)
        {
            CarCard carcard = new CarCard();
            CardPage cardpage = new CardPage();
            cardpage.BindingContext = carcard;
            await Navigation.PushAsync(cardpage);
        }
        private async void Button1_Click(object sender, EventArgs e)
        {
            Favourites f = new Favourites();

            /*Избавляемся от кнопки перехода назад, т.к. она нам не нужна*/
            NavigationPage.SetHasBackButton(f, false);

            await Navigation.PushAsync(f);
        }

        private async void Button2_Click(object sender, EventArgs e)
        {
            VehicleData vd = new VehicleData();

            /*Избавляемся от кнопки перехода назад, т.к. она нам не нужна*/
            NavigationPage.SetHasBackButton(vd, false);

            await Navigation.PushAsync(vd);
        }
    }
}
