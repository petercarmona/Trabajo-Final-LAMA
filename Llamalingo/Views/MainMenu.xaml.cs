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
    public partial class MainMenu : ContentPage
    {
        public MainMenu()
        {
            InitializeComponent();
            BindingContext = new VMMainMenu(Navigation);
        }
    }
}