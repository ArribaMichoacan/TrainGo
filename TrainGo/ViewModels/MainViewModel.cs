using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TrainGo.Views;
using Xamarin.Forms;

namespace TrainGo.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region VARIABLES        
        #endregion
        #region CONSTRUCTOR
        public MainViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
      
        #endregion
        #region PROCESOS
        public async Task ComenzarCarga()
        {
            await Navigation.PushAsync(new RegistroView());
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand ComenzarCargaCommand => new Command(async () => await ComenzarCarga());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
