using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace KinderrApp
{
    public class KindergartennViewModel
    {
        public ObservableCollection<Kindergartenn> ItemList { get; set; }

        public KindergartennViewModel() 
        {
            ItemList = new ObservableCollection<Kindergartenn>
            {
                new Kindergartenn { IdPeople = 1, Surname = "123424", Year = 2004, Mouth = 12, ImageUrl = "cats.png" },
                new Kindergartenn { IdPeople = 2, Surname = "2515", Year = 2008, Mouth = 06, ImageUrl = "cats.png" },
                new Kindergartenn { IdPeople = 3, Surname = "51251", Year = 2014, Mouth = 01, ImageUrl = "cats.png" },
                new Kindergartenn { IdPeople = 4, Surname = "615612", Year = 1995, Mouth = 02, ImageUrl = "cats.png" }
            };

            MessagingCenter.Subscribe<AddKindergartennPage, Kindergartenn>(this, "abc", (page, kinder) =>
            {
                if (kinder.IdPeople == 0)
                {
                    kinder.IdPeople = ItemList.Count + 1;
                    ItemList.Add(kinder);
                }
            });
        } 
    }
}
