using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace CalidadCoolecheraAcceso
{
    public class ConexionBaseDatos
    {
        private NpgsqlConnection pConexion;

        public ConexionBaseDatos(string cadenaConexion)
        {
            pConexion = new NpgsqlConnection(cadenaConexion);
        }

        public NpgsqlConnection Conexion { get => pConexion; }

        public NpgsqlConnection AbrirConexion()
        {
            if (pConexion.State == System.Data.ConnectionState.Closed )
                pConexion.Open();
            return pConexion;
        }

        public NpgsqlConnection CerrarConexion()
        {
            if (pConexion.State == System.Data.ConnectionState.Open)
                pConexion.Close();
            return pConexion;
        }
    }
}
