using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TrainGo.Views;
using Xamarin.Forms;

namespace TrainGo.ViewModels
{
    public class RegistroViewModel : BaseViewModel
    {
        #region VARIABLES

        private bool isPos1Visible;
        private bool isPos2Visible;
        private bool isPos3Visible;
        private bool isPos4Visible;
        private bool isPos5Visible;

        private object parametros;

        private Color _button1BackgroundColor;
        private Color _button2BackgroundColor;
        private Color _button3BackgroundColor;
        private Color _button4BackgroundColor;
        private Color _button5BackgroundColor;

        #endregion VARIABLES

        #region CONSTRUCTOR

        public RegistroViewModel(INavigation navigation)
        {
            Navigation = navigation;
            SetInitialState(); // set initial state for properties
        }

        #endregion CONSTRUCTOR

        #region OBJETOS

        public Color ColorNaranja { get; } = Color.FromHex("#FF3700");
        public Color Azul { get; } = Color.FromHex("#0070C0");

        public object Parametros
        {
            get { return parametros; }

            set
            {
                SetValue(ref parametros, value);
            }
        }

        public Color Button1BackGroundColor
        {
            get { return _button1BackgroundColor; }
            set
            {
                SetProperty(ref _button1BackgroundColor, value);
            }
        }

        public Color Button2BackGroundColor
        {
            get { return _button2BackgroundColor; }
            set
            {
                SetProperty(ref _button2BackgroundColor, value);
            }
        }

        public Color Button3BackGroundColor
        {
            get { return _button3BackgroundColor; }
            set
            {
                SetProperty(ref _button3BackgroundColor, value);
            }
        }

        public Color Button4BackGroundColor
        {
            get { return _button4BackgroundColor; }
            set
            {
                SetProperty(ref _button4BackgroundColor, value);
            }
        }

        public Color Button5BackGroundColor
        {
            get { return _button5BackgroundColor; }
            set
            {
                SetProperty(ref _button5BackgroundColor, value);
            }
        }

        public bool IsPos1Visible
        {
            get { return isPos1Visible; }

            set
            {
                SetValue(ref isPos1Visible, value);
            }
        }

        public bool IsPos2Visible
        {
            get { return isPos2Visible; }

            set
            {
                SetValue(ref isPos2Visible, value);
            }
        }

        public bool IsPos3Visible
        {
            get { return isPos3Visible; }

            set
            {
                SetValue(ref isPos3Visible, value);
            }
        }

        public bool IsPos4Visible
        {
            get { return isPos4Visible; }

            set
            {
                SetValue(ref isPos4Visible, value);
            }
        }

        public bool IsPos5Visible
        {
            get { return isPos5Visible; }

            set
            {
                SetValue(ref isPos5Visible, value);
            }
        }

        #endregion OBJETOS

        #region PROCESOS

        public async Task RegresarPage()
        {
            await Navigation.PopToRootAsync();
        }

        public async Task EscanearRollo(object sender)
        {
            var botonUsado = sender as Button;

            string idBoton = botonUsado.AutomationId.ToString();

            switch (idBoton)
            {
                case "1":
                    Button1BackGroundColor = Azul;
                    IsPos1Visible = true;
                    break;

                case "2":
                    Button2BackGroundColor = Azul;
                    IsPos2Visible = true;
                    break;

                case "3":
                    Button3BackGroundColor = Azul;
                    IsPos3Visible = true;
                    break;

                case "4":
                    Button4BackGroundColor = Azul;
                    IsPos4Visible = true;
                    break;

                case "5":
                    Button5BackGroundColor = Azul;
                    IsPos5Visible = true;
                    break;
            }
        }

        public void SetInitialState()
        {
            IsPos1Visible = false;
            IsPos2Visible = false;
            IsPos3Visible = false;
            IsPos4Visible = false;
            IsPos5Visible = false;

            Button1BackGroundColor = ColorNaranja;
            Button2BackGroundColor = ColorNaranja;
            Button3BackGroundColor = ColorNaranja;
            Button4BackGroundColor = ColorNaranja;
            Button5BackGroundColor = ColorNaranja;
        }

        #endregion PROCESOS

        #region COMANDOS

        //public ICommand EscanearRolloCommand => new Command(async () => await EscanearRollo());

        public ICommand EscanearRolloCommand => new Command<object>(async (param) => await EscanearRollo(param));
        public ICommand RegresarPageCommand => new Command(async () => await RegresarPage());
        //public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);

        #endregion COMANDOS
    }
}