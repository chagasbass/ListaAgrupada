using ListaAgrupada.Modelos;
using ListaAgrupada.ViewModels;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ListaAgrupada
{
    public partial class MainPage : ContentPage
    {
        List<Model> lista = new List<Model>();

        private MainViewModel ViewModel
        {
            get { return BindingContext as MainViewModel; }
            set { BindingContext = value; }
        }

        public MainPage()
        {
            InitializeComponent();
            ViewModel = new MainViewModel();
            BindingContext = ViewModel;
            
        }
    }
}
