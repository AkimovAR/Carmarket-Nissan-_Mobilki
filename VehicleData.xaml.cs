﻿using Newtonsoft.Json;
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
    public class RootProjects2
    {
        public List<CarCard> CarCards { get; set; }
    }
    public partial class VehicleData : ContentPage
    {
        //public IList<CarCard> CarCards { get; set; }
        public List<CarCard> jsonContents2 { get; set; }
        public VehicleData()
        {
            InitializeComponent();

            var assembly2 = IntrospectionExtensions.GetTypeInfo(typeof(VehicleData)).Assembly;
            var stream2 = assembly2.GetManifestResourceStream("App1.VehicleData.json");

            using (StreamReader sr = new StreamReader(stream2)/*var reader = new System.IO.StreamReader(stream)*/)
            {

                var content2 = sr.ReadToEnd();
                var data2 = JsonConvert.DeserializeObject<RootProjects2>(content2);
                jsonContents2 = data2.CarCards;
            }
            MyListView2.ItemsSource = jsonContents2;
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

        //protected override void OnAppearing() /*Метод заполнения коллекции*/
        //{
        //    CarCards = new List<CarCard>(); /*Ссылка на экземпляр коллекции*/

        //    CarCards.Add(new CarCard() /*заполнение методом Add()*/
        //    {
        //        Transmission = "Вариатор",
        //        God = "2007",
        //        Rul = "Левый",
        //        Users = "3 или более",
        //        PTS = "Оригинал",
        //        Tam = "Растаможен"
        //    });

        //    BindingContext = this; /*Ссылка на текущий экземпляр класса*/

        //    base.OnAppearing();
        //}

    }
}