using ListaAgrupada.Modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace ListaAgrupada
{
    public partial class MainPage : ContentPage
    {
        List<Model> lista = new List<Model>();

        public MainPage()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            string[] grupos = { "Primeiro", "Segundo", "Terceiro", "Quarto", "Quinto" };

            foreach (var c in grupos)
            {
                for (var j = 1; j <= 30; j++)
                {
                    var m = new Model(c, $"Info {j}");
                    lista.Add(m);
                }
            }

            var listaAgrupada = lista
                .GroupBy(x => x.Grupo)
                .Select(x => new Agrupamento<string, Model>(x.Key, x.Select(y => y)));

            MyListView.ItemsSource = new ObservableCollection<Agrupamento<string, Model>>(listaAgrupada);
        }
    }
}
