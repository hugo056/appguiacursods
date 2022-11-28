using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace appguiacursods
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public static implicit operator Page(MainPage v)
        {
            throw new NotImplementedException();
        }
    }
}
