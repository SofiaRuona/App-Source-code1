using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class QRCodeSuccess : ContentPage
    {
        public QRCodeSuccess()
        {
            InitializeComponent();

        }

        private async void BtnGo_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VehicleSearch());
        }
    }
}
