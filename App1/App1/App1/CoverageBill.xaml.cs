using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class CoverageBill : ContentPage
    {
        public CoverageBill()
        {
            InitializeComponent();

           
            
        }


        private async void BtnGo_OnClicked(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            await Navigation.PushAsync(new GetPayment());
        }
    }
}
