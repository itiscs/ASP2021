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

        private void btn1_Clicked(object sender, EventArgs e)
        {
            lbl1.Text = $"Hello {txt1.Text}";
        }
    }
}
