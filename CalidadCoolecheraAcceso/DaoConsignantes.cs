using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalidadCoolecheraModelos.Modelos;
using Dapper;
using System.Data;

namespace CalidadCoolecheraAcceso
{
    public class DaoConsignantes
    {
        private ConexionBaseDatos pConexion;

        public ConexionBaseDatos Pconexion { get => pConexion; set => pConexion = value; }

        public DaoConsignantes(ConexionBaseDatos cn = null)
        {
            pConexion = cn;
        }

        public DaoConsignantes(string cadenaConexion)
        {
            pConexion = new ConexionBaseDatos(cadenaConexion);
        }

        public List<Consignante> Listar(IDbTransaction transaction = null)
        {
            var Lsql = "SELECT * FROM calidad.mtconsignante";
            var calidad_cda = pConexion.Conexion.Query<Consignante>(Lsql, transaction).ToList();
            return calidad_cda;
        }

        public List<Consignante> Listar( string filtro, IDbTransaction transaction = null)
        {
            var Lsql = "SELECT * FROM calidad.mtconsignante WHERE (codconsignante LIKE '%"+filtro+"%') OR (nombre  LIKE '%" + filtro + "%') ";
            var calidad_cda = pConexion.Conexion.Query<Consignante>(Lsql, transaction).ToList();
            return calidad_cda;
        }

        public Consignante buscar(string codconsignante, IDbTransaction transaction = null)
        {
            var strSQl = "SELECT * FROM calidad.mtconsignante where codconsignante = @codconsignante ";
            var Calidad_Leche = pConexion.Conexion.QueryFirstOrDefault<Consignante>(strSQl, new { codconsignante = codconsignante }, transaction);
            return Calidad_Leche;
        }
    }
}
