using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainGo.UserControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomToolBarView : ContentView
    {

        public static readonly BindableProperty ToolBarTitleIsVisibleProperty = BindableProperty.Create(
           nameof(ToolBarTitle),
           typeof(string),
           typeof(CustomToolBarView),
           default(string),
           defaultBindingMode: BindingMode.OneWay);

        public CustomToolBarView()
        {
            InitializeComponent();
        }

        public string ToolBarTitle
        {
            get => (string)GetValue(ToolBarTitleIsVisibleProperty);
            set => SetValue(ToolBarTitleIsVisibleProperty, value);
        }


    }
}