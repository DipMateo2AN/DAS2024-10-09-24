namespace Modelo_V2.Objetos
{
    public class Categoria
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return Codigo + " - " + Descripcion;
        }
    }
}
