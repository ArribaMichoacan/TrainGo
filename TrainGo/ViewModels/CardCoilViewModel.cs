using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TrainGo.ViewModels
{
    public class CardCoilViewModel : BaseViewModel
    {
        #region VARIABLES

        

        private string cardPosicion;
        private string cardId;
        private string cardMaterial;
        private string cardPeso;
        private bool cardEscaneado;
        private string textButton;

        #endregion VARIABLES

        #region CONSTRUCTOR

        public CardCoilViewModel()
        {
        }

        #endregion CONSTRUCTOR

        #region OBJETOS

        public string CardPosicion
        {
            get { return cardPosicion; }

            set
            {
                SetValue(ref cardPosicion, value);
            }
        }

        public string CardId
        {
            get { return cardId; }

            set
            {
                SetValue(ref cardId, value);
            }
        }

        public string CardMaterial
        {
            get { return cardMaterial; }

            set
            {
                SetValue(ref cardMaterial, value);
            }
        }

        public string CardPeso
        {
            get { return cardPeso; }

            set
            {
                SetValue(ref cardPeso, value);
            }
        }

        public bool CardEscaneado
        {
            get { return cardEscaneado; }

            set
            {
                SetValue(ref cardEscaneado, value);
            }
        }

        public string TextButton
        {
            get
            {
                return textButton;
            }

            set
            {
                SetValue(ref textButton, value);
            }
        }

        #endregion OBJETOS

        #region PROCESOS

        public async Task Escanear()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(1000);
            });

               CardEscaneado = true;
        }

        public void ProcesoSimple()
        {
        }

        #endregion PROCESOS

        #region COMANDOS

        public ICommand EscanearCommand => new Command(async () => await Escanear());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);

        #endregion COMANDOS
    }
}