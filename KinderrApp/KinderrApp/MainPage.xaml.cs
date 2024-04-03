using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KinderrApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddKindergartennPage());
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            TappedEventArgs tappedEventArgs = (TappedEventArgs)e;
            Kindergartenn kinder = ((KindergartennViewModel)BindingContext).ItemList.
                Where(prod => prod.IdPeople == (int)tappedEventArgs.Parameter).FirstOrDefault();

            Navigation.PushAsync(new AddKindergartennPage(kinder));
        }
    }
}
