using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientesExternos.Modelos
{
    public class SalidasGrid
    {
        public long ID_Tarima { set; get; }
        public string NumeroTarima { set; get; }
        public string NumeroTarimaCliente { set; get; }

        public long ID_Articulo { set; get; }
        public string Codigo { set; get; }
        public string Articulo { set; get; }

        public long ID_Cliente { set; get; }
        public string Cliente{ set; get; }

        public int Cajas { set; get; }
        public decimal Peso { set; get; }

        public int CajasMax { set; get; }
        public decimal PesoMax { set; get; }
        public string Unidad
        {
            get
            {
                return "Kgs";
            }
        }
    }
}
