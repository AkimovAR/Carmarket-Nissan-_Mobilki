using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class CardPage : ContentPage
    {
        public CardPage()
        {
            InitializeComponent();
        }
        private void SaveAuto(object sender, EventArgs e)
        {
            var auto = (CarCard)BindingContext;
            if (!String.IsNullOrEmpty(auto.Name))
            {
                App.Database.SaveItem(auto);
            }
            this.Navigation.PopAsync();
        }
        private void DeleteAuto(object sender, EventArgs e)
        {
            var auto = (CarCard)BindingContext;
            App.Database.DeleteItem(auto.Id);
            this.Navigation.PopAsync();
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}