using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(num.Text);
            int r = (n / 5 - 8) / 2;
            DisplayAlert("El Numero en el que estas pensando es: ", r.ToString(), "Salir");

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}
