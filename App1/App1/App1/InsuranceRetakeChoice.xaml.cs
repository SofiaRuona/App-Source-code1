using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class InsuranceRetakeChoice : ContentPage
    {
        public InsuranceRetakeChoice()
        {
            InitializeComponent();

           
            
        }


        private async void BtnYes_OnClicked(object sender, EventArgs e)
        {
            //CoverageBill.xaml
            await Navigation.PushAsync(new AvailableProducts());
        }
        private async void BtnNo_OnClicked(object sender, EventArgs e)
        {
            //CoverageBill.xaml
            await Navigation.PushAsync(new GetPayment());
        }
    }
}
