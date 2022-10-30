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

    public class RootProjects
    {
        public List<CarCard> CarCards { get; set; }
    }

    public partial class MainPage : ContentPage
    {
        /*Коллекция типа IList для хранения объектов CarCard*/
        //public IList<CarCard> CarCards { get; set; }

        //public ObservableCollection<CarCard> myrootobgect;
        public List<CarCard> jsonContents { get; set; }
        public MainPage()
        {
            InitializeComponent();

            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly;
            var stream = assembly.GetManifestResourceStream("App1.Main1.json");

            using (StreamReader sr = new StreamReader(stream))
            {
                var content = sr.ReadToEnd();
                var data = JsonConvert.DeserializeObject<RootProjects>(content);
                jsonContents = data.CarCards;
            }
            MyListView.ItemsSource = jsonContents;
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

        //protected override void OnAppearing() /*Метод заполнения коллекции*/
        //{
        //    CarCards = new List<CarCard>
        //    {
        //        new CarCard() /*заполнение методом Add()*/
        //        {
        //            Name = "Nissan Qashqai I, 2007",
        //            Price = "от 549 000 Р",
        //            Probeg = "173 919 км",
        //            Toplivo = "Бензин",
        //            Transmission = "Вариатор",
        //            Color = "Чёрный",
        //            Privod = "Передний",
        //            Kuzov = "5 дв.",
        //            Image = "https://carmetrika.ru/images/items/a68/a192b3a2a/b177b40ceb9c.jpg",
        //        },

        //        new CarCard()
        //        {
        //            Name = "Nissan Juke I, 2012",
        //            Price = "от 890 000 Р",
        //            Probeg = "197 332 км",
        //            Toplivo = "Бензин",
        //            Transmission = "Вариатор",
        //            Color = "Красный",
        //            Privod = "Передний",
        //            Kuzov = "5 дв.",
        //            Image = "https://avatars.mds.yandex.net/get-autoru-vos/2171556/f187db5581637260968758d565b9aa38/1200x900"
        //        },

        //        new CarCard()
        //        {
        //            Name = "Nissan Almera III, 2017",
        //            Price = "от 620 000 Р",
        //            Probeg = "101 948 км",
        //            Toplivo = "Бензин",
        //            Transmission = "Механика",
        //            Color = "Чёрный",
        //            Privod = "Передний",
        //            Kuzov = "Седан",
        //            Image = "https://avatars.mds.yandex.net/get-autoru-vos/1870907/e25825505fd93d8cd4c732fa72b02bcd/1200x900"
        //        },

        //        new CarCard()
        //        {
        //            Name = "Nissan Almera III, 2017",
        //            Price = "от 620 001 Р",
        //            Probeg = "101 948 км",
        //            Toplivo = "Бензин",
        //            Transmission = "Механика",
        //            Color = "Чёрный",
        //            Privod = "Передний",
        //            Kuzov = "Седан",
        //            Image = "https://avatars.mds.yandex.net/get-autoru-vos/2172360/49c64715db9eb7bd206c5c4f18b5641f/1200x900"
        //        }
        //    }; /*Ссылка на экземпляр коллекции*/

        //    BindingContext = this; /*Ссылка на текущий экземпляр класса*/

        //    base.OnAppearing();
        //}
    }
}
