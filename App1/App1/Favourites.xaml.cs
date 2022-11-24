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
    public class RootProjects1
    {
        public List<CarCard> CarCards { get; set; }
    }
    public partial class Favourites : ContentPage
    {
        public List<CarCard> jsonContents1 { get; set; }
        public Favourites()
        {
            InitializeComponent();

            var assembly1 = IntrospectionExtensions.GetTypeInfo(typeof(Favourites)).Assembly;
            var stream1 = assembly1.GetManifestResourceStream("App1.Favourite.json");

            using (StreamReader sr = new StreamReader(stream1))
            {

                var content1 = sr.ReadToEnd();
                var data1 = JsonConvert.DeserializeObject<RootProjects1>(content1);
                jsonContents1 = data1.CarCards;
            }
            MyListView1.ItemsSource = jsonContents1;
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