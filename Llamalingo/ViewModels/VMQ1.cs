using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Llamalingo.Views;
using Xamarin.Forms;

namespace Llamalingo.ViewModels
{
    public class VMQ1:BaseViewModel
    {
        #region VARIABLES

        private string _Name;
        private string _Answer;
        private string _Activity;

        private string[] _Questions;
        private string[] _Answers;

        #endregion

        #region CONSTRUCTOR

        public VMQ1(INavigation navigation)
        {
            Navigation = navigation;

            
        }
        public VMQ1(INavigation navigation, VMQ1 q1)
        {
            Navigation = navigation;
            Name = q1.Name;
            Activity = q1.Activity;

            Questions = new string[]
            {
                "The apple is red",
                "The banana is yellow",
                "The watermelon is green",
                "The cat is brown",
                "The dog is white"
            };

            Answers = new string[]
            {
                "La manzana es roja",
                "El platano es amarillo",
                "La sandía es verde",
                "El gato es marrón",
                "El perro es blanco"
            };
        }

        #endregion

        #region OBJECTS

        public string Name
        {
            get { return _Name; }
            set { SetValue(ref _Name, value); }
        }
        public string Answer
        {
            get { return _Answer; }
            set { SetValue(ref _Answer, value); }
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

        

        public async Task CheckAnswer()
        {
            for (int i = 0; i < Questions.Length; i++)
            {
                if (Activity == Questions[i])
                {
                    if (Answer == Answers[i])
                    {
                        await Application.Current.MainPage.DisplayAlert("Result", $"Excellent!, {Answers[i]} is the correct answer.", "OK");
                    }
                    else
                    {
                        await Application.Current.MainPage.DisplayAlert("Result", $"Wrong answer, the correct sentence is: {Answers[i]}.", "OK");
                    }
                }
            }

            LoadNewExercise();
        }
        private async Task LoadNewExercise()
        {
            // Lógica para cargar un nuevo ejercicio (puedes reiniciar variables, generar nuevas preguntas, etc.)
            Random random = new Random();
            int randomNumber = random.Next(0, Questions.Length);

            Activity = Questions[randomNumber];
            Answer = ""; // Puedes reiniciar la respuesta si es necesario
        }

        #endregion

        #region COMMANDS

        public ICommand AsynchProcessCommand => new Command(async () => await CheckAnswer());

        #endregion
    }
}
