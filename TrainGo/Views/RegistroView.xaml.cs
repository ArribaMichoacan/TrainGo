using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainGo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainGo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroView : ContentPage
    {
        public RegistroView()
        {
            InitializeComponent();
            BindingContext = new RegistroViewModel(Navigation);
        }
    }
}