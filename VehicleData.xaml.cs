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
    public partial class VehicleData : ContentPage
    {
        public VehicleData()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            MyListView2.ItemsSource = App.Database.GetItems1();
            base.OnAppearing();
        }

        private async void OnItemSelected1(object sender, SelectedItemChangedEventArgs e)
        {
            CarData selectedCarCard = (CarData)e.SelectedItem;
            CardPage1 cardpage = new CardPage1();
            cardpage.BindingContext = selectedCarCard;
            await Navigation.PushAsync(cardpage);
        }
        private async void CreateAuto1(object sender, EventArgs e)
        {
            CarData carcard = new CarData();
            CardPage1 cardpage = new CardPage1();
            cardpage.BindingContext = carcard;
            await Navigation.PushAsync(cardpage);
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            Favourites f = new Favourites();

            /*Избавляемся от кнопки перехода назад, т.к. она нам не нужна*/
            NavigationPage.SetHasBackButton(f, false);

            await Navigation.PushAsync(f); /*Возвращаемся на страницу Избранное*/
        }

        private async void Button2_Click(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync(); /*Возврат на главную страницу*/
        }
    }
}