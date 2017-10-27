using ListaAgrupada.Modelos;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ListaAgrupada.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        string[] grupos = { "Primeiro", "Segundo", "Terceiro", "Quarto", "Quinto" };
        List<Model> Lista = new List<Model>();
        public ObservableCollection<Agrupamento<string, Model>> ListaAgrupada { get; private set; }

        public MainViewModel()
        {
            CarregarLista();
        }

        private void CarregarLista()
        {
            foreach (var c in grupos)
            {
                for (var j = 1; j <= 30; j++)
                {
                    var m = new Model(c, $"Info {j}");
                    Lista.Add(m);
                }
            }

            var _listaAgrupada = Lista
                .GroupBy(x => x.Grupo)
                .Select(x => new Agrupamento<string, Model>(x.Key, x.Select(y => y)));

            ListaAgrupada = new ObservableCollection<Agrupamento<string, Model>>(_listaAgrupada);

        }
    }
}
