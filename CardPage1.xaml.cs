using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class CardPage1 : ContentPage
    {
        public CardPage1()
        {
            InitializeComponent();
        }
        private void SaveAuto1(object sender, EventArgs e)
        {
            var auto = (CarData)BindingContext;
            if (!String.IsNullOrEmpty(auto.Transmission))
            {
                App.Database.SaveItem1(auto);
            }
            this.Navigation.PopAsync();
        }
        private void DeleteAuto1(object sender, EventArgs e)
        {
            var auto = (CarData)BindingContext;
            App.Database.DeleteItem1(auto.Id);
            this.Navigation.PopAsync();
        }
        private void Cancel1(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}