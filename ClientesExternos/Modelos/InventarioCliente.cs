
namespace ClientesExternos.Modelos
{
    public class InventarioCliente
    {
        private string _codigo;
        private string _articulo;

        public string numero_etiqueta { set; get; }
        public string tarima_cliente { set; get; }

        public string codigo
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
        public string articulo 
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
        public string codigo_articulo
        {
            get
            {
                return _codigo + " - " + _articulo;
            }
        }

        public long cajas { set; get; }
        public decimal peso { set; get; }
        public string unidad
        {
            get { return "Kgs"; }
        }
    }
}
