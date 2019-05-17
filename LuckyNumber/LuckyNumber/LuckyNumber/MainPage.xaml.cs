using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LuckyNumber
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private int ReturnRandomNumber()
        {
            return new Random().Next(10);
        }

        private void ClickBTN_Clicked(object sender, EventArgs e)
        {
            ClickBTN.Text = ReturnRandomNumber().ToString(). + " is uw geluksgetal";
        }
    }
}
