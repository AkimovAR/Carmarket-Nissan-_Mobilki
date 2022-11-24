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

    /*public class RootProjects
    {
        public List<CarCard> CarCards { get; set; }
    }*/

    public partial class MainPage : ContentPage
    {
        //public List<CarCard> jsonContents { get; set; }
        public MainPage()
        {
            InitializeComponent();

            /*var assembly = IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly;
            var stream = assembly.GetManifestResourceStream("App1.Main1.json");

            using (StreamReader sr = new StreamReader(stream))
            {
                var content = sr.ReadToEnd();
                var data = JsonConvert.DeserializeObject<RootProjects>(content);
                jsonContents = data.CarCards;
            }
            MyListView.ItemsSource = jsonContents;*/
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
