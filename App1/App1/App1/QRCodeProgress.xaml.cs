using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class QRCodeProgress : ContentPage
    {
        public QRCodeProgress()
        {
            InitializeComponent();

        }

        private async void BtnGo_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QRCodeSuccess());
        }
    }
}
