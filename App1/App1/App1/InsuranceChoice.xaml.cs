using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class InsuranceChoice : ContentPage
    {
        public InsuranceChoice()
        {
            InitializeComponent();

           
            
        }

       

        private async void BtnVInsurance_OnClicked(object sender, EventArgs e)
        {
            //AvailableProducts.xaml
            await Navigation.PushAsync(new AvailableProducts());
        }

        private async void BtnMInsurance_OnClicked(object sender, EventArgs e)
        {
            //CoverageStart.xaml
            await Navigation.PushAsync(new CoverageStart());
        }
    }
}
