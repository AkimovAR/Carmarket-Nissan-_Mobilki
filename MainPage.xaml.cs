using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{


    public partial class MainPage : ContentPage
    {
        /*Коллекция типа IList для хранения объектов CarCard*/
        public IList<CarCard> CarCards { get; set; }

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing() /*Метод заполнения коллекции*/
        {
            CarCards = new List<CarCard>(); /*Ссылка на экземпляр коллекции*/

            CarCards.Add(new CarCard() /*заполнение методом Add()*/
            {
                Name = "Nissan Qashqai I, 2007",
                Price = "от 549 000 Р",
                Probeg = "173 919 км",
                Toplivo = "Бензин",
                KPPType = "Вариатор",
                Color = "Чёрный",
                Privod = "Передний",
                Kuzov = "5 дв.",
                Image = "https://carmetrika.ru/images/items/a68/a192b3a2a/b177b40ceb9c.jpg"
            });

            CarCards.Add(new CarCard()
            {
                Name = "Nissan Juke I, 2012",
                Price = "от 890 000 Р",
                Probeg = "197 332 км",
                Toplivo = "Бензин",
                KPPType = "Вариатор",
                Color = "Красный",
                Privod = "Передний",
                Kuzov = "5 дв.",
                Image = "https://avatars.mds.yandex.net/get-autoru-vos/2171556/f187db5581637260968758d565b9aa38/1200x900"
            });

            CarCards.Add(new CarCard()
            {
                Name = "Nissan Almera III, 2017",
                Price = "от 620 000 Р",
                Probeg = "101 948 км",
                Toplivo = "Бензин",
                KPPType = "Механика",
                Color = "Чёрный",
                Privod = "Передний",
                Kuzov = "Седан",
                Image = "https://avatars.mds.yandex.net/get-autoru-vos/1870907/e25825505fd93d8cd4c732fa72b02bcd/1200x900"
            });

            CarCards.Add(new CarCard()
            {
                Name = "Nissan Almera III, 2017",
                Price = "от 620 001 Р",
                Probeg = "101 948 км",
                Toplivo = "Бензин",
                KPPType = "Механика",
                Color = "Чёрный",
                Privod = "Передний",
                Kuzov = "Седан",
                Image = "https://avatars.mds.yandex.net/get-autoru-vos/2172360/49c64715db9eb7bd206c5c4f18b5641f/1200x900"
            });

            BindingContext = this; /*Ссылка на текущий экземпляр класса*/

            base.OnAppearing();
        }
    }
}
