using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class VehicleSearch : ContentPage
    {
        public VehicleSearch()
        {
            InitializeComponent();

            LVCityList.Items.Add("New York");
            LVCityList.Items.Add("Hong Kong");
            LVCityList.Items.Add("Shingahi");
            LVCityList.Items.Add("Tokio");
            LVCityList.Items.Add("London");


            
        }

        private void BtnSearhVehicle_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Search Results", "Company\t\t\tHONDA\nModel\t\t\tCIVIC\nYear\t\t\t2014", "OK");
        }

        private async void BtnGo_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InsuranceChoice());
        }
    }
}
