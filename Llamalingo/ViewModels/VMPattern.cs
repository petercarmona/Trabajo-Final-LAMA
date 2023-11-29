using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Llamalingo.ViewModels
{
    public class VMPattern : BaseViewModel
    {
        #region VARIABLES

        string _Text;

        #endregion

        #region CONSTRUCTOR

        public VMPattern(INavigation navigation)
        {
            Navigation = navigation;
        }

        #endregion

        #region OBJECTS

        public string Text
        {
            get { return _Text; }
            set { SetValue(ref _Text, value); }
        }

        #endregion

        #region PROCESSES

        public async Task AsynchProcess()
        {

        }

        public void SimpleProcess()
        {

        }

        #endregion

        #region COMMANDS

        public ICommand AsynchProcessCommand => new Command(async () => await AsynchProcess());
        public ICommand SimpleProcessCommand => new Command(SimpleProcess);

        #endregion
    }
}
