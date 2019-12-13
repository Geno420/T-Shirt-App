using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TshirtApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PAGE1 : ContentPage
    {
        public PAGE1()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            var REDBAT = new REDBAT();

            BindingContext = REDBAT;
        }
        private async void OnSaveClicked(object sender, EventArgs e)
        {
            var REDBAT = (REDBAT)BindingContext;

            await App.Database.SaveItemAsync(REDBAT);
        }

        private async void onViewOrderClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync( new ORDERVIEW());
        }
    }
}