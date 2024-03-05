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
        #endregion
        #region CONSTRUCTOR
        public RegistroViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS

        #endregion
        #region PROCESOS
        public async Task RegresarPage()
        {
            await Navigation.PopToRootAsync();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand RegresarPageCommand => new Command(async () => await RegresarPage());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion

    }
}
