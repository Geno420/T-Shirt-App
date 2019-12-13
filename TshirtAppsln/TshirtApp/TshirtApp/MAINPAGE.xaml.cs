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
    public partial class MAINPAGE : ContentPage
    {
        public MAINPAGE()
        {
            InitializeComponent();
        }

        private void nextpage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PAGE1());
        }
    }
}