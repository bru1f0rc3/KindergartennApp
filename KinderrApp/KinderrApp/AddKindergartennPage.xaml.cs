using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KinderrApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddKindergartennPage : ContentPage
    {
        public AddKindergartennPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Kindergartenn kinder = ((ViewModelKinder)BindingContext).kinder;
            kinder.ImageUrl = "cats.png";
            MessagingCenter.Send(this, "abc", kinder);
            Navigation.PopAsync();
        }
    }
}