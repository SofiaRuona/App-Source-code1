using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class CoverageStart : ContentPage
    {
        public CoverageStart()
        {
            InitializeComponent();

           
            
        }


        private async void BtnGo_OnClicked(object sender, EventArgs e)
        {
            //CoverageBill.xaml
            await Navigation.PushAsync(new CoverageBill());
        }
    }
}
