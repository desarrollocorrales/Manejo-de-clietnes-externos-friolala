using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientesExternos.Entity;

namespace ClientesExternos.Modelos
{
    public static class DatosDeApp
    {
        public static usuarios usuario_en_turno = null;
    }

    public enum TiposDeAccion
    {
        Nuevo = 1,
        Modificar = 2,
        Eliminar= 3
    }
}
