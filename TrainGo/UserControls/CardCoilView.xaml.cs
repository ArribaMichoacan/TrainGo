using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TrainGo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainGo.UserControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardCoilView : ContentView
    {
        #region VARIABLES

        public static readonly BindableProperty CardPosicionProperty = BindableProperty.Create(
           nameof(CardPosicion),         //nombre de la propiedad
           typeof(string),         //tipo
           typeof(CardCoilView),   //tipo del padre
           string.Empty);          //valor por default

        public static readonly BindableProperty CardIdProperty = BindableProperty.Create(
            nameof(CardId),         //nombre de la propiedad
            typeof(string),         //tipo
            typeof(CardCoilView),   //tipo del padre
            string.Empty);          //valor por default

        public static readonly BindableProperty CardMaterialProperty = BindableProperty.Create(
           nameof(CardMaterial),         //nombre de la propiedad
           typeof(string),         //tipo
           typeof(CardCoilView),   //tipo del padre
           string.Empty);          //valor por default

        public static readonly BindableProperty CardPesoProperty = BindableProperty.Create(
           nameof(CardPeso),        //nombre de la propiedad
           typeof(string),         //tipo
           typeof(CardCoilView),   //tipo del padre
           string.Empty);          //valor por default


        public static readonly BindableProperty CardEscaneadoProperty = BindableProperty.Create(
           nameof(CardEscaneado),        //nombre de la propiedad
           typeof(bool),         //tipo
           typeof(CardCoilView),   //tipo del padre
           false);          //valor por default

        #endregion VARIABLES

        #region Propiedades
        public string CardPosicion
        {
            get { return (string)GetValue(CardPosicionProperty); }

            set { SetValue(CardPosicionProperty, value); }
        }

        public string CardId
        {
            get { return (string)GetValue(CardIdProperty); }

            set { SetValue(CardIdProperty, value); }
        }

        public string CardMaterial
        {
            get { return (string)GetValue(CardMaterialProperty); }

            set { SetValue(CardMaterialProperty, value); }
        }

        public string CardPeso
        {
            get { return (string)GetValue(CardPesoProperty); }

            set { SetValue(CardPesoProperty, value); }
        }

        public bool CardEscaneado
        {
            get { return (bool)GetValue(CardEscaneadoProperty); }

            set { SetValue(CardEscaneadoProperty, value); }
        }

        #endregion

        //Constructor
        public CardCoilView()
        {
            InitializeComponent();           
        }

        private async void Escanear(object sender, EventArgs e)
        {

            await Task.Run(() =>
            {
                Thread.Sleep(1000);
            });

            CardEscaneado = true;
           
        }       
    }
}