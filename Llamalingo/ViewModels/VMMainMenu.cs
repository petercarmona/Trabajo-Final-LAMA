using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Llamalingo.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using static Xamarin.Essentials.Permissions;

namespace Llamalingo.ViewModels
{
    public class VMMainMenu:BaseViewModel
    {
        #region VARIABLES

        string _Name;
        string _Activity;

        private string[] _Questions;
        private string[] _Answers;
        #endregion

        #region CONSTRUCTOR

        public VMMainMenu(INavigation navigation)
        {
            Navigation = navigation;
        }

        #endregion

        #region OBJECTS

        public string Name
        {
            get { return _Name; }
            set { SetValue(ref _Name, value); }
        }

        public string Activity
        {
            get { return _Activity; }
            set { SetValue(ref _Activity, value); }
        }

        public string[] Questions
        {
            get { return _Questions; }
            set { SetValue(ref _Questions, value); }
        }
        public string[] Answers
        {
            get { return _Answers; }
            set { SetValue(ref _Answers, value); }
        }
        #endregion

        #region PROCESSES

        public async Task StartQuestions()
        {
            Questions = new string[]
            {
                "The apple is red",
                "The banana is yellow",
                "The watermelon is green"
            };

            Answers = new string[]
            {
                "La Manzana es roja",
                "El platano es Amarillo",
                "La sandía es verde"
            };
            
            SetQuestion();

            var q1 = new VMQ1(Navigation)
            {
                Name = Name,
                Activity = Activity
            };
            await Navigation.PushAsync(new Q1(q1));
        }

        public void SetQuestion()
        {

            Random random = new Random();

            int randomNumber = random.Next(0, 3);

            Activity = Questions[randomNumber];
        }

        #endregion

        #region COMMANDS

        public ICommand AsynchProcessCommand => new Command(async () => await StartQuestions());
        public ICommand SimpleProcessCommand => new Command(SetQuestion);

        #endregion
    }
}
