namespace ListaAgrupada.Modelos
{
    public class Model
    {
        public string Grupo { get; }
        public string Info { get; }

        public Model(string grupo, string info)
        {
            Grupo = grupo;
            Info = info;
        }
    }
}