using System;
using System.Collections.Generic;
using System.Text;

namespace KinderrApp
{
    internal class ViewModelKinder
    {
        public Kindergartenn kinder {  get; set; }
        public ViewModelKinder()
        {
            kinder = new Kindergartenn();
        }
    }
}
