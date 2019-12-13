using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TshirtApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ORDERVIEW : ContentPage
    {
        public List<REDBAT> TShirtOrders { get; set; }
        public ORDERVIEW()
        {
            InitializeComponent();
        }

        private async void OnConfirmOrderClicked(object sender, EventArgs e)
        {


            var client = new HttpClient(new HttpClientHandler());
            var url = "https://localhost:5001/tshirt";
            var REDBAT = new REDBAT();

            var json = JsonConvert.SerializeObject(REDBAT);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            try
            {
                var response = await client.PostAsync(url, content);
                await DisplayAlert("Response Message", response.ReasonPhrase, "ok");
            }
            catch (Exception)
            {
                await DisplayAlert("Exceptions", "Try Again", "ok");
            }
        }
    }
}