using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using ClientesExternos.Modelos;
using System.Data;

namespace ClientesExternos.DAL
{
    public class MyDAL
    {
        private string ConnectionString;
        private MySqlConnection MyConexion;
        private MySqlCommand MyComando;
        private MySqlDataAdapter MyAdapter;

        public MyDAL()
        {
            this.ConnectionString = getConnectionString();
            MyConexion = new MySqlConnection(this.ConnectionString);
            MyComando = new MySqlCommand();
            MyAdapter = new MySqlDataAdapter();
        }

        private string getConnectionString()
        {
            var Config = Properties.Settings.Default;
            MySqlConnectionStringBuilder mycsb = new MySqlConnectionStringBuilder();
            mycsb.Server = Config.Server;
            mycsb.UserID = Config.User;
            mycsb.Password = Config.Pass;
            mycsb.Port = Convert.ToUInt32(Config.Port);
            mycsb.Database = Config.Database;

            return mycsb.ToString();
        }

        public List<InventarioCliente> getInventarioPorCliente(long id_cliente)
        {
            List<InventarioCliente> lstInventarioCliente = new List<InventarioCliente>();

            MyConexion.Open();

            MyComando.Connection = MyConexion;
            MyComando.CommandText = string.Format(
                @"SELECT 
	                 numero_etiqueta, tarima_cliente, codigo, articulo, sum(num_cajas) cajas, sum(peso) peso
                  FROM
                     friolala_clientext.vw_inventario
                  WHERE
                     id_cliente = {0}
                  GROUP BY 
	                numero_etiqueta, codigo, articulo
                  HAVING cajas != 0", id_cliente);

            DataTable dt = new DataTable();
            MyAdapter.SelectCommand = MyComando;
            MyAdapter.Fill(dt);

            InventarioCliente InvClien;
            foreach (DataRow Row in dt.Rows)
            {
                InvClien = new InventarioCliente();
                InvClien.numero_etiqueta = Convert.ToString(Row["numero_etiqueta"]);
                InvClien.tarima_cliente = Convert.ToString(Row["tarima_cliente"])+" ";
                InvClien.codigo = Convert.ToString(Row["codigo"]);
                InvClien.articulo = Convert.ToString(Row["articulo"]);
                InvClien.cajas = Convert.ToInt64(Row["cajas"]);
                InvClien.peso = Convert.ToDecimal(Row["peso"]);

                lstInventarioCliente.Add(InvClien);
            }

            MyConexion.Close();

            return lstInventarioCliente;
        }

        public List<EntradasPorDia> getEntradasPorDia(DateTime fecha, long id_cliente)
        {
            var fecha_ini = fecha.ToString("yyyy-MM-dd");
            var fecha_fin = fecha.AddDays(1).ToString("yyyy-MM-dd");
            List<EntradasPorDia> lstEntregasPorDia = new List<EntradasPorDia>();

            MyConexion.Open();

            MyComando.Connection = MyConexion;
            MyComando.CommandText = string.Format(
                @"SELECT 
	                    c.nombre AS cliente,
                        te.numero_tarima_cliente AS tarima_cliente,
                        te.numero_etiqueta,
                        a.codigo,
                        a.nombre AS articulo,
                        te.num_cajas AS cajas,
                        te.peso
                    FROM
                        tarimas_entradas te
                            INNER JOIN articulos a ON te.id_articulo = a.id_articulo
                            INNER JOIN clientes c ON te.id_cliente = c.id_cliente
                    WHERE
	                    te.fecha_ingreso > '{0}' AND  te.fecha_ingreso < '{1}' ", fecha_ini, fecha_fin);
            if (id_cliente != 0)
            {
                MyComando.CommandText += string.Format(" AND te.id_cliente = {0}", id_cliente);
            }

            DataTable dt = new DataTable();
            MyAdapter.SelectCommand = MyComando;
            MyAdapter.Fill(dt);

            EntradasPorDia _entregaPorDia;
            foreach (DataRow Row in dt.Rows)
            {
                _entregaPorDia = new EntradasPorDia();
                _entregaPorDia.Cliente = Convert.ToString(Row["cliente"]);
                _entregaPorDia.TarimaCliente = Convert.ToString(Row["tarima_cliente"]) + " ";
                _entregaPorDia.NumeroEtiqueta = Convert.ToString(Row["numero_etiqueta"]);
                _entregaPorDia.Codigo = Convert.ToString(Row["codigo"]);
                _entregaPorDia.Articulo = Convert.ToString(Row["articulo"]);
                _entregaPorDia.Cajas = Convert.ToInt64(Row["cajas"]);
                _entregaPorDia.Peso = Convert.ToDecimal(Row["peso"]);

                lstEntregasPorDia.Add(_entregaPorDia);
            }

            MyConexion.Close();

            return lstEntregasPorDia;
        }
    }
}
