using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            int n = Convert.ToInt32(res.Text);
            int r = n-365;
            string mes = r.ToString();
            int lm = mes.Length;
            string dia = r.ToString();
            int ld = dia.Length;
            if (r > 999) { 
            string md = dia.Substring(2,2);
            string mp = mes.Substring(0,2);
            DisplayAlert("Tu dia de nacimiento es ", mp ,"salir");
            DisplayAlert("Tu mes de nacimiento es ", md, "ver dia");
                }
            else
            {
                string md = dia.Substring(1,2);
            string mp = mes.Substring(0,1);
            DisplayAlert("Tu dia de nacimiento es ", mp ,"salir");
            DisplayAlert("Tu mes de nacimiento es ", md, "ver dia");
            


            }


        }
    }
}
