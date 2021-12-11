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
    public partial class ItemsPage : ContentPage
    {
        public ItemsPage()
        {
            InitializeComponent();
            Todos lst = new Todos();
            lstView.ItemsSource = lst.List;
        }

        private void lstView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new ItemPage((ToDo)e.Item));

        }
    }
}