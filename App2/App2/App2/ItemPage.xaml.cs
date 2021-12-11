using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemPage : ContentPage
    {
        public ItemPage()
        {
            InitializeComponent();
        }

        public ItemPage(ToDo item)
        {
            InitializeComponent();
            BindingContext = item;
        }

        private void btnSave_Clicked(object sender, EventArgs e)
        {

        }
    }
}