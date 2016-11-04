
namespace ClientesExternos.Modelos
{
    public class EntradasPorDia
    {
        private string _codigo, _articulo;

        public string Cliente { set; get; }
        public string TarimaCliente { set; get; }
        public string NumeroEtiqueta { set; get; }
        public string Codigo
        {
            set
            {
                _codigo = value;
            }
            get
            {
                return _codigo;
            }
        }
        public string Articulo
        {
            set
            {
                _articulo = value;
            }
            get
            {
                return _articulo;
            }
        }
        public string Codigo_Articulo
        {
            get
            {
                return _codigo + " - " +_articulo;
            }
        }
        public long Cajas { set; get; }
        public decimal Peso { set; get; }
        public string Unidad 
        { 
            get 
            { 
                return "Kgs"; 
            } 
        }
    }
}
