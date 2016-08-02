using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class SignImage : ContentPage
    {
        public SignImage()
        {
            InitializeComponent();

           
            
        }


        private async void BtnRetakeImage_OnClicked(object sender, EventArgs e)
        {
            //CoverageBill.xaml
            await Navigation.PushAsync(new CaptureImage());
        }
        private async void BtnGoSign_OnClicked(object sender, EventArgs e)
        {
            //CoverageBill.xaml
            await Navigation.PushAsync(new SignImagePreview());
        }
    }
}
