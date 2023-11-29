using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Llamalingo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Llamalingo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Q1 : ContentPage
    {
        public Q1(VMQ1 q1)
        {
            InitializeComponent();
            BindingContext = new VMQ1(Navigation, q1);
        }
    }
}