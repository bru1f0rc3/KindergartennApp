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
        public AddKindergartennPage(Kindergartenn kinder = null)
        {
            InitializeComponent();
            if (kinder != null)
            {
                ((ViewModelKinder)BindingContext).Kinder = kinder;
            }
        }



        private void Button_Clicked(object sender, EventArgs e)
        {
            Kindergartenn kinder = ((ViewModelKinder)BindingContext).Kinder;
            kinder.ImageUrl = "https://w1.pngwing.com/pngs/459/985/png-transparent-school-line-art-child-school-drawing-cartoon-boy-male-toddler.png";

            MessagingCenter.Send(this, "abc", kinder);
            ((ViewModelKinder)BindingContext).UpdateKinder(new Kindergartenn()); // обновление объекта Kinder

            Navigation.PopAsync();
        }
    }
}