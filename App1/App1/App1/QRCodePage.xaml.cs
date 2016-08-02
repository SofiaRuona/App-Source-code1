using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class QRCodePage : ContentPage
    {
        public QRCodePage()
        {
            InitializeComponent();
        }


        private void BtnGo_OnClicked(object sender, EventArgs e)
        {
            //
        }

        private async void BtnScanQrCode_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QRCodeProgress());
        }
    }
}
